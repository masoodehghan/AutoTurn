namespace AutoTurn.Contracts;

public record TurnResponse(
    int Id,
    DateTime StartTime,
    DateTime EndTime,
    int ForeignId,
    OfficeResponse Office,
    int PlanId
    );