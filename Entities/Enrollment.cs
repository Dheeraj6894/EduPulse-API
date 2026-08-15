using System.ComponentModel.DataAnnotations.Schema;

namespace EduPulse_API.Entities
{
    public class Enrollment
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public int Grade { get; set; }
        public string Section { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        [ForeignKey(nameof(StudentId))]
        public Student Student { get; set; } = null!;
        [ForeignKey(nameof(CourseId))]
        public Course Course { get; set; } = null!;
    }
}
