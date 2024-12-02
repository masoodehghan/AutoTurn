using AutoTurn.Application.Interfaces.Repository;
using AutoTurn.Application.Plans.Queries;
using AutoTurn.Models;
using AutoTurn.Models.Errors;
using ErrorOr;
using MapsterMapper;
using MediatR;

namespace AutoTurn.Application.Plans.Commands
{
    public class UpdatePlanQueryHandler : IRequestHandler<UpdatePlanQuery, ErrorOr<Plan>>
    {
        private readonly IMapper _mapper;
        private readonly IPlanRepository _planRepository;

        public UpdatePlanQueryHandler(IMapper mapper, IPlanRepository planRepository)
        {
            _mapper = mapper;
            _planRepository = planRepository;
        }

        public async Task<ErrorOr<Plan>> Handle(UpdatePlanQuery request, CancellationToken cancellationToken)
        {

            var plan = await _planRepository.GetPlanById(request.Id);

            if (plan is null) return Errors.Plan.NotFound;


            plan.Name = request.Name ?? plan.Name;
            plan.Capacity = request.Capacity ?? plan.Capacity;
            plan.DayBetween =   request.DayBetween ?? plan.DayBetween;
            plan.CodeType = request.CodeType ?? plan.CodeType;
            plan.DuarationMinute = request.DuarationMinute ?? plan.DuarationMinute;
            plan.PlanType = request.PlanType ?? plan.PlanType;
            plan.MaxDeleteCount = request.MaxDeleteCount ?? plan.MaxDeleteCount;
            plan.IsTranferAvailable = request.IsTranferAvailable ?? plan.IsTranferAvailable;

            await _planRepository.UpdatePlanAsync(plan);
            return plan;
        }
    }
}
