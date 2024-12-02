using AutoTurn.Models;
using ErrorOr;
using MediatR;
using System.Security.Claims;

namespace AutoTurn.Application.Offices.Queries.RemoveOfficeUserQuery;

public record RemoveOfficeUserQuery(
    List<string> UserIds 
    ) : IRequest<ErrorOr<Office>>
{
    public int Id { get; set; } = 0;
    public ClaimsPrincipal? AuthUser { get; set; }
}
