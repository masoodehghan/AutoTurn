using AutoTurn.Contracts;
using AutoTurn.Models;
using ErrorOr;
using MediatR;
using System.Security.Claims;
using System.Text.Json.Serialization;

namespace AutoTurn.Application.Offices.Queries.ListOfficeQuery;
public record ListOfficeQuery(
    int? ProvinceId,
    string? ProvinceName) : IRequest<ErrorOr<List<Office>>>
{
    [JsonIgnore]
    public ClaimsPrincipal? AuthUser { get; set; }
    public  PaginationRequest? PageRequest { get; set; }
}

