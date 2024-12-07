
using AutoTurn.Application.Offices.Commands;
using AutoTurn.Models;
using ErrorOr;
using MediatR;
using System.Security.Claims;
using System.Text.Json.Serialization;

namespace AutoTurn.Application.Offices.Queries.UpdateOfficeQuery;

public record UpdateOfficeQuery(
string? AdminId,
string Name,
int? ProvinceId,
List<DateOnly>? DaysOff,
AddressCommand Address) : IRequest<ErrorOr<Office>>
{
    [JsonIgnore]
    public ClaimsPrincipal? AuthUser { get; set; }
    [JsonIgnore]
    public int Id { get; set; } = 0;
}


