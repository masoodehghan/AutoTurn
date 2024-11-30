namespace AutoTurn.Application.Interfaces;

public interface IJwtTokenGenerator
{
    string GenerateToken(
        string userId,
        string userName,
        string lastName,
        string Role = "Normal");
}
