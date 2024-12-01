using AutoTurn.Application.Interfaces.Repository;
using AutoTurn.Models;
using AutoTurn.Models.Errors;
using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace AutoTurn.Application.Offices.Queries.DeleteOfficeQuery;


public class DeleteOfficeQueryHandler : IRequestHandler<DeleteOfficeQuery, ErrorOr<bool>>
{
    private readonly IOfficeRepository _officeRepository;
    private readonly UserManager<User> _userManager;
    public DeleteOfficeQueryHandler(IOfficeRepository officeRepository, UserManager<User> userManager)
    {
        _officeRepository = officeRepository;
        _userManager = userManager;
    }

    public async Task<ErrorOr<bool>> Handle(DeleteOfficeQuery request, CancellationToken cancellationToken)
    {
        var office = await _officeRepository.GetOfficeByIdAsync(request.Id);
        var userId = _userManager.GetUserId(request.AuthUser);

        if (office == null) return Errors.Office.NotFound;

        if (userId != office.Province.AdminId)
        {
            if (!request.AuthUser.IsInRole("SuperAdmin"))
                return Errors.Authentication.Forbidden;
        }
        

        await _officeRepository.DeleteOfficeAsync(office);

        return true;

    }
}
