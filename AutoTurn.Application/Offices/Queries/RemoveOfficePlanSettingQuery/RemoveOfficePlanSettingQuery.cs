using AutoTurn.Models;
using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AutoTurn.Application.Offices.Queries.RemoveOfficePlanSettingQuery
{
    public record RemoveOfficePlanSettingQuery(
        int PlanId
        ) : IRequest<ErrorOr<Office>>
    {
        public int Id { get; set; }
        public ClaimsPrincipal? AuthUser { get; set; }
    }
}
