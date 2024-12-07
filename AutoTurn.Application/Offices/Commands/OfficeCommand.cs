using AutoTurn.Models;
using ErrorOr;
using MediatR;
using System.Security.Claims;
using System.Text.Json.Serialization;

namespace AutoTurn.Application.Offices.Commands;

public record OfficeCommand(
    int Id,
    string? AdminId,
    string Name,
    int? ProvinceId,
    AddressCommand Address,
    List<DateOnly> DaysOff
    ) : IRequest<ErrorOr<Office>>
{
    [JsonIgnore]
    public ClaimsPrincipal? AuthUser { get; set; }
}

public record AddressCommand(
    string City,
    string Street,
    string PostalCode
    );