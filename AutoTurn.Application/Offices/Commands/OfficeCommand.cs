using AutoTurn.Models;
using ErrorOr;
using MediatR;
using System.Security.Claims;

namespace AutoTurn.Application.Offices.Commands;

public record OfficeCommand(
    int Id,
    string? AdminId,
    string Name,
    int? ProvinceId,
    AddressCommand Address
    ) : IRequest<ErrorOr<Office>>
{
    public ClaimsPrincipal? AuthUser { get; set; }
}

public record AddressCommand(
    string City,
    string Street,
    string PostalCode
    );