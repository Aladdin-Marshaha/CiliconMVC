using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models;

public class CourseRegistrationFormViewModel
{
    [Required]
    [Display(Name = "Title")]
    public string Title { get; set; } = null!;

    [Display(Name = "Price")]
    public string? Price { get; set; }

    [Display(Name = "DiscountPrice")]
    public string? DiscountPrice { get; set; }

    [Display(Name = "Hours")]
    public string? Hours { get; set; }

    [Display(Name = "IsBestseller")]
    public bool IsBestseller { get; set; }

    [Display(Name = "LikesInNumbers")]
    public string? LikesInNumbers { get; set; }

    [Display(Name = "LikesInProcent")]
    public string? LikesInProcent { get; set; }

    [Display(Name = "Author")]
    public string? Author { get; set; }
}
