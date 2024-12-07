using ErrorOr;
using MediatR;
using System.Security.Claims;
using System.Text.Json.Serialization;

namespace AutoTurn.Application.Turns.Queries.DeleteTurnQuery;

public record DeleteTurnQuery : IRequest<ErrorOr<bool>>
{
    [JsonIgnore]
    public int? Id { get; set; }
    [JsonIgnore]
    public ClaimsPrincipal? AuthUser { get; set; }
}
