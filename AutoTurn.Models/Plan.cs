using AutoTurn.Models.Enums;

namespace AutoTurn.Models;

public class Plan : SoftDelete
{
    public int Id { get; set; }
    public string Name { get; set; }

    public PlanType PlanType { get; set; }
    public int Capacity { get; set; } = 100;
    public bool IsTranferAvailable { get; set; } = true;
    //public bool IsActive { get; set; } = true;

    public int MaxDeleteCount { get; set; }
    public int? DayBetween {  get; set; }

    public ICollection<Plan> RelatedPlans { get; set; } = new List<Plan>();
    public int? RelatedPlanId { get; set; }
    public ICollection<Office> Offices {  get; set; }  = new List<Office>();
    public int DuarationMinute { get; set; } = 15;
    public CodeType CodeType { get; set; }

}