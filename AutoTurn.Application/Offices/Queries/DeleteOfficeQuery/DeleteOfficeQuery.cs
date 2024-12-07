using ErrorOr;
using MediatR;
using System.Security.Claims;
using System.Text.Json.Serialization;

namespace AutoTurn.Application.Offices.Queries.DeleteOfficeQuery;


public record DeleteOfficeQuery : IRequest<ErrorOr<bool>>
{
    [JsonIgnore]
    public int Id { get; set; } = 0;
    [JsonIgnore]
    public ClaimsPrincipal? AuthUser { get; set; }
}
