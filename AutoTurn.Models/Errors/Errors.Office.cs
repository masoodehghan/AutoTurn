namespace AutoTurn.Models.Errors;

using ErrorOr;


public static partial class Errors
{
    public static class Office
    {
        public static Error NotFound => Error.NotFound(code:"office not found");
        public static Error WrongData => Error.Validation(code: "enter valid data");
    }
}