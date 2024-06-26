﻿using Infrastructure.Dtos;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class SubscriberEntity
{
    public int Id { get; set; }

    [Required]
    public string Email { get; set; } = null!;
    public bool IsSubscribed { get; set; } = false;
    public bool DailyNewsletter { get; set; }
    public bool AdvertisingUpdates { get; set; }
    public bool WeekinReview { get; set; }
    public bool EventUpdates { get; set; }
    public bool StartupsWeekly { get; set; }
    public bool Podcasts { get; set; }

    public static implicit operator SubscriberEntity(Subscriber dto)
    {
        return new SubscriberEntity
        {
            Email = dto.Email,
            AdvertisingUpdates = dto.AdvertisingUpdates,
            WeekinReview = dto.WeekinReview,
            EventUpdates = dto.EventUpdates,
            DailyNewsletter = dto.DailyNewsletter,
            IsSubscribed = dto.IsSubscribed,
            Podcasts = dto.Podcasts,
            StartupsWeekly = dto.StartupsWeekly,
        };
    }
}
