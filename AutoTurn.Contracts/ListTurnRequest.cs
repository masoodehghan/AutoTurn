namespace AutoTurn.Contracts;

public record ListTurnRequest(
        int? PlanId,
        string? ForeignCode,
        bool? IsTransfered,
        DateTime? StartTime,
        DateTime? EndTime,
        bool? IsDeleted,
        int? OfficeId,
        PaginationRequest? PageRequest
    );