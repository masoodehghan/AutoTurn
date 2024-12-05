using AutoTurn.Application.Interfaces.Repository;
using AutoTurn.Models;
using AutoTurn.Models.Enums;
using AutoTurn.Models.Errors;
using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AutoTurn.Application.Turns.Commands;

public class TurnCommandHandler : IRequestHandler<TurnCommand, ErrorOr<Turn>>
{
    private readonly IOfficeRepository _officeRepository;
    private readonly UserManager<User> _userManager;
    private readonly IForeignRepository _foreignRepository;
    private readonly IPlanRepository _planRepository;
    private readonly IUserRepository _userRepository;
    private readonly ITurnRepository _turnRepository;


    public TurnCommandHandler(
        IOfficeRepository officeRepository,
        UserManager<User> userManager,
        IForeignRepository foreignRepository,
        IPlanRepository planRepository,
        IUserRepository userRepository,
        ITurnRepository turnRepository)
    {
        _officeRepository = officeRepository;
        _userManager = userManager;
        _foreignRepository = foreignRepository;
        _planRepository = planRepository;
        _userRepository = userRepository;
        _turnRepository = turnRepository;
    }

    public async Task<ErrorOr<Turn>> Handle(TurnCommand request, CancellationToken cancellationToken)
    {
        string userId = _userManager.GetUserId(request.AuthUser!);

        Office office;
        if (!request.AuthUser.IsInRole("Normal"))
        {
            if (request.OfficeId is null) return Error.Validation(code: "office id required");
            office = await _officeRepository.GetOfficeByIdAsyncWithPlan((int)request.OfficeId);

            if (office == null) return Errors.Office.NotFound;
        }
        else
        {
            User? user = await _userRepository.GetUserByIdWithPlanAsync(userId);
            if (user == null) return Errors.Authentication.NotFound;

            if (user.Office is null) return Errors.Office.WrongData;

            office = user.Office;
        }

        var plan = await _planRepository.GetPlanById(request.PlanId);
        if (plan == null) return Errors.Plan.NotFound;
        if (!office.Plans.Contains(plan))
        {
            return Error.Validation(code: "office doesent contain this plan");
        }

        Foreign? foreign;
        try
        {
            foreign = plan.CodeType switch
            {
                CodeType.Specific => await _foreignRepository.GetBySpecificAsync(
                                    long.Parse(request.ForeignCode)),

                CodeType.Faragir => await _foreignRepository.GetByFaragir(
                        long.Parse(request.ForeignCode)),

                CodeType.Yekta => await _foreignRepository.GetByYektaAsync(
                        long.Parse(request.ForeignCode)),
                _ => await _foreignRepository.GetByPassport(request.ForeignCode),
            };
        }
        catch (Exception ex)
        {
            return Error.Validation(code: "enter a valid Foreign Code");
        }

        if (foreign == null) return Error.NotFound(code: "foreign not found");

        var planSetting = office.PlanSettings.Single(s => s.PlanId == request.PlanId);

        TimeSpan TimeOfStart = planSetting.StartTime.TimeOfDay;
        TimeSpan TimeOfEnd = planSetting.EndTime.TimeOfDay;

        DateTime start;
        DateTime end;

        var turns = await _turnRepository.TurnListDescendByTime(office.Id, plan.Id);

        if (turns.Count == 0)
        {
            start = DateTime.Now.Date + TimeOfStart;
            end = start.AddMinutes(plan.DuarationMinute);
        }
        else
        {
            var lastTurn = turns.Last().EndTime;
            if (lastTurn.Date != DateTime.Now.Date)
            {
                start = DateTime.Now.Date + TimeOfStart;
            } 
            else
            {
                start = DateTime.Now.Date + lastTurn.TimeOfDay;
            }
            end = start.AddMinutes(plan.DuarationMinute);
        }

        if (start < DateTime.Now)
        {
            start = DateTime.Now;
            end = start.AddMinutes(plan.DuarationMinute);
        }

        if (end.TimeOfDay > TimeOfEnd)
        {
            
            start = start.AddDays(1).Date + TimeOfStart;
            end = start.AddMinutes(plan.DuarationMinute);
        }

        if(start.DayOfWeek == DayOfWeek.Friday)
        {
            start = start.AddDays(1).Date + TimeOfStart;
            end = start.AddMinutes(plan.DuarationMinute);

        }


        if(planSetting.PlanCapacity <= planSetting.PlanForeignCount)
        {
            return Error.Validation(code: "maximum capacity reached");
        }

        planSetting.PlanForeignCount++;

        var turn = new Turn
        {
            Office = office,
            Plan = plan,
            Foreign = foreign,
            StartTime = start,
            EndTime = end,
        };

        try
        {
            await _turnRepository.AddTurnAsync(turn);
        }
        catch (DbUpdateException ex)
        {
            return Error.Validation(code: "duplicate foreign code");
        }
        return turn;

    }
}
