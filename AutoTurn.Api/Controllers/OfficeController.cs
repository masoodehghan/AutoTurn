using AutoTurn.Application.Offices.Commands;
using AutoTurn.Contracts;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MapsterMapper;
using AutoTurn.Application.Interfaces.Repository;
using AutoTurn.Application.Offices.Queries.UpdateOfficeQuery;
using AutoTurn.Application.Offices.Queries.DeleteOfficeQuery;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AutoTurn.Api.Controllers;


[Route("api/[controller]")]
public class OfficeController : ApiController
{
    private readonly ISender _mediatr;
    private readonly IMapper _mapper;
    private readonly IOfficeRepository _officeRepository;

    public OfficeController(
        ISender mediatr,
        IMapper mapper,
        IOfficeRepository officeRepository)
    {
        _mediatr = mediatr;
        _mapper = mapper;
        _officeRepository = officeRepository;
    }

    [HttpPost]
    [Authorize(Roles = "SuperAdmin, Admin")]
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
    public async Task<IActionResult> Get()
    {
        var offices = await _officeRepository.GetAllOfficeAsync();
        return Ok(_mapper.Map<List<OfficeResponse>>(offices));
    }


    [HttpPut("{id}")]
    [Authorize(Roles = "Admin,SuperAdmin")]
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
    [Authorize(Roles = "SuperAdmin,Admin")]
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
}
