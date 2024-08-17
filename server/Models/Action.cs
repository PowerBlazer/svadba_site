using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace server.Models;

public class Action
{
    [Key]
    [JsonIgnore]
    public long Id { get; set; }
    public required string PhoneNumber { get; set; }
    public required string FullName { get; set; }
    public bool IsVisit { get; set; }
    
    [JsonIgnore]
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}