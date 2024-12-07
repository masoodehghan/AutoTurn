using AutoTurn.Models;
using ErrorOr;
using MediatR;
using System.Security.Claims;
using System.Text.Json.Serialization;

namespace AutoTurn.Application.Turns.Commands;

public record TurnCommand(
    string ForeignCode,
    int PlanId,
    int? OfficeId,
    string ForeignPhoneNumber
    ) : IRequest<ErrorOr<Turn>>
{
    [JsonIgnore]
    public ClaimsPrincipal? AuthUser { get; set; }
}
