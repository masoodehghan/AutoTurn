using AutoTurn.Application.Interfaces.Repository;
using AutoTurn.Application.Interfaces;
using AutoTurn.Application.Services.Authentication;
using AutoTurn.Models;
using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Identity;
using AutoTurn.Models.Errors;
using Microsoft.IdentityModel.Tokens;
namespace AutoTurn.Application.Authentication.Queries;


public class UpdateUserQueryHandler : IRequestHandler<UpdateUserQuery, ErrorOr<AuthenticationResult>>
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly UserManager<User> _userManager;
    private readonly IUserRepository _userRepository;

    public UpdateUserQueryHandler(
        IJwtTokenGenerator jwtTokenGenerator,
        UserManager<User> userManager,
        IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userManager = userManager;
        _userRepository = userRepository;
    }
    public async Task<ErrorOr<AuthenticationResult>> Handle(UpdateUserQuery request, CancellationToken cancellationToken)
    {
        var AuthUserId = _userManager.GetUserId(request.AuthUser!);

        var user = await _userRepository.GetUserByIdAsync(request.Id ?? AuthUserId!);


        if (user is null)
        {
            return Errors.Authentication.InvalidCredentials;
        }

        if (user.Id != AuthUserId && !request.AuthUser!.IsInRole("SuperAdmin"))
        {
            return Errors.Authentication.Forbidden;
        }

        user.UserName = request.Username ?? user.UserName;
        user.FirstName = request.FirstName ?? user.FirstName;
        user.LastName = request.LastName ?? user.LastName;
        user.Email = request.Email ?? user.Email;

        if (request.AuthUser!.IsInRole("SuperAdmin") && request.IsAdmin)
        {
            user.IsAdmin = request.IsAdmin;
        }

        var result = await _userManager.UpdateAsync(user);

        if (result.Succeeded)
        {
            return new AuthenticationResult
            {
                Username = user.UserName,
                LastName = user.LastName,
                FirstName = user.FirstName,
                Id = user.Id,
                Email = user.Email,
            };
        }
        else
        {
            return new AuthenticationResult
            {
                Errors = result.Errors
            };
        }
    }
}
