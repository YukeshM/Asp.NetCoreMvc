using ImageUpload.Models;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ImageUpload.Context
{
    public partial class ImageUploadContext : DbContext
    {
        public ImageUploadContext()
        {
        }

        public ImageUploadContext(DbContextOptions<ImageUploadContext> options)
            : base(options)
        {
        }

        public virtual DbSet<UploadImage> UploadImages
        {
            get; set;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<UploadImage>(entity =>
            {
                entity.ToTable("UploadImage");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.ImageName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.ImagePath)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
