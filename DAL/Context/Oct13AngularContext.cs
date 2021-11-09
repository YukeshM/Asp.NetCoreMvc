using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DAL.Entity;

#nullable disable

namespace DAL.Context
{
    public partial class Oct13AngularContext : DbContext
    {
        public Oct13AngularContext()
        {
        }

        public Oct13AngularContext(DbContextOptions<Oct13AngularContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<CandidateRoundInformation> CandidateRoundInformations { get; set; }
        public virtual DbSet<CandidateStatus> CandidateStatuses { get; set; }
        public virtual DbSet<EmployeeInformation> EmployeeInformations { get; set; }
        public virtual DbSet<EmployeeRoleMapping> EmployeeRoleMappings { get; set; }
        public virtual DbSet<HealthCondition> HealthConditions { get; set; }
        public virtual DbSet<Interviewer> Interviewers { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoundInformation> RoundInformations { get; set; }
        public virtual DbSet<SoftSkill> SoftSkills { get; set; }
        public virtual DbSet<Source> Sources { get; set; }
        public virtual DbSet<SourceCandidateMapping> SourceCandidateMappings { get; set; }
        public virtual DbSet<TechnicalSkill> TechnicalSkills { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=TRAINEE-03; Database= Oct13Angular ;User Id=SA; Password = @9543890461My;Trusted_Connection=false;MultipleActiveResultSets=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Candidate>(entity =>
            {
                entity.ToTable("Candidate");

                entity.Property(e => e.Id).ValueGeneratedNever();

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

                entity.Property(e => e.Others)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ReferredBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CandidateRoundInformation>(entity =>
            {
                entity.ToTable("CandidateRoundInformation");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comment).HasColumnType("text");

                entity.Property(e => e.Cons)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Document).IsRequired();

                entity.Property(e => e.InterviewDate).HasColumnType("datetime");

                entity.Property(e => e.InterviewerComment)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Pros)
                    .IsRequired()
                    .HasMaxLength(250);

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

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeInformation>(entity =>
            {
                entity.ToTable("EmployeeInformation");

                entity.Property(e => e.Id).ValueGeneratedNever();

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
            });

            modelBuilder.Entity<EmployeeRoleMapping>(entity =>
            {
                entity.ToTable("EmployeeRoleMapping");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeRoleMappings)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmployeeR__Emplo__5629CD9C");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.EmployeeRoleMappings)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmployeeR__RoleI__571DF1D5");
            });

            modelBuilder.Entity<HealthCondition>(entity =>
            {
                entity.ToTable("HealthCondition");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AnyIllness)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.AnySurgery)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.HealthConditions)
                    .HasForeignKey(d => d.CandidateId)
                    .HasConstraintName("FK__HealthCon__Candi__2C3393D0");
            });

            modelBuilder.Entity<Interviewer>(entity =>
            {
                entity.ToTable("Interviewer");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.InterviewerSign).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<Rating>(entity =>
            {
                entity.ToTable("Rating");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.RatingValue)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Role1)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("Role");
            });

            modelBuilder.Entity<RoundInformation>(entity =>
            {
                entity.ToTable("RoundInformation");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.RoundName)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<SoftSkill>(entity =>
            {
                entity.ToTable("SoftSkill");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.AptitudeNavigation)
                    .WithMany(p => p.SoftSkillAptitudeNavigations)
                    .HasForeignKey(d => d.Aptitude)
                    .HasConstraintName("FK__SoftSkill__Aptit__49C3F6B7");

                entity.HasOne(d => d.AttitudeNavigation)
                    .WithMany(p => p.SoftSkillAttitudeNavigations)
                    .HasForeignKey(d => d.Attitude)
                    .HasConstraintName("FK__SoftSkill__Attit__4D94879B");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.SoftSkills)
                    .HasForeignKey(d => d.CandidateId)
                    .HasConstraintName("FK__SoftSkill__Candi__46E78A0C");

                entity.HasOne(d => d.InitiativeNavigation)
                    .WithMany(p => p.SoftSkillInitiativeNavigations)
                    .HasForeignKey(d => d.Initiative)
                    .HasConstraintName("FK__SoftSkill__Initi__4BAC3F29");

                entity.HasOne(d => d.LeadershipNavigation)
                    .WithMany(p => p.SoftSkillLeadershipNavigations)
                    .HasForeignKey(d => d.Leadership)
                    .HasConstraintName("FK__SoftSkill__Leade__4AB81AF0");

                entity.HasOne(d => d.ListeningSkillNavigation)
                    .WithMany(p => p.SoftSkillListeningSkillNavigations)
                    .HasForeignKey(d => d.ListeningSkill)
                    .HasConstraintName("FK__SoftSkill__Liste__4E88ABD4");

                entity.HasOne(d => d.OtherNavigation)
                    .WithMany(p => p.SoftSkillOtherNavigations)
                    .HasForeignKey(d => d.Other)
                    .HasConstraintName("FK__SoftSkill__Other__4F7CD00D");

                entity.HasOne(d => d.VerbalNavigation)
                    .WithMany(p => p.SoftSkillVerbalNavigations)
                    .HasForeignKey(d => d.Verbal)
                    .HasConstraintName("FK__SoftSkill__Verba__48CFD27E");

                entity.HasOne(d => d.WillingnessToLearnNavigation)
                    .WithMany(p => p.SoftSkillWillingnessToLearnNavigations)
                    .HasForeignKey(d => d.WillingnessToLearn)
                    .HasConstraintName("FK__SoftSkill__Willi__4CA06362");

                entity.HasOne(d => d.WrittenNavigation)
                    .WithMany(p => p.SoftSkillWrittenNavigations)
                    .HasForeignKey(d => d.Written)
                    .HasConstraintName("FK__SoftSkill__Writt__47DBAE45");
            });

            modelBuilder.Entity<Source>(entity =>
            {
                entity.ToTable("Source");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.SourceName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SourceCandidateMapping>(entity =>
            {
                entity.ToTable("SourceCandidateMapping");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.SourceCandidateMappings)
                    .HasForeignKey(d => d.CandidateId)
                    .HasConstraintName("FK__SourceCan__Candi__29572725");

                entity.HasOne(d => d.Source)
                    .WithMany(p => p.SourceCandidateMappings)
                    .HasForeignKey(d => d.SourceId)
                    .HasConstraintName("FK__SourceCan__Sourc__286302EC");
            });

            modelBuilder.Entity<TechnicalSkill>(entity =>
            {
                entity.ToTable("TechnicalSkill");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.AnalyticalSkillNavigation)
                    .WithMany(p => p.TechnicalSkillAnalyticalSkillNavigations)
                    .HasForeignKey(d => d.AnalyticalSkill)
                    .HasConstraintName("FK__Technical__Analy__412EB0B6");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.TechnicalSkills)
                    .HasForeignKey(d => d.CandidateId)
                    .HasConstraintName("FK__Technical__Candi__3C69FB99");

                entity.HasOne(d => d.ConceptNavigation)
                    .WithMany(p => p.TechnicalSkillConceptNavigations)
                    .HasForeignKey(d => d.Concept)
                    .HasConstraintName("FK__Technical__Conce__3D5E1FD2");

                entity.HasOne(d => d.DomainNavigation)
                    .WithMany(p => p.TechnicalSkillDomainNavigations)
                    .HasForeignKey(d => d.Domain)
                    .HasConstraintName("FK__Technical__Domai__3F466844");

                entity.HasOne(d => d.FocussedAndAlertNavigation)
                    .WithMany(p => p.TechnicalSkillFocussedAndAlertNavigations)
                    .HasForeignKey(d => d.FocussedAndAlert)
                    .HasConstraintName("FK__Technical__Focus__4316F928");

                entity.HasOne(d => d.OtherNavigation)
                    .WithMany(p => p.TechnicalSkillOtherNavigations)
                    .HasForeignKey(d => d.Other)
                    .HasConstraintName("FK__Technical__Other__440B1D61");

                entity.HasOne(d => d.ProblemSolvingNavigation)
                    .WithMany(p => p.TechnicalSkillProblemSolvingNavigations)
                    .HasForeignKey(d => d.ProblemSolving)
                    .HasConstraintName("FK__Technical__Probl__4222D4EF");

                entity.HasOne(d => d.SkillSetNavigation)
                    .WithMany(p => p.TechnicalSkillSkillSetNavigations)
                    .HasForeignKey(d => d.SkillSet)
                    .HasConstraintName("FK__Technical__Skill__403A8C7D");

                entity.HasOne(d => d.TechnicalNavigation)
                    .WithMany(p => p.TechnicalSkillTechnicalNavigations)
                    .HasForeignKey(d => d.Technical)
                    .HasConstraintName("FK__Technical__Techn__3E52440B");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
