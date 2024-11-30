using FluentValidation;

namespace AutoTurn.Application.Authentication.Commands;


public class RegisterValidator : AbstractValidator<RegisterCommand>
{
    public RegisterValidator()
    {
        RuleFor(x => x.Email).NotEmpty().EmailAddress();
        RuleFor(f => f.UserName).NotEmpty();
    }
}

