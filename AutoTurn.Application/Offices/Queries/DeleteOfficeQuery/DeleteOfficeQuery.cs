using ErrorOr;
using MediatR;
using System.Security.Claims;

namespace AutoTurn.Application.Offices.Queries.DeleteOfficeQuery;


public record DeleteOfficeQuery : IRequest<ErrorOr<bool>>
{
    public int Id { get; set; } = 0;
    public ClaimsPrincipal? AuthUser { get; set; }
}
