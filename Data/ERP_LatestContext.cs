using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ERP_Latest.Models;

namespace ERP_Latest.Data
{
    public class ERP_LatestContext : DbContext
    {
        public ERP_LatestContext (DbContextOptions<ERP_LatestContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendance>()
                .HasKey(o => new { o.StudentId, o.CourseId, o.Date });
        }

        public DbSet<ERP_Latest.Models.Student_Details> Student_Details { get; set; } = default!;

        public DbSet<ERP_Latest.Models.Course>? Course { get; set; }

        public DbSet<ERP_Latest.Models.Student_Basics>? Student_Basics { get; set; }

        public DbSet<ERP_Latest.Models.Attendance>? Attendance { get; set; }
    }
}
