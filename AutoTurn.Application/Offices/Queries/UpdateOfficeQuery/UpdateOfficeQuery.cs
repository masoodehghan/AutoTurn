
using AutoTurn.Application.Offices.Commands;
using AutoTurn.Models;
using ErrorOr;
using MediatR;
using System.Security.Claims;

namespace AutoTurn.Application.Offices.Queries.UpdateOfficeQuery;

public record UpdateOfficeQuery(
string? AdminId,
string Name,
int? ProvinceId,
AddressCommand Address) : IRequest<ErrorOr<Office>>
{
    public ClaimsPrincipal? AuthUser { get; set; }
    public int Id { get; set; } = 0;
}


