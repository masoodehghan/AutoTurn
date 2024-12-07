using AutoTurn.Contracts;
using AutoTurn.Models;
using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Security.Claims;
using System.Text.Json.Serialization;

namespace AutoTurn.Application.Turns.Queries.ListTurnsQuery;

public record ListTurnsQuery(
        int? PlanId,
        string? ForeignCode,
        bool? IsTransfered,
        DateTime? StartTime,
        DateTime? EndTime,
        bool? IsDeleted,
        int? OfficeId,
        PaginationRequest? PageRequest
    ) : IRequest<ErrorOr<List<Turn>>>
{
    public ListTurnsQuery() : this(null, null, null, null, null, null, null, null)
    { }
    public ClaimsPrincipal? AuthUser { get; set; }
}
