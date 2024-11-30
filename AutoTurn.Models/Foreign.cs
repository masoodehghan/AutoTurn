using AutoTurn.Models.Enums;
using System.Numerics;

namespace AutoTurn.Models;

public class Foreign
{
    public int Id { get; set; }
    public long? YektaCode { get; set; }
    public long? SpecificCode { get; set; }  
    public string? PassportCode { get; set; }
    public long? FaragirCode { get; set; }
    public string FirstName { get; set; }   
    public string LastName { get; set; }
    public Address Address { get; set; }
    public string MobileNumber { get; set; }
    public ICollection<Office> Offices { get; set; } = new List<Office>();

}