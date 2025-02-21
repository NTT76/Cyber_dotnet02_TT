using System.ComponentModel.DataAnnotations;

public class RegistrationModel
{
    [Required(ErrorMessage = "Please input FullName")]
    public string FullName { get; set; }

    [Required, EmailAddress]
    public string Email { get; set; }

    [Required, RegularExpression("^\\d{10,12}$", ErrorMessage = "Phone number must be 10-12 digits.")]
    public string Phone { get; set; }

    [Required(ErrorMessage = "Please select a course.")]
    public string Course { get; set; }

    [Required(ErrorMessage = "Please select a study mode.")]
    public string StudyMode { get; set; }

    [Required(ErrorMessage = "Please select a start date.")]
    public DateTime StartDate { get; set; }

    public string Comments { get; set; }

    [Required(ErrorMessage = "You must agree before submitting.")]
    public bool Submitting { get; set; }
}