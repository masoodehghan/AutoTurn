using AutoTurn.Models;
using ErrorOr;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AutoTurn.Application.Offices.Queries.GetOfficeQuery;

public record GetOfficeQuery : IRequest<ErrorOr<Office>>
{
    [JsonIgnore]
    public int Id { get; set; }
    [JsonIgnore]
    public ClaimsPrincipal AuthUser { get; set; }

    public GetOfficeQuery(int id, ClaimsPrincipal authUser)
    {
        Id = id;
        AuthUser = authUser;
    }
}