using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace RRDL.Entities
{
    public partial class demodbContext : DbContext
    {
        public demodbContext()
        {
        }

        public demodbContext(DbContextOptions<demodbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Associate> Associates { get; set; }
        public virtual DbSet<Batch> Batches { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Trainer> Trainers { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Associate>(entity =>
            {
                entity.ToTable("associates");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AssociateLocale)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("associateLocale");

                entity.Property(e => e.AssociateName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("associateName");

                entity.Property(e => e.RevaPoints).HasColumnName("revaPoints");
            });

            modelBuilder.Entity<Batch>(entity =>
            {
                entity.ToTable("batch");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AssociateId).HasColumnName("associateID");

                entity.Property(e => e.TrainerId).HasColumnName("trainerID");

                entity.HasOne(d => d.Associate)
                    .WithMany(p => p.Batches)
                    .HasForeignKey(d => d.AssociateId)
                    .HasConstraintName("FK__batch__associate__3DB3258D");

                entity.HasOne(d => d.Trainer)
                    .WithMany(p => p.Batches)
                    .HasForeignKey(d => d.TrainerId)
                    .HasConstraintName("FK__batch__trainerID__3EA749C6");
            });

            modelBuilder.Entity<Restaurant>(entity =>
            {
                entity.ToTable("restaurants");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("city");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("state");
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.ToTable("reviews");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(240)
                    .HasColumnName("description");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.RestaurantId).HasColumnName("restaurantID");

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.RestaurantId)
                    .HasConstraintName("FK__reviews__restaur__5B78929E");
            });

            modelBuilder.Entity<Trainer>(entity =>
            {
                entity.ToTable("trainers");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CaffeineLevel).HasColumnName("caffeineLevel");

                entity.Property(e => e.Campus)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("campus");

                entity.Property(e => e.TrainerName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("trainerName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
