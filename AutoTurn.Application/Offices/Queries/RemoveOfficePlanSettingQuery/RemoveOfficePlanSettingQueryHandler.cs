using AutoTurn.Application.Interfaces.Repository;
using AutoTurn.Models;
using AutoTurn.Models.Errors;
using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace AutoTurn.Application.Offices.Queries.RemoveOfficePlanSettingQuery;

public class RemoveOfficePlanSettingQueryHandler : IRequestHandler<RemoveOfficePlanSettingQuery, ErrorOr<Office>>
{
    private readonly IOfficeRepository _officeRepository;
    private readonly IPlanRepository _planRespository;
    private readonly UserManager<User> _userManager;

    public RemoveOfficePlanSettingQueryHandler(
        IOfficeRepository officeRepository,
        IPlanRepository planRespository,
        UserManager<User> userManager)
    {
        _officeRepository = officeRepository;
        _planRespository = planRespository;
        _userManager = userManager;
    }

    public async Task<ErrorOr<Office>> Handle(RemoveOfficePlanSettingQuery request, CancellationToken cancellationToken)
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

        if (plan == null) return Errors.Plan.NotFound;




        
        var officeSetting = office.PlanSettings.FirstOrDefault(s => s.PlanId == request.PlanId);
        
        if(officeSetting == null) return Errors.Plan.NotFound;

        office.Plans.Remove(plan);
        office.PlanSettings.Remove(officeSetting);




        await _officeRepository.SaveChangesAsync();
        return office;
    }
}

