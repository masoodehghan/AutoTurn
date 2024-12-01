namespace AutoTurn.Models.Errors;

using ErrorOr;


public static partial class Errors
{
    public static class Province
    {
        public static Error NotFound => Error.NotFound(code:"province not found");
    }
}