
using AutoTurn.Models;
using AutoTurn.Models.Enums;
using ErrorOr;
using MediatR;
using System.Text.Json.Serialization;

namespace AutoTurn.Application.Plans.Queries;
public record UpdatePlanQuery(
    string? Name,
    int? MaxDeleteCount,
    int? DayBetween,
    int? DuarationMinute,
    PlanType? PlanType,
    List<int>? RelatedPlanIds,
    int? Capacity,
    bool? IsTranferAvailable,
    CodeType? CodeType
    ):IRequest<ErrorOr<Plan>>
{
    [JsonIgnore]
    public int Id { get; set; }
}