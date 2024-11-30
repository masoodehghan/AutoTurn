namespace AutoTurn.Application.Interfaces;

public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}

