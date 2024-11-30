using AutoTurn.Models.Enums;

namespace AutoTurn.Models;

public class Office
{
    public int Id { get; set; }
    public string? AdminId { get; set; }
    public User? Admin { get; set; }
    public string Name { get; set; }
    public Address Address { get; set; } // Owned Type
    public List<Plan> Plans { get; set; }
    public List<Foreign> Foreigns { get; set; }
    public int ProvinceId { get; set; }
    public Province Province { get; set; }

    public DateTime? PlanStartTime { get; set; }
    public DateTime? PlanEndTime { get; set; }
    public int PlanCapacity { get; set; }
    public ICollection<Turn> Turns { get; } = new List<Turn>();

    public bool IsActive { get; set; } = true;

}

