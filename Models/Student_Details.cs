using System.ComponentModel.DataAnnotations;

namespace ERP_Latest.Models
{
    public class Student_Details
    {
        [Key]
        public int StudentDetailId { get; set; }
        public DateTime StudentDob { get; set; }
        [Required]
        public int StudentId { get; set; }
        public string StudentAlternateEmail { get; set; }
        public long? StudentAlternateMobile { get; set; }
        public string? StudentFatherName { get; set; }
        public string? StudentMotherName { get; set; }
        public string? StudentPermanentAddress { get; set; }
        public string? StudentCurrentAddress { get; set; }
        public long StudentFatherMobile { get; set; }
        public long StudentMotherMobile { get; set; }
        public string? StudentBloodGroup { get; set; }
        public string? StudentPhoto { get; set; }
        public int StudentCetRank { get; set; }
        [Required]
        public int StudentPreviousSchoolDetails { get; set; }
        public string? StudentGender { get; set; }
        [Required]
        public int StudentCategory { get; set; }
        [Required]
        public int StudentCommunity { get; set; }
        [Required]
        public int StudentProgramme { get; set; }
        [Required]
        public int StudentBatch { get; set; }
        public int? StudentShift { get; set; }
        public bool? StudentIsMgmt { get; set; }
        public bool? StudentIsOutDelhi { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? StudentCetType { get; set; }
        [Required]
        public int MentorId { get; set; }
    }
}
