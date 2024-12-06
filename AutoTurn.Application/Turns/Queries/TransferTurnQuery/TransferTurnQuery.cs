using AutoTurn.Models;
using ErrorOr;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AutoTurn.Application.Turns.Queries.TransferTurnQuery;

public record TransferTurnQuery(
    int TurnId,
    int OfficeId
    ) : IRequest<ErrorOr<Turn>>
{
    public ClaimsPrincipal? AuthUser { get; set; }
}