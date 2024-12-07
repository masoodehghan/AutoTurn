using AutoTurn.Models;
using ErrorOr;
using MediatR;
using System.Security.Claims;
using System.Text.Json.Serialization;

namespace AutoTurn.Application.Offices.Queries.OfficePlanSettingQuery
{
    public record OfficePlanSettingQuery(
        int PlanId,
        DateTime StartTime,
        DateTime EndTime,
        int Capacity
        ) : IRequest<ErrorOr<Office>>
    {
        [JsonIgnore]
        public int Id { get; set; }
        [JsonIgnore]
        public ClaimsPrincipal? AuthUser { get; set; }
    }
}
