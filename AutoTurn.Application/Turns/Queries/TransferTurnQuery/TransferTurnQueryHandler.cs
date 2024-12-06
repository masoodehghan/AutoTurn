using AutoTurn.Application.Interfaces.Repository;
using AutoTurn.Models;
using AutoTurn.Models.Errors;
using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AutoTurn.Models.Errors.Errors;

namespace AutoTurn.Application.Turns.Queries.TransferTurnQuery;

internal class TransferTurnQueryHandler : IRequestHandler<TransferTurnQuery, ErrorOr<Turn>>
{
    private readonly ITurnRepository _turnRepository;
    private readonly IUserRepository _userRepository;
    private readonly UserManager<User> _userManager;
    private readonly IOfficeRepository _officeRepository;

    public TransferTurnQueryHandler(
        ITurnRepository turnRepository,
        IUserRepository userRepository,
        UserManager<User> userManager,
        IOfficeRepository officeRepository)
    {
        _turnRepository = turnRepository;
        _userRepository = userRepository;
        _userManager = userManager;
        _officeRepository = officeRepository;
    }

    public async Task<ErrorOr<Turn>> Handle(TransferTurnQuery request, CancellationToken cancellationToken)
    {
        var turn = await _turnRepository.GetTurnByIdAsync(request.TurnId);
        if (turn == null) return Error.NotFound(code: "turn not found");

        if (request.AuthUser.IsInRole("Normal"))
        {
            var user = await _userRepository.GetUserByIdWithOfficeAsync(
                    _userManager.GetUserId(request.AuthUser)!);


            if (user == null) return Errors.Authentication.NotFound;

            if(user.OfficeId == null) return Errors.Authentication.Forbidden;

            if(user.OfficeId != turn.OfficeId) return Errors.Authentication.Forbidden;
        }

        var office = await _officeRepository.GetOfficeByIdAsyncWithPlan(request.OfficeId);

        if(office == null) return Errors.Office.NotFound;

        if (!office.Plans.Contains(turn.Plan))
        {
            return Error.Validation(code: "office doesent contain this plan");
        }
        var planSetting = office.PlanSettings.Single(s => s.PlanId == turn.PlanId);


        TimeSpan TimeOfStart = planSetting.StartTime.TimeOfDay;
        TimeSpan TimeOfEnd = planSetting.EndTime.TimeOfDay;

        DateTime start;
        DateTime end;

        var turns = await _turnRepository.TurnListDescendByTime(office.Id, turn.Plan.Id);

        if (turns.Count == 0)
        {
            start = DateTime.Now.Date + TimeOfStart;
            end = start.AddMinutes(office.Plan.DuarationMinute);
        }
        else
        {
            var lastTurn = turns.Last().EndTime;
            start = lastTurn;
            end = start.AddMinutes(turn.Plan.DuarationMinute);
        }

        if (start < DateTime.Now)
        {
            start = DateTime.Now;
            end = start.AddMinutes(turn.Plan.DuarationMinute);
        }

        if (end.TimeOfDay > TimeOfEnd)
        {

            start = (turns.Last().StartTime.Date == start.Date)
                ? start.AddDays(1)
                : start.AddDays(1).Date + TimeOfStart;

            end = start.AddMinutes(turn.Plan.DuarationMinute);
        }

        if (start.DayOfWeek == DayOfWeek.Friday)
        {
            start = (turns.Last().StartTime.Date == start.Date)
                ? start.AddDays(1)
                : start.AddDays(1).Date + TimeOfStart;

            end = start.AddMinutes(turn.Plan.DuarationMinute);
        }


        if (planSetting.PlanCapacity <= planSetting.PlanForeignCount)
        {
            return Error.Validation(code: "maximum capacity reached");
        }

        planSetting.PlanForeignCount++;
        turn.TranferedOfficeId = office.Id;
        turn.StartTime = start;
        turn.EndTime = end;

        await _officeRepository.SaveChangesAsync();

        return turn;
    }
}
