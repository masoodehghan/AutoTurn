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
        private readonly AutoTurnDbContext _context;

        public ForeignController(AutoTurnDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _context.Foreigns.ToListAsync());
        }
    }
}
