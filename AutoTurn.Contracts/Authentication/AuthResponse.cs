using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTurn.Contracts.Authentication
{
    public record AuthResponse(
        string FirstName,
        string LastName,
        string Email,
        string Token
        );
}
