using AutoTurn.Application.Interfaces.Repository;
using AutoTurn.Models;
using AutoTurn.Models.Errors;
using ErrorOr;
using MapsterMapper;
using MediatR;

namespace AutoTurn.Application.Plans.Commands
{
    public class PlanCommandHandler : IRequestHandler<PlanCommand, ErrorOr<Plan>>
    {
        private readonly IMapper _mapper;
        private readonly IPlanRepository _planRepository;

        public PlanCommandHandler(IMapper mapper, IPlanRepository planRepository)
        {
            _mapper = mapper;
            _planRepository = planRepository;
        }

        public async Task<ErrorOr<Plan>> Handle(PlanCommand request, CancellationToken cancellationToken)
        {
            var plan = _mapper.Map<Plan>(request);

            if(request.RelatedPlanIds is not null)
            {
                foreach(int PlanId in request.RelatedPlanIds)
                {
                    var relatedPlan = await _planRepository.GetPlanById(PlanId);
                    if(relatedPlan == null) return Errors.Plan.NotFound;
                    plan.RelatedPlans.Add(relatedPlan);
                }
            }

            await _planRepository.AddPlanAsync(plan);
            return plan;
        }
    }
}
