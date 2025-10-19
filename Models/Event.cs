using System.ComponentModel.DataAnnotations;

namespace EventEase.Models;

public class Event
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Event name is required")]
    [StringLength(100, ErrorMessage = "Event name cannot exceed 100 characters")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Event date is required")]
    public DateTime Date { get; set; } = DateTime.Now.AddDays(7);

    [Required(ErrorMessage = "Location is required")]
    [StringLength(200, ErrorMessage = "Location cannot exceed 200 characters")]
    public string Location { get; set; } = string.Empty;

    [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
    public string Description { get; set; } = string.Empty;

    [Range(10, 10000, ErrorMessage = "Capacity must be between 10 and 10000")]
    public int Capacity { get; set; } = 100;

    public int RegisteredCount { get; set; } = 0;

    public List<Registration> Registrations { get; set; } = new();

    public bool IsFull => RegisteredCount >= Capacity;

    public int AvailableSpots => Capacity - RegisteredCount;
}
