using AutoTurn.Application.Turns.Commands;
using AutoTurn.Contracts;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutoTurn.Api.Controllers;


[Route("api/[controller]")]
public class TurnController : ApiController
{
    private readonly ISender _mediatr;
    private readonly IMapper _mapper;
    public TurnController(ISender mediatr, IMapper mapper)
    {
        _mediatr = mediatr;
        _mapper = mapper;
    }

    [Authorize]
    [HttpPost]
    public async Task<IActionResult> Post(TurnCommand request)
    {
        request.AuthUser = User;
        var result = await _mediatr.Send(request);

        return result.Match(
            value => CreatedAtAction("", _mapper.Map<TurnResponse>(value)),
            errors => Problem(errors)
            );
    }
}
