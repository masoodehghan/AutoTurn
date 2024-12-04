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

namespace AutoTurn.Application.Offices.Queries.GetOfficeQuery;

public class GetOfficeQueryHandler : IRequestHandler<GetOfficeQuery, ErrorOr<Office>>
{
    private readonly IOfficeRepository _officeRepository;
    private readonly UserManager<User> _userManager;


    public GetOfficeQueryHandler(
        IOfficeRepository officeRepository,
        UserManager<User> userManager)
    {
        _officeRepository = officeRepository;
        _userManager = userManager;
    }

    public async Task<ErrorOr<Office>> Handle(GetOfficeQuery request, CancellationToken cancellationToken)
    {
        var office = await _officeRepository.ReadOnlyOfficeByIdAsync(request.Id);
        var UserId = _userManager.GetUserId(request.AuthUser);
        if (office == null) return Errors.Office.NotFound;

        if (office.Province.AdminId != UserId && !request.AuthUser.IsInRole("SuperAdmin"))
            return Errors.Authentication.Forbidden;


        return office;
    }
}
