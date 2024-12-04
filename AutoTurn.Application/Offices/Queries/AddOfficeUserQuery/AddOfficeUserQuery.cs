﻿using AutoTurn.Models;
using ErrorOr;
using MediatR;
using System.Security.Claims;
using System.Text.Json.Serialization;

namespace AutoTurn.Application.Offices.Queries.AddOfficeUserQuery;

public record AddOfficeUserQuery(
    List<string> UserIds 
    ) : IRequest<ErrorOr<Office>>
{
    [JsonIgnore]
    public int Id { get; set; } = 0;
    [JsonIgnore]
    public ClaimsPrincipal? AuthUser { get; set; }
}
