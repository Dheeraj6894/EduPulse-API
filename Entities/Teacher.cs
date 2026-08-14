using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduPulse_API.Entities
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string EmployeeId { get; set; } = string.Empty;
        [Required]
        [StringLength(10)]
        public string Gender { get; set; } = string.Empty;
        [Required]
        public string Department { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        [Required]
        public string PhoneNumber { get; set; } = string.Empty;
        [Required]
        public DateTime JoiningDate { get; set; }
       
        public int UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; } = null;
    }
}
