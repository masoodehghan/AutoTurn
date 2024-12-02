using AutoTurn.Application.Interfaces.Repository;
using AutoTurn.Application.Plans.Commands;
using AutoTurn.Application.Plans.Queries;
using AutoTurn.Models.Errors;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutoTurn.Api.Controllers
{
    [Route("api/[controller]")]
    [Authorize(Roles = "SuperAdmin")]
    public class PlanController : ApiController
    {
        private readonly ISender _mediatr;
        private readonly IPlanRepository _planRepository;

        public PlanController(ISender mediatr, IPlanRepository planRepository)
        {
            _mediatr = mediatr;
            _planRepository = planRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Post(PlanCommand request)
        {
            var result = await _mediatr.Send(request);

            return result.Match(
                value => CreatedAtAction(nameof(Post), value),
                errors => Problem(errors)
                );
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> Put(UpdatePlanQuery request, int Id)
        {
            request.Id = Id;
            var result = await _mediatr.Send(request);
            
            return result.Match(
                value => Ok(value),
                errors => Problem(errors)
                );

        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _planRepository.GetPlansListAsync());
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get(int Id)
        {
            var plan = await _planRepository.GetPlanById(Id);

            if (plan is null) return NotFound();

            return Ok(plan);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            var plan = await _planRepository.GetPlanById(Id);
            if (plan is null) return NotFound();

            await _planRepository.DeletePlanAsync(plan);
            return NoContent();
        }
    }
}
