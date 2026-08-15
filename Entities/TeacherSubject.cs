using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduPulse_API.Entities
{
    public class TeacherSubject
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int SubjectId { get; set; } 
        [Required]
        public int TeacherId { get; set; } 
        [Required]
        public int Grade { get; set; }
        public string Section { get; set; } = string.Empty;
        [Required]
        public string AcademicYear { get; set; } = string.Empty;
        [ForeignKey(nameof(SubjectId))]
        public Subject Subject { get; set; } = null!;
        [ForeignKey(nameof(TeacherId))]
        public Teacher Teacher { get; set; } = null!;
    }
}
