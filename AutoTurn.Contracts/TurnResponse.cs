namespace AutoTurn.Contracts;

public record TurnResponse(
    DateTime StartTime,
    DateTime EndTime,
    int ForeignId,
    int OfficeId,
    int PlanId
    );