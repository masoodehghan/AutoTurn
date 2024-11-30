namespace AutoTurn.Models;

public class Turn
{
    public int Id { get; set; }
    public Foreign Foreign { get; set; }
    public int ForeignId { get; set; }

    public DateTime? StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public Plan Plan { get; set; }
    public int PlanId { get; set; }
    public Office Office { get; set; }
    public int OfficeId { get; set; }
    public bool IsDeleted { get; set; } = false;
    public int DeletedCount { get; set; } = 0;

    public int? TranferedOfficeId { get; set; }


}