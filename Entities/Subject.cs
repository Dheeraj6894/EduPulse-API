using System.ComponentModel.DataAnnotations;

namespace EduPulse_API.Entities
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string SubjectCode { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string SubjectName { get; set; } = string.Empty;

        [Range(1, 10)]
        public int Credits { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;
    }
}
