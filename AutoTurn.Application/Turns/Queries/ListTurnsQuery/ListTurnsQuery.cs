using AutoTurn.Contracts;
using AutoTurn.Models;
using ErrorOr;
using MediatR;
using System.Security.Claims;

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
    public ClaimsPrincipal? AuthUser { get; set; }
}
