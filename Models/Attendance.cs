using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_Latest.Models
{
    public class Attendance
    {
        [Key, Column(Order = 1)]
        public int StudentId { get; set; }
        [Key, Column(Order = 2)]
        public int CourseId { get; set; }
        [Key, Column(Order = 3)]
        public DateTime Date { get; set; }
        public bool IsPresent { get; set; }

        [ForeignKey("StudentId")]
        public virtual Student_Basics Student_Basics { get; set; }

        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }
    }
}
