using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DataAccessLayer.Models;

#nullable disable

namespace DataAccessLayer.Data
{
    public partial class sep23WithDbFirstContext : DbContext
    {
        public sep23WithDbFirstContext()
        {
        }

        public sep23WithDbFirstContext(DbContextOptions<sep23WithDbFirstContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BreakTime> BreakTimes { get; set; }
        public virtual DbSet<EntryTime> EntryTimes { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=TRAINEE-03; Database=sep23WithDbFirst;User Id=SA; Password=@9543890461My;Trusted_Connection=false;MultipleActiveResultSets=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<BreakTime>(entity =>
            {
                entity.HasOne(d => d.Entry)
                    .WithMany(p => p.BreakTimes)
                    .HasForeignKey(d => d.EntryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BreakTime__Entry__29572725");
            });

            modelBuilder.Entity<EntryTime>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.EntryTimes)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EntryTime__UserI__267ABA7A");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
