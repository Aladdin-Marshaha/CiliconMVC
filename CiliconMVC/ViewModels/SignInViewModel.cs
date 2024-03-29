﻿using System.ComponentModel.DataAnnotations;

namespace CiliconMVC.ViewModels;

public class SignInViewModel
{
    [Display(Name = "Email address", Prompt = "Enter your Email address", Order = 0)]
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "Email address is required")]
    public string Email { get; set; } = null!;

    [Display(Name = "Password", Prompt = "Enter your Password", Order = 1)]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Password is required")]
    public string Password { get; set; } = null!;

    [Display(Name = "Remember Me", Order = 2)]
    public bool RememberMe { get; set; }
}
