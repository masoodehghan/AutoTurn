using AutoTurn.Models;
using ErrorOr;
using MediatR;
using System.Security.Claims;

namespace AutoTurn.Application.Turns.Commands;

public record TurnCommand(
    string ForeignCode,
    int PlanId,
    int? OfficeId,
    string ForeignPhoneNumber
    ) : IRequest<ErrorOr<Turn>>
{
    public ClaimsPrincipal? AuthUser { get; set; }
}
