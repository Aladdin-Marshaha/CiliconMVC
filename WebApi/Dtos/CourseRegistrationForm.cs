using System.ComponentModel.DataAnnotations;

namespace WebApi.Dtos;

public class CourseRegistrationForm
{
    [Required]
    public string Title { get; set; } = null!;
    public string? Price { get; set; }
    public string? DiscountPrice { get; set; }
    public string? Hours { get; set; }
    public bool IsBestseller { get; set; }
    public string? LikesInNumbers { get; set; }
    public string? LikesInProcent { get; set; }
    public string? Author { get; set; }
    public string? CourseImage {  get; set; }
}
