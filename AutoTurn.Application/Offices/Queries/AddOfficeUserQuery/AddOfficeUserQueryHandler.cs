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

namespace AutoTurn.Application.Offices.Queries.AddOfficeUserQuery;

public class AddOfficeUserQueryHandler : IRequestHandler<AddOfficeUserQuery, ErrorOr<Office>>
{
    private readonly IOfficeRepository _officeRepository;
    private readonly IUserRepository _userRepository;
    private readonly UserManager<User> _userManager;

    public AddOfficeUserQueryHandler(
        IOfficeRepository officeRepository,
        IUserRepository userRepository,
        UserManager<User> userManager)
    {
        _officeRepository = officeRepository;
        _userRepository = userRepository;
        _userManager = userManager;
    }

    public async Task<ErrorOr<Office>> Handle(AddOfficeUserQuery request, CancellationToken cancellationToken)
    {
        var office = await _officeRepository.GetOfficeByIdAsync(request.Id);
        if (office == null) return Errors.Office.NotFound;
        var userId = _userManager.GetUserId(request.AuthUser);

        if (userId != office.Province.AdminId)
        {
            if (!request.AuthUser.IsInRole("SuperAdmin"))
                return Errors.Authentication.Forbidden;
        }

        foreach (var id in request.UserIds)
        {
            var user = await _userRepository.GetUserByIdAsync(id);
            if (user == null) return Errors.Authentication.NotFound;
            if (user.IsAdmin || user.IsSuperAdmin) return Errors.Authentication.Forbidden;
            if (user.OfficeId is not null) return Errors.Office.WrongData;
            office.Admins.Add(user);
        }

        await _officeRepository.SaveChangesAsync();
        return office;
    }
}
