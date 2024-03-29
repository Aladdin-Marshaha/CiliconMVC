﻿using System.ComponentModel.DataAnnotations;

namespace CiliconMVC.Models;

public class ContactUsModel
{
    [Display(Name = "Full name", Prompt = "Enter your full name", Order = 0)]
    [Required(ErrorMessage = "Full name is required")]
    public string FullName { get; set; } = null!;

    [Display(Name = "Email address", Prompt = "Enter your email address", Order = 1)]
    [Required(ErrorMessage = "Email address is required")]
    [DataType(DataType.EmailAddress)]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$", ErrorMessage = "Invalid email address")]

    public string Email { get; set; } = null!;

    [Display(Name = "Service", Prompt = "Choose the service you are interested in", Order = 2)]
    public string? Service { get; set; }

    [Display(Name = "Message", Prompt = "Enter your message here...", Order = 3)]
    [Required(ErrorMessage = "Message is required")]
    [DataType(DataType.MultilineText)]
    public string Message { get; set; } = null!;
}
