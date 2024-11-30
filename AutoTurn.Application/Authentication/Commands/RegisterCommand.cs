using AutoTurn.Application.Services.Authentication;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace AutoTurn.Application.Authentication.Commands;



public record RegisterCommand(
    string UserName,
    string FirstName,
    string LastName,
    [EmailAddress]string Email,
    string Password) : IRequest<AuthenticationResult>;

