﻿using AutoTurn.Application.Turns.Commands;
using AutoTurn.Application.Turns.Queries.DeleteTurnQuery;
using AutoTurn.Application.Turns.Queries.ListTurnsQuery;
using AutoTurn.Application.Turns.Queries.TransferTurnQuery;
using AutoTurn.Contracts;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Text.Json.Serialization;

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

    [Authorize]
    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] ListTurnRequest request)
    {
        var query = _mapper.Map<ListTurnsQuery>(request);
        query.AuthUser = User;
        var result = await _mediatr.Send(query);

        return result.Match(
            value => Ok(_mapper.Map<List<TurnResponse>>(value)),
            errors => Problem(errors)
            );
    }


    [Authorize]
    [HttpDelete("{Id}")]
    public async Task<IActionResult> Delete(DeleteTurnQuery request, int Id)
    {
        request.AuthUser = User;
        request.Id = Id;
        var result = await _mediatr.Send(request);

        return result.Match(
            _ => NoContent(),
            errors => Problem(errors)
            );
    }
}
