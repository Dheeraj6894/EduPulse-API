using System.ComponentModel.DataAnnotations;

namespace EduPulse_API.Entities
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CourseCode { get; set; } = string.Empty;
        [Required]
        public string CourseName { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]
        [Range(1, 6)]
        public int DurationInYears { get; set; }
    }
}
