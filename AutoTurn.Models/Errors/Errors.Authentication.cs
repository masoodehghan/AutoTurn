namespace AutoTurn.Models.Errors;

using ErrorOr;


public static partial class Errors
{
    public static class Authentication
    {
        public static Error InvalidCredentials => Error.Validation(code: "Auth.InvalidCredit",
                                                             description: "invalid credential");

        public static Error NotFound => Error.NotFound(code: "user not found");

        public static Error DuplicateEmail =>
                            Error.Validation(code: "Auth.DuplicateEmail",
                            description: "Email already exist");

        public static Error Forbidden =>
                            Error.Forbidden("Auth.Forbidden",
                            description: "You are not permitted to do this action");
    }
}