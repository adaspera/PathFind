using System.ComponentModel.DataAnnotations;

namespace PathAPI.Models;

public class Location
{
    [Key]
    public int Id { get; set; }
    
    public string? Country { get; set; }
    public string? Name { get; set; }
    public double Lat { get; set; } // Json.NET can convert string to double
    public double Lng { get; set; }
}