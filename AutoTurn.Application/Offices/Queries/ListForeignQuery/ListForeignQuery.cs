using AutoTurn.Contracts;
using AutoTurn.Models;
using ErrorOr;
using MediatR;
using System.Security.Claims;
using System.Text.Json.Serialization;

namespace AutoTurn.Application.Offices.Queries.ListForeignQuery;

public record ListForeignQuery : IRequest<ErrorOr<List<Foreign>>>
{
    public PaginationRequest? PageRequest { get; set; }
    [JsonIgnore]
    public ClaimsPrincipal? AuthUser { get; set; }
}
