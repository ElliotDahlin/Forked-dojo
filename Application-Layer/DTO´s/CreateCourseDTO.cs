﻿

namespace Application_Layer.DTO_s
{
    public class CreateCourseDTO
    {
        public string CourseId { get; set; } = Guid.NewGuid().ToString();
        public string Title { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public string CategoryOrSubject { get; set; } = string.Empty;
        public string LevelOfDifficulty { get; set; } = string.Empty;
        public string PriceOrPriceModel { get; set; } = string.Empty;
        public string EnrolmentStatus { get; set; } = string.Empty;
        public string Language { get; set; } = string.Empty;
        public TimeSpan Duration { get; set; }
        public double? AverageRating { get; set; }
        public string? ThumbnailOrImageUrl { get; set; }
        public DateTime CreationTimestamp { get; set; }
        public DateTime? LastModificationTimestamp { get; set; }
        public string? ContentUrl { get; set; }
        public string? Tags { get; set; }
        public string? Prerequisites { get; set; }
        public bool CourseIsPublic { get; set; }
        public bool CourseIsCompleted { get; set; }
        public bool IssueCertificate { get; set; }
    }
}
