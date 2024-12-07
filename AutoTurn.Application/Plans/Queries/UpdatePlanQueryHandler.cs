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


            plan = _mapper.Map<Plan>(request);


            if (request.RelatedPlanIds != null)
            {

                foreach(var relatedPlanInDb in plan.RelatedPlans.ToList())
                {
                    if(!request.RelatedPlanIds.Contains(relatedPlanInDb.Id))
                    {
                        plan.RelatedPlans.Remove(relatedPlanInDb);
                    }
                }

                foreach (int PlanId in request.RelatedPlanIds)
                {
                    var relatedPlan = await _planRepository.GetPlanById(PlanId);
                    if (relatedPlan == null) return Errors.Plan.NotFound;
                    if (!plan.RelatedPlans.Contains(relatedPlan))
                    {
                        plan.RelatedPlans.Add(relatedPlan);
                    }
                }
            }
            await _planRepository.UpdatePlanAsync(plan);
            return plan;
        }
    }
}
