using Microsoft.AspNetCore.Mvc;
using MediatR;
using AutoTurn.Application.Authentication.Commands;
using AutoTurn.Application.Authentication.Queries;
using AutoTurn.Api.Controllers;
using Microsoft.AspNetCore.Authorization;

namespace AutoTurn.Contracts.Controllers;

[Route("api/auth")]
public class AuthenticationController : ApiController
{

    private readonly ISender _mediatr;

    public AuthenticationController(ISender mediatr)
    {
        _mediatr = mediatr;
    }

    
    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterCommand request)
    {
        var result = await _mediatr.Send(request);
        if(result.Errors is not null)
        {
            return BadRequest(result);
        }
        return Ok(result);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginQuery request)
    {
        
        var result = await _mediatr.Send(request);

        return result.Match(
            value => Ok(value),
            errors => Problem(errors)
            );
    }


    [Authorize("SuperAdmin")]
    [HttpPut("update")]    
    public async Task<IActionResult> UpdateUser(UpdateUserQuery request)
    {
        request.AuthUser = User;
        var result = await _mediatr.Send(request);

        return result.Match(
            value => Ok(value),
            errors => Problem(errors)
            );
    }
}

