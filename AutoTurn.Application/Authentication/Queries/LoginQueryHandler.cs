using AutoTurn.Application.Interfaces;
using AutoTurn.Application.Interfaces.Repository;
using AutoTurn.Application.Services.Authentication;
using AutoTurn.Models;
using AutoTurn.Models.Errors;
using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace AutoTurn.Application.Authentication.Queries;


public class LoginQueryHandler : IRequestHandler<LoginQuery, ErrorOr<AuthenticationResult>>
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly UserManager<User> _userManager;
    private readonly IUserRepository _userRepository;

    public LoginQueryHandler(
        IJwtTokenGenerator jwtTokenGenerator,
        UserManager<User> userManager,
        IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userManager = userManager;
        _userRepository = userRepository;
    }

    public async Task<ErrorOr<AuthenticationResult>> Handle(LoginQuery request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetUserByUserNameAsync(request.Username);

        if (user is null)
        {
            return Errors.Authentication.InvalidCredentials;
        }

        if (!await _userManager.CheckPasswordAsync(user, request.Password))
        {
            return Errors.Authentication.InvalidCredentials;
        }

        string Role = "Normal";
        if (user.IsSuperAdmin)
        {
            Role = "SuperAdmin";
        }
        else if (user.IsAdmin)
        {
            Role = "Admin";
        }

        var token = _jwtTokenGenerator.GenerateToken(user.Id,
                                                     user.FirstName,
                                                     user.LastName,
                                                     Role);

        return new AuthenticationResult
        {
            Username = user.UserName,
            LastName = user.LastName,
            FirstName = user.FirstName,
            Id = user.Id,
            Email = user.Email,
            Token = token,
        };
    }
}
