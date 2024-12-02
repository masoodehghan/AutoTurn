using AutoTurn.Models;
using ErrorOr;
using MediatR;
using System.Security.Claims;

namespace AutoTurn.Application.Offices.Queries.OfficePlanSettingQuery
{
    public record OfficePlanSettingQuery(
        int PlanId,
        DateTime StartTime,
        DateTime EndTime,
        int Capacity
        ) : IRequest<ErrorOr<Office>>
    {
        public int Id { get; set; }
        public ClaimsPrincipal? AuthUser { get; set; }
    }
}
