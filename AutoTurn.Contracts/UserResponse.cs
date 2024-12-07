namespace AutoTurn.Contracts;

public record UserResponse(
    string? FirstName,
    string? LastName,
    string UserName,
    string Email,
    OfficeResponse? Office,
    ProvinceResponse? Province
    );
