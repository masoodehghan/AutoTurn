namespace AutoTurn.Models.Errors;

using ErrorOr;


public static partial class Errors
{
    public static class Plan
    {
        public static Error NotFound => Error.NotFound(code:"plan not found");
        public static Error WrongData => Error.Validation(code: "enter valid data");
    }
}