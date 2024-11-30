namespace AutoTurn.Models;

public class Province
{
    public int Id { get; set; }
    public string Name { get; set; }
    public User? Admin { get; set; }
    public string? AdminId { get; set; }

    public ICollection<Office> offices { get; set; } = new List<Office>();

}