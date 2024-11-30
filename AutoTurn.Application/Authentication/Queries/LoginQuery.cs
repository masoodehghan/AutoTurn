using AutoTurn.Application.Services.Authentication;
using ErrorOr;
using MediatR;

namespace AutoTurn.Application.Authentication.Queries;

public record LoginQuery(
   string Username,
   string Password
) : IRequest<ErrorOr<AuthenticationResult>>;