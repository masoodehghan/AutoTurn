using AutoTurn.Models;
using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AutoTurn.Application.Offices.Queries.ListOfficeQuery;
public record ListOfficeQuery(
    int? ProvinceId,
    string? ProvinceName) : IRequest<ErrorOr<List<Office>>>
{
    [BindNever]
    public ClaimsPrincipal? AuthUser { get; set; }
}

