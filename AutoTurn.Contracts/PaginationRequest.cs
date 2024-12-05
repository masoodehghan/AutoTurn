namespace AutoTurn.Contracts;


public record PaginationRequest(
    int? PageSize = 10,
    int? PageIndex = 0
    );