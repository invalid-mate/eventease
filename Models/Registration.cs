using System.ComponentModel.DataAnnotations;

namespace EventEase.Models;

public class Registration
{
    public int Id { get; set; }

    public int EventId { get; set; }

    [Required(ErrorMessage = "Full name is required")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters")]
    public string FullName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Phone number is required")]
    [Phone(ErrorMessage = "Please enter a valid phone number")]
    public string Phone { get; set; } = string.Empty;

    [Range(18, 99, ErrorMessage = "Age must be between 18 and 99")]
    public int Age { get; set; }

    public DateTime RegistrationDate { get; set; } = DateTime.Now;

    public bool IsAttended { get; set; } = false;
}
