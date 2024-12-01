using AutoTurn.Models.Enums;

namespace AutoTurn.Models;


public class PlanSetting
{
    public int PlanId { get; set; }
    public DateTime? StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public int PlanCapacity { get; set; }

}

public class Office
{
    public int Id { get; set; }
    public ICollection<User> Admins { get; set; } = new List<User>();
    public string Name { get; set; }
    public Address Address { get; set; } // Owned Type
    public List<Plan> Plans { get; set; }
    public List<Foreign> Foreigns { get; set; }
    public int ProvinceId { get; set; }
    public Province Province { get; set; }

    public DateTime? PlanEndTime { get; set; }
    public ICollection<Turn> Turns { get; } = new List<Turn>();
    public ICollection<PlanSetting> planSettings { get; set; } = new List<PlanSetting>();


    public bool IsActive { get; set; } = true;

}

