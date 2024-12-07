using ErrorOr;
using MediatR;
using System.Security.Claims;

namespace AutoTurn.Application.Turns.Queries.DeleteTurnQuery;

public record DeleteTurnQuery : IRequest<ErrorOr<bool>>
{
    public int? Id { get; set; }
    public ClaimsPrincipal? AuthUser { get; set; }
}
