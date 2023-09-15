using System.ComponentModel.DataAnnotations;

namespace ERP_Latest.Models
{
    public class Student_Basics
    {
        [Key]
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        [Required]
        public int CetType { get; set; }
        public string? CetNo { get; set; }
        public string? EnrollNo { get; set; }
        public long? StudentMobile { get; set; }
        public string? StudentEmail { get; set; }
        public string? StudentToken { get; set; }
        public byte IsVerified { get; set; }
        public byte IsWithdraw { get; set; }
        public DateTime? WithdrawDate { get; set; }
        public string? WithdrawReason { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
