﻿using Microsoft.EntityFrameworkCore;

namespace Swimming.Abstractions.Models
{
    public partial class swimmingContext : DbContext
    {
        public swimmingContext()
        {
        }

        public swimmingContext(DbContextOptions<swimmingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Coach> Coaches { get; set; }
        public virtual DbSet<SwimStyle> SwimStyles { get; set; }
        public virtual DbSet<Swimmer> Swimmers { get; set; }
        public virtual DbSet<Training> Trainings { get; set; }
        public virtual DbSet<TrainingsSwimmersSwimStyle> TrainingsSwimmersSwimStyles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=swimming;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Ukrainian_CI_AS");

            modelBuilder.Entity<Coach>(entity =>
            {
                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<SwimStyle>(entity =>
            {
                entity.Property(e => e.StyleName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Swimmer>(entity =>
            {
                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasOne(d => d.Coach)
                    .WithMany(p => p.Swimmers)
                    .HasForeignKey(d => d.CoachId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Swimmers__Coach__4CA06362");
            });

            modelBuilder.Entity<Training>(entity =>
            {
                entity.Property(e => e.TrainingDate).HasColumnType("datetime");

                entity.HasOne(d => d.SwimStyle)
                    .WithMany(p => p.training)
                    .HasForeignKey(d => d.SwimStyleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Trainings__SwimS__534D60F1");

                entity.HasOne(d => d.Swimmer)
                    .WithMany(p => p.training)
                    .HasForeignKey(d => d.SwimmerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Trainings__Swimm__52593CB8");
            });

            modelBuilder.Entity<TrainingsSwimmersSwimStyle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TrainingsSwimmersSwimStyles");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Style)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.TrainingDate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
