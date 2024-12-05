using AutoTurn.Models.Enums;
using System.Runtime.CompilerServices;

namespace AutoTurn.Models;


public class PlanSetting
{
    public int PlanId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int PlanCapacity { get; set; }
    public int PlanForeignCount { get; set; } = 0;
}

public class Office : SoftDelete
{

    public int Id { get; set; }
    public ICollection<User> Admins { get; set; } = new List<User>();
    public string Name { get; set; }

    public Address Address { get; set; } 
    public List<Plan> Plans { get; set; } = new();
    public List<Foreign> Foreigns { get; set; } = new();
    public int ProvinceId { get; set; }
    public Province Province { get; set; }

    public ICollection<Turn> Turns { get; } = new List<Turn>();
    public ICollection<PlanSetting> PlanSettings { get; set; } = new HashSet<PlanSetting>();

}

