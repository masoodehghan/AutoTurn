
using AutoTurn.Models;
using AutoTurn.Models.Enums;
using ErrorOr;
using MediatR;

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
    public int Id { get; set; }
}