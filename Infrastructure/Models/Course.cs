﻿using Infrastructure.Entities;

namespace Infrastructure.Models;

public class Course
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string? Price { get; set; }
    public string? DiscountPrice { get; set; }
    public string? Hours { get; set; }
    public bool IsBestseller { get; set; }
    public string? LikesInNumbers { get; set; }
    public string? LikesInProcent { get; set; }
    public string? Author { get; set; }

    public static implicit operator Course(CourseEntity courseEntity)
    {
         return new Course
        {
            Id = courseEntity.Id,
            Title = courseEntity.Title,
            Author = courseEntity.Author,
            Price = courseEntity.Price,
            DiscountPrice = courseEntity.DiscountPrice,
            Hours = courseEntity.Hours,
            IsBestseller = courseEntity.IsBestseller,
            LikesInNumbers = courseEntity.LikesInNumbers,
            LikesInProcent = courseEntity.LikesInProcent,
        };
    }
}
