using System.ComponentModel.DataAnnotations;

namespace ERP_Latest.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        public int SemesterId { get; set; } 
        public string? CourseCode { get; set; }
        public string? CourseName { get; set; }
        public string? CourseDescription { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
