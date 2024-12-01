using Microsoft.AspNetCore.Identity;

namespace AutoTurn.Models;

public class User : IdentityUser
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public bool IsAdmin { get; set; } = false;
    public bool IsSuperAdmin { get; set;  } = false;
    public Province? Province {  get; set; }
    public Office? Office { get; set; }
    public int? OfficeId { get; set; }

}