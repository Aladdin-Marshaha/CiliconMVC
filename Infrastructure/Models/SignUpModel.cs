using System.ComponentModel.DataAnnotations;
using Infrastructure.Helpers;

namespace Infrastructure.Models;

public class SignUpModel
{
    [Display(Name = "First name", Prompt = "Enter your first name", Order = 0)]
    [Required(ErrorMessage = "Invalid first name")]
    [DataType(DataType.Text)]
    public string FirstName { get; set; } = null!;

    [Display(Name = "Last name", Prompt = "Enter your Last name", Order = 1)]
    [Required(ErrorMessage = "Invalid first name")]
    [DataType(DataType.Text)]
    public string LastName { get; set; } = null!;

    [Display(Name = "Email address", Prompt = "Enter your Email address", Order = 2)]
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "Email address is required")]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$", ErrorMessage = "Invalid email address")]
    public string Email { get; set; } = null!;

    [Display(Name = "Password", Prompt = "Enter your Password", Order = 3)]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Invalid password")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$", ErrorMessage = "Invalid password")]
    public string Password { get; set; } = null!;

    [Display(Name = "Confirm Password", Prompt = "Confirm your Password", Order = 4)]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Password must be confirmed")]
    [Compare(nameof(Password), ErrorMessage = "Password dose not match")]
    public string ConfirmPassword { get; set; } = null!;

    [Display(Name = "I agree to the Terms & Conditions.", Order = 5)]
    [Required(ErrorMessage = "You must accept the terms and conditions")]
    [CheckBoxRequired(ErrorMessage = "You must accept the terms  and conditions to proceed.")]
    public bool TermsAndConditions { get; set; } = false;
}
