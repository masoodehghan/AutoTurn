using AutoTurn.Application.Interfaces.Repository;
using AutoTurn.Models;
using AutoTurn.Models.Errors;
using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace AutoTurn.Application.Offices.Queries.UpdateOfficeQuery;


public class UpdateOfficeQueryHandler : IRequestHandler<UpdateOfficeQuery, ErrorOr<Office>>
{
    private readonly IOfficeRepository _officeRepository;
    private readonly UserManager<User> _userManager;

    public UpdateOfficeQueryHandler(IOfficeRepository officeRepository, UserManager<User> userManager)
    {
        _officeRepository = officeRepository;
        _userManager = userManager;
    }

    public async Task<ErrorOr<Office>> Handle(UpdateOfficeQuery request, CancellationToken cancellationToken)
    {
        var office = await _officeRepository.GetOfficeByIdAsync(request.Id);
        var userId = _userManager.GetUserId(request.AuthUser);

        if (office == null) return Errors.Office.NotFound;

        if (userId != office.Province.AdminId)
        {
            if(!request.AuthUser.IsInRole("SuperAdmin"))
                    return Errors.Authentication.Forbidden;
        }

        if(request.AuthUser.IsInRole("SuperAdmin"))
        {
            office.ProvinceId = request.ProvinceId ?? office.ProvinceId;
        }

        office.Name = request.Name ?? office.Name;
        office.Address.City = request.Address.City;
        office.Address.Street = request.Address.Street;
        office.Address.PostalCode = request.Address.PostalCode;

        if(request.DaysOff is not null)
        {
            foreach(var dayInDb in office.DaysOff)
            {
                if(!request.DaysOff.Contains(dayInDb))
                {
                    office.DaysOff.Remove(dayInDb);
                }
                foreach (var day in request.DaysOff)
                {
                    office.DaysOff.Add(day);
                }
            }
        }

        await _officeRepository.SaveChangesAsync();

        return office;
    }
}
