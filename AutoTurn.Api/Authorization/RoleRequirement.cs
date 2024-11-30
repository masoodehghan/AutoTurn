using Microsoft.AspNetCore.Authorization;

namespace AutoTurn.Api.Authorization;

public class RoleRequirement : IAuthorizationRequirement
{
    public string Role { get; }

    public RoleRequirement(string role)
    {
        Role = role;
    }
}