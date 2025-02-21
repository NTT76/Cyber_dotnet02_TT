using System.ComponentModel.DataAnnotations;

public class ContactModel
{
    [Required(ErrorMessage = "Please input FullName")]
    [MinLength(3, ErrorMessage = "FullName must be at least 3 characters")]
    public string FullName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please input Email")]
    [EmailAddress(ErrorMessage = "Email is not valid")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please input Phone")]
    [RegularExpression(@"^\d{10,12}$", ErrorMessage = "Phone number must be 10-12 digits")]

    public string Phone { get; set; } = string.Empty;

    [MinLength(5, ErrorMessage = "Address must be at least 5 characters")]
    public string Address { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please input Address")]
    [MinLength(10, ErrorMessage = "Message must be at least 10 characters")]
    public string Message { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please input Services")]
    public string Services { get; set; } = string.Empty;

    [Required(ErrorMessage = "You must agree before submitting.")]
    public bool Submitting { get; set; }
}