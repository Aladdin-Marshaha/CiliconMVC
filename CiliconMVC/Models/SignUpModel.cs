﻿using System.ComponentModel.DataAnnotations;

namespace CiliconMVC.Models;

public class SignUpModel
{
    [Display (Name = "First name", Prompt = "Enter your first name", Order = 0 )]
    [Required(ErrorMessage = "Invalid first name")]
    public string FirstName { get; set; } = null!;

    [Display(Name = "Last name", Prompt = "Enter your Last name", Order = 1)]
    [Required(ErrorMessage = "Invalid first name")]
    public string LastName { get; set; } = null!;

    [Display(Name = "Email address", Prompt = "Enter your Email address name", Order = 2)]
    [DataType(DataType.EmailAddress)]
    [RegularExpression("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$\r\n",ErrorMessage = "Invalid email address")]
    public string Email { get; set; } = null!;

    [Display(Name = "Password", Prompt = "Enter your Password", Order = 3)]
    [DataType(DataType.Password)]
    [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,}$\r\n", ErrorMessage = "Invalid password")]
    public string Password { get; set; } = null!;

    [Display(Name = "Confirm Password", Prompt = "Confirm your Password", Order = 4)]
    [DataType(DataType.Password)]
    [Compare(nameof(Password) , ErrorMessage = "Password dose not match")]
    public string ConfirmPassword { get; set; } = null!;

    [Display(Name = "I agree to the Terms & Conditions.", Order = 5)]
    [Required(ErrorMessage = "Invalid first name")]
    public bool TermsAndConditions { get; set; } = false;
}