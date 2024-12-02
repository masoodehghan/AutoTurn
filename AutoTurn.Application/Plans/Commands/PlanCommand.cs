using AutoTurn.Models;
using AutoTurn.Models.Enums;
using ErrorOr;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTurn.Application.Plans.Commands
{
    public record PlanCommand(
        int Id,
        string Name,
        int MaxDeleteCount,
        int? DayBetween,
        int? DuarationMinute,
        PlanType PlanType,
        List<int>? RelatedPlanIds,
        int Capacity,
        bool? IsTranferAvailable,
        CodeType CodeType
        ) : IRequest<ErrorOr<Plan>>;
}
