using AutoTurn.Application.Interfaces.Repository;
using AutoTurn.Models;
using AutoTurn.Models.Errors;
using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace AutoTurn.Application.Offices.Queries.OfficePlanSettingQuery;

public class OfficePlanSettingQueryHandler : IRequestHandler<OfficePlanSettingQuery, ErrorOr<Office>>
{
    private readonly IOfficeRepository _officeRepository;
    private readonly IPlanRepository _planRespository;
    private readonly UserManager<User> _userManager;

    public OfficePlanSettingQueryHandler(
        IOfficeRepository officeRepository,
        IPlanRepository planRespository,
        UserManager<User> userManager)
    {
        _officeRepository = officeRepository;
        _planRespository = planRespository;
        _userManager = userManager;
    }

    public async Task<ErrorOr<Office>> Handle(OfficePlanSettingQuery request, CancellationToken cancellationToken)
    {
        var office = await _officeRepository.GetOfficeByIdAsync(request.Id);

        var plan = await _planRespository.GetPlanById(request.PlanId);
        var userId = _userManager.GetUserId(request.AuthUser);
        if (office == null) return Errors.Office.NotFound;

        if (userId != office.Province.AdminId)
        {
            if (!request.AuthUser.IsInRole("SuperAdmin"))
                return Errors.Authentication.Forbidden;
        }

        if(plan == null) return Errors.Plan.NotFound;

        var planInOffice = office.PlanSettings.FirstOrDefault(s => s.PlanId == request.PlanId);
        if (planInOffice is not null)
        {
            planInOffice.PlanCapacity = request.Capacity;
            planInOffice.StartTime = request.StartTime;
            planInOffice.EndTime = request.EndTime;
        }
        else
        {
            var officeSetting = new PlanSetting
            {
                StartTime = request.StartTime,
                EndTime = request.EndTime,
                PlanCapacity = request.Capacity,
                PlanId = request.PlanId,
            };

            
            office.Plans.Add(plan);
            office.PlanSettings.Add(officeSetting);

        }


        await _officeRepository.SaveChangesAsync();
        return office; 
    }
}

