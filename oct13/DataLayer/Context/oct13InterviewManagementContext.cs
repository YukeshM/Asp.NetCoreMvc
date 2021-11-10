using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DataLayer.Entity;

#nullable disable

namespace DataLayer.Context
{
    public partial class oct13InterviewManagementContext : DbContext
    {
        public oct13InterviewManagementContext()
        {
        }

        public oct13InterviewManagementContext(DbContextOptions<oct13InterviewManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<CandidateRoundInformation> CandidateRoundInformations { get; set; }
        public virtual DbSet<CandidateStatus> CandidateStatuses { get; set; }
        public virtual DbSet<EmployeeInformation> EmployeeInformations { get; set; }
        public virtual DbSet<HealthCondition> HealthConditions { get; set; }
        public virtual DbSet<Interviewer> Interviewers { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<Resume> Resumes { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoundInformation> RoundInformations { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<SkillRating> SkillRatings { get; set; }
        public virtual DbSet<Source> Sources { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server = TRAINEE-03; Database = oct13InterviewManagement; User Id = sa; Password = @9543890461My; MultipleActiveResultSets = True; Trusted_Connection = False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Candidate>(entity =>
            {
                entity.ToTable("Candidate");

                entity.Property(e => e.LastDesignation)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastEmployer)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.NoticePeriod)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.ReferredBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Source)
                    .WithMany(p => p.Candidates)
                    .HasForeignKey(d => d.SourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Candidate__Sourc__267ABA7A");
            });

            modelBuilder.Entity<CandidateRoundInformation>(entity =>
            {
                entity.ToTable("CandidateRoundInformation");

                entity.Property(e => e.InterviewDate).HasColumnType("datetime");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.CandidateRoundInformations)
                    .HasForeignKey(d => d.CandidateId)
                    .HasConstraintName("FK__Candidate__Candi__35BCFE0A");

                entity.HasOne(d => d.Interviewer)
                    .WithMany(p => p.CandidateRoundInformations)
                    .HasForeignKey(d => d.InterviewerId)
                    .HasConstraintName("FK__Candidate__Inter__36B12243");

                entity.HasOne(d => d.Round)
                    .WithMany(p => p.CandidateRoundInformations)
                    .HasForeignKey(d => d.RoundId)
                    .HasConstraintName("FK__Candidate__Round__34C8D9D1");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.CandidateRoundInformations)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK__Candidate__Statu__37A5467C");
            });

            modelBuilder.Entity<CandidateStatus>(entity =>
            {
                entity.ToTable("CandidateStatus");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeInformation>(entity =>
            {
                entity.ToTable("EmployeeInformation");

                entity.Property(e => e.ConfirmPassword)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.EmployeeInformations)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmployeeI__RoleI__48CFD27E");
            });

            modelBuilder.Entity<HealthCondition>(entity =>
            {
                entity.ToTable("HealthCondition");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.HealthConditions)
                    .HasForeignKey(d => d.CandidateId)
                    .HasConstraintName("FK__HealthCon__Candi__2C3393D0");
            });

            modelBuilder.Entity<Interviewer>(entity =>
            {
                entity.ToTable("Interviewer");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<Rating>(entity =>
            {
                entity.ToTable("Rating");

                entity.Property(e => e.RatingValue)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<Resume>(entity =>
            {
                entity.ToTable("Resume");

                entity.Property(e => e.File).IsRequired();

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.Resumes)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Resume__Candidat__29572725");
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.ToTable("Review");

                entity.Property(e => e.Comment)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Cons)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Pros)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.CandidateRoundInformation)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.CandidateRoundInformationId)
                    .HasConstraintName("FK__Review__Candidat__3A81B327");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.Role1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Role");
            });

            modelBuilder.Entity<RoundInformation>(entity =>
            {
                entity.ToTable("RoundInformation");

                entity.Property(e => e.RoundName)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.ToTable("Skill");

                entity.Property(e => e.SkillName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK__Skill__ParentId__3F466844");
            });

            modelBuilder.Entity<SkillRating>(entity =>
            {
                entity.ToTable("SkillRating");

                entity.HasOne(d => d.Rating)
                    .WithMany(p => p.SkillRatings)
                    .HasForeignKey(d => d.RatingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SkillRati__Ratin__440B1D61");

                entity.HasOne(d => d.Review)
                    .WithMany(p => p.SkillRatings)
                    .HasForeignKey(d => d.ReviewId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SkillRati__Revie__4222D4EF");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.SkillRatings)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SkillRati__Skill__4316F928");
            });

            modelBuilder.Entity<Source>(entity =>
            {
                entity.ToTable("Source");

                entity.Property(e => e.SourceName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
