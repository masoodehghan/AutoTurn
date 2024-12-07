using AutoTurn.Application.Interfaces.Repository;
using AutoTurn.Models;
using AutoTurn.Models.Errors;
using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace AutoTurn.Application.Turns.Queries.DeleteTurnQuery;

public class DeleteListQueryHandler : IRequestHandler<DeleteTurnQuery, ErrorOr<bool>>
{
    private readonly ITurnRepository _turnRepository;
    private readonly IUserRepository _userRepository;
    private readonly UserManager<User> _userManager;

    public DeleteListQueryHandler(UserManager<User> userManager,
                                  IUserRepository userRepository,
                                  ITurnRepository turnRepository)
    {
        _userManager = userManager;
        _userRepository = userRepository;
        _turnRepository = turnRepository;
    }

    public async Task<ErrorOr<bool>> Handle(DeleteTurnQuery request, CancellationToken cancellationToken)
    {
        var turn = await _turnRepository.GetTurnByIdAsync((int)request.Id!);
        if (turn == null) return Error.NotFound(code: "turn not found");

        var user = await _userRepository.GetUserByIdAsync(
            _userManager.GetUserId(request.AuthUser));

        if(request.AuthUser.IsInRole("Normal") && user?.OfficeId != turn.OfficeId)
        {
            return Errors.Authentication.NotFound;
        }

        if (turn.EndTime < DateTime.Now) return Error.Validation(code: "time of turn passed");

        if(turn.Plan.MaxDeleteCount <= turn.DeletedCount)
        {
            return Error.Validation(code: "maximum delete reached");
        }

        await _turnRepository.DeleteTurnAsync(turn);

        return true;
    }
}
