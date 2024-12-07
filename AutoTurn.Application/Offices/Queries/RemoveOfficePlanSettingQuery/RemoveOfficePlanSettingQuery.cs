using AutoTurn.Models;
using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Text.Json.Serialization;

namespace AutoTurn.Application.Offices.Queries.RemoveOfficePlanSettingQuery
{
    public record RemoveOfficePlanSettingQuery(
        int PlanId
        ) : IRequest<ErrorOr<Office>>
    {
        [JsonIgnore]
        public int Id { get; set; }
        [JsonIgnore]
        public ClaimsPrincipal? AuthUser { get; set; }
    }
}
