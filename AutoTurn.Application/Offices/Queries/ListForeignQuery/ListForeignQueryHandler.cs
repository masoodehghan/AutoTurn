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

namespace AutoTurn.Application.Offices.Queries.ListForeignQuery;

public class ListForeignQueryHandler : 
        IRequestHandler<ListForeignQuery, ErrorOr<List<Foreign>>>
{
    private readonly IForeignRepository _foreignRepository;
    private readonly UserManager<User> _userManager;
    private readonly IUserRepository _userRepository;
    public ListForeignQueryHandler(
        IForeignRepository foreignRepository,
        IUserRepository userRepository,
        UserManager<User> userManager)
    {
        _foreignRepository = foreignRepository;
        _userRepository = userRepository;
        _userManager = userManager;
    }

    public async Task<ErrorOr<List<Foreign>>> Handle(ListForeignQuery request, CancellationToken cancellationToken)
    {
        int? OfficeId = null;


        if(request.AuthUser.IsInRole("Normal"))
        {
            var user = await _userRepository.GetUserByIdAsync(
                _userManager.GetUserId(request.AuthUser));
        
            if (user?.Office is null) return Errors.Authentication.Forbidden;

            OfficeId = user.OfficeId;
        }

        var foreigns =await _foreignRepository.GetAllAsync(
            request.PageRequest?.PageIndex ?? 0,
            request.PageRequest?.PageSize ?? 5,
            OfficeId);

        return new List<Foreign>(foreigns);
    }
}
