using AutoTurn.Application.Services.Authentication;
using ErrorOr;
using MediatR;
using System.Security.Claims;

namespace AutoTurn.Application.Authentication.Queries;


public record UpdateUserQuery(
    string? Id,
    string Username,
    string FirstName,
    string LastName,
    string Email,
    string Password,
    bool IsAdmin
   
    ) : IRequest<ErrorOr<AuthenticationResult>>
{
    
    public ClaimsPrincipal? AuthUser { get; set; }
}

