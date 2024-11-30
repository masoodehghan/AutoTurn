using AutoTurn.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutoTurn.Api.Controllers;


public class ProvinceController : ApiController
{

    private readonly AutoTurnDbContext _context;

    public ProvinceController(AutoTurnDbContext context)
    {
        _context = context;
    }

    [HttpPatch("provinces/{Id:int}/{userId}")]
    [Authorize(Roles = "SuperAdmin")]
    public async Task<IActionResult> Put(int Id, string userId)
    {

        var province = _context.Provinces.SingleOrDefault(p => p.Id == Id);

        if (province == null)
        {
            return NotFound();
        }
        province.AdminId = userId;

        var user = _context.Users.SingleOrDefault(s => s.Id == userId);

        if (user == null)
        {
            return NotFound("User Not Found");
        }

        if(!user.IsAdmin)
        {
            return BadRequest("user have to be an admin");
        }
        
        await _context.SaveChangesAsync();

        return Ok(province);
    }
}