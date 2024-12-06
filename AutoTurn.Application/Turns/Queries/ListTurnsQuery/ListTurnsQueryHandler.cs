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

namespace AutoTurn.Application.Turns.Queries.ListTurnsQuery;

internal class ListTurnsQueryHandler : IRequestHandler<ListTurnsQuery, ErrorOr<List<Turn>>>
{
    private readonly ITurnRepository _turnRepository;
    private readonly IUserRepository _userRepository;
    private readonly UserManager<User> _userManager;

    public ListTurnsQueryHandler(
        ITurnRepository turnRepository,
        IUserRepository userRepository,
        UserManager<User> userManager)
    {
        _turnRepository = turnRepository;
        _userRepository = userRepository;
        _userManager = userManager;
    }

    public async Task<ErrorOr<List<Turn>>> Handle(ListTurnsQuery request, CancellationToken cancellationToken)
    {
        int? officeId = request.OfficeId ;
        if(request.AuthUser!.IsInRole("Normal"))
        {
            var user = await _userRepository
                .GetUserByIdWithOfficeAsync(
                _userManager.GetUserId(request.AuthUser)!);

            officeId = user!.OfficeId ?? 0;

            if(officeId == 0) return Errors.Authentication.Forbidden;
        }

        
        var turns =  await _turnRepository.TurnListWithFilters(
            request.PlanId,
            request.ForeignCode,
            request.IsTransfered,
            request.StartTime,
            request.EndTime,
            request.IsDeleted,
            officeId,
            request.PageRequest?.PageIndex,
            request.PageRequest?.PageSize
            );


        return new List<Turn>(turns);
    }
}
