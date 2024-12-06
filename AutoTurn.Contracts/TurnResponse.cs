namespace AutoTurn.Contracts;

public record TurnResponse(
    int Id,
    DateTime StartTime,
    DateTime EndTime,
    int ForeignId,
    int OfficeId,
    int PlanId
    );