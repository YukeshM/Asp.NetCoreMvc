using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DemoMVC.Models
{
    public partial class StudentDetail : DbContext
    {
        public StudentDetail()
            : base("name=StudentDetail1")
        {
        }

        public virtual DbSet<Student> Students
        {
            get; set;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(e => e.StudentName)
                .IsUnicode(false);
        }
    }
}
