using AutoTurn.Application.Interfaces.Repository;
using AutoTurn.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoTurn.Api.Controllers
{
    [Authorize(Roles = "SuperAdmin")]
    [Route("api/[controller]")]
    public class ForeignController : ApiController
    {
        private readonly IForeignRepository _foreignRepository;

        public ForeignController(IForeignRepository foreignRepository)
        {
            _foreignRepository = foreignRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get(
            [FromQuery] int? PageSize ,
            [FromQuery] int? PageIndex
            )
        {
            
            return Ok(await _foreignRepository.GetAllAsync(PageIndex ??0, PageSize??10));
        }
    }
}
