using AutoTurn.Application.Interfaces;
using AutoTurn.Application.Services.Authentication;
using AutoTurn.Models;
using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Identity;
using AutoTurn.Models.Errors;

namespace AutoTurn.Application.Authentication.Commands;


public class RegisterCommandHandler : IRequestHandler<RegisterCommand, AuthenticationResult>
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly UserManager<User> _userManager;

    public RegisterCommandHandler(IJwtTokenGenerator jwtTokenGenerator, UserManager<User> userManager)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userManager = userManager;
    }

    public IJwtTokenGenerator JwtTokenGenerator { get; }

    public async Task<AuthenticationResult> Handle(
        RegisterCommand request,
        CancellationToken cancellationToken)
    {
        User user = new User
        {
            UserName = request.UserName,
            Email = request.Email,
            FirstName = request.FirstName,
            LastName = request.LastName,

        };

        var result = await _userManager.CreateAsync(user, request.Password);

        if (result.Succeeded)
        {
            var token = _jwtTokenGenerator.GenerateToken(user.Id,
                                                         request.FirstName,
                                                         request.LastName);


            return new AuthenticationResult {
                Id = user.Id, 
                Username = user.UserName,
                FirstName = user.FirstName, 
                LastName = user.LastName, 
                Email = user.Email, 
                Token = token 
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
