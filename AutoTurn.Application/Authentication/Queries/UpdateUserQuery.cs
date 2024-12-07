using AutoTurn.Application.Services.Authentication;
using ErrorOr;
using MediatR;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Text.Json.Serialization;

namespace AutoTurn.Application.Authentication.Queries;


public record UpdateUserQuery(
    string Id,
    string Username,
    string FirstName,
    string LastName,
    [EmailAddress]string Email,
    string Password,
    bool? IsAdmin = false
   
    ) : IRequest<ErrorOr<AuthenticationResult>>
{
    [JsonIgnore]    
    public ClaimsPrincipal? AuthUser { get; set; }
}

