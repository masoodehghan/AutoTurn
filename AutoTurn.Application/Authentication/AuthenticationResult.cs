using Microsoft.AspNetCore.Identity;

namespace AutoTurn.Application.Services.Authentication
{
    public record AuthenticationResult
    {
        public string? Id { get; set; }
        public string? Username { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string? Email { get; set; }
        public string? Token { get; set; }
        public IEnumerable<IdentityError>? Errors { get; set; }
            
    }
}
