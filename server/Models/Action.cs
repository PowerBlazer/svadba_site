using System.ComponentModel.DataAnnotations;

namespace server.Models;

public class Action
{
    [Key]
    public long Id { get; set; }
    public required string PhoneNumber { get; set; }
    public required string FullName { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}