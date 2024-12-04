using AutoTurn.Application.Offices.Commands;
using AutoTurn.Contracts;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MapsterMapper;
using AutoTurn.Application.Interfaces.Repository;
using AutoTurn.Application.Offices.Queries.UpdateOfficeQuery;
using AutoTurn.Application.Offices.Queries.DeleteOfficeQuery;
using AutoTurn.Application.Offices.Queries.OfficePlanSettingQuery;
using AutoTurn.Application.Offices.Queries.ListOfficeQuery;
using AutoTurn.Application.Offices.Queries.AddOfficeUserQuery;
using AutoTurn.Application.Offices.Queries.RemoveOfficeUserQuery;
using AutoTurn.Application.Offices.Queries.GetOfficeQuery;
using AutoTurn.Application.Offices.Queries.RemoveOfficePlanSettingQuery;

namespace AutoTurn.Api.Controllers;


[Route("api/[controller]")]
[Authorize(Roles = "SuperAdmin,Admin")]
public class OfficeController : ApiController
{
    private readonly ISender _mediatr;
    private readonly IMapper _mapper;

    public OfficeController(
        ISender mediatr,
        IMapper mapper,
        IOfficeRepository officeRepository)
    {
        _mediatr = mediatr;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<IActionResult> Post(OfficeCommand request)
    {
        request.AuthUser = User;
        var result = await _mediatr.Send(request);

        return result.Match(
            value => Ok(_mapper.Map<OfficeResponse>(value)),
            errors => Problem(errors)
            );
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery]ListOfficeQuery request)
    {
        request.AuthUser = User;
        var result = await _mediatr.Send(request);

        return result.Match( 
            value =>  Ok(_mapper.Map<List<OfficeResponse>>(value)),
            errors => Problem(errors));
    }

    [HttpGet("{Id}")]
    public async Task<IActionResult> Get(int Id)
    {
        GetOfficeQuery query = new(Id, User);

        var result = await _mediatr.Send(query);
        return result.Match(
            value => Ok(_mapper.Map<OfficeResponse>(value)),
            errors => Problem(errors));
    }


    [HttpPut("{id}")]
    public async Task<IActionResult> Update(UpdateOfficeQuery request, int id)
    {
        request.Id = id;
        request.AuthUser = User;

        var result = await _mediatr.Send(request);

        return result.Match(
            value => Ok(_mapper.Map<OfficeResponse>(value)),
            errors => Problem(errors)
            );
    }

    [HttpDelete("{Id}")]
    public async Task<IActionResult> Delete(DeleteOfficeQuery request, int Id)
    {
        request.Id = Id;
        request.AuthUser = User;
        var result = await _mediatr.Send(request);

        return result.Match(
            value => NoContent(),
            errors => Problem(errors)
            );
    }

    [HttpPatch("/api/office/plans/setting/{id}")]
    public async Task<IActionResult> OfficePlanSetting(OfficePlanSettingQuery request, int id)
    {
        request.Id = id;
        request.AuthUser = User;
        var result = await _mediatr.Send(request);

        return result.Match(
            value => Ok(_mapper.Map<OfficeResponse>(value)),
            errors => Problem(errors));
        
    }

    [HttpDelete("/api/office/plans/setting/{id}")]
    public async Task<IActionResult> RemoveOfficePlanSetting(
        RemoveOfficePlanSettingQuery request,
        int id)
    {
        request.Id = id;
        request.AuthUser = User;
        var result = await _mediatr.Send(request);

        return result.Match(
            value => Ok(_mapper.Map<OfficeResponse>(value)),
            errors => Problem(errors));

    }


    [HttpPatch("{OfficeId}/users")]
    public async Task<IActionResult> OfficeUserPost(AddOfficeUserQuery request, int OfficeId)
    {
        request.Id = OfficeId;
        request.AuthUser = User;

        var result = await _mediatr.Send(request);

        return result.Match(
            value => Ok(_mapper.Map<OfficeResponse>(value)),
            errors => Problem(errors)
            );
    }

    [HttpDelete("{OfficeId}/users")]
    public async Task<IActionResult> OfficeUserDelete(
        RemoveOfficeUserQuery request,
        int OfficeId)
    {
        request.Id = OfficeId;
        request.AuthUser = User;

        var result = await _mediatr.Send(request);

        return result.Match(
            value => Ok(_mapper.Map<OfficeResponse>(value)),
            errors => Problem(errors)
            );
    }
}
