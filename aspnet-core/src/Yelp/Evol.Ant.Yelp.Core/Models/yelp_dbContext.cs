using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Evol.Ant.Yelp.Models
{
    public partial class yelp_dbContext : DbContext
    {
        public yelp_dbContext()
        {
        }

        public yelp_dbContext(DbContextOptions<yelp_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Business> Business { get; set; }
        public virtual DbSet<Photo> Photo { get; set; }
        public virtual DbSet<Review> Review { get; set; }
        public virtual DbSet<User> User { get; set; }

        // Unable to generate entity type for table 'attribute'. Please see the warning messages.
        // Unable to generate entity type for table 'category'. Please see the warning messages.
        // Unable to generate entity type for table 'checkin'. Please see the warning messages.
        // Unable to generate entity type for table 'elite_years'. Please see the warning messages.
        // Unable to generate entity type for table 'friend'. Please see the warning messages.
        // Unable to generate entity type for table 'hours'. Please see the warning messages.
        // Unable to generate entity type for table 'tip'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=127.0.0.1;User ID=root;Password=123456;database=yelp_db;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Business>(entity =>
            {
                entity.ToTable("business");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(22)");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.IsOpen)
                    .HasColumnName("is_open")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Neighborhood)
                    .HasColumnName("neighborhood")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.PostalCode)
                    .HasColumnName("postal_code")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ReviewCount)
                    .HasColumnName("review_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Stars).HasColumnName("stars");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<Photo>(entity =>
            {
                entity.ToTable("photo");

                entity.HasIndex(e => e.BusinessId)
                    .HasName("fk_photo_business1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(22)");

                entity.Property(e => e.BusinessId)
                    .IsRequired()
                    .HasColumnName("business_id")
                    .HasColumnType("varchar(22)");

                entity.Property(e => e.Caption)
                    .HasColumnName("caption")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Label)
                    .HasColumnName("label")
                    .HasColumnType("varchar(255)");

                entity.HasOne(d => d.Business)
                    .WithMany(p => p.Photo)
                    .HasForeignKey(d => d.BusinessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_photo_business1");
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.ToTable("review");

                entity.HasIndex(e => e.BusinessId)
                    .HasName("fk_reviews_business1_idx");

                entity.HasIndex(e => e.UserId)
                    .HasName("fk_reviews_user1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(22)");

                entity.Property(e => e.BusinessId)
                    .IsRequired()
                    .HasColumnName("business_id")
                    .HasColumnType("varchar(22)");

                entity.Property(e => e.Cool)
                    .HasColumnName("cool")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Funny)
                    .HasColumnName("funny")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Stars)
                    .HasColumnName("stars")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasColumnType("text");

                entity.Property(e => e.Useful)
                    .HasColumnName("useful")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("user_id")
                    .HasColumnType("varchar(22)");

                entity.HasOne(d => d.Business)
                    .WithMany(p => p.Review)
                    .HasForeignKey(d => d.BusinessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_reviews_business1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Review)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_reviews_user1");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(22)");

                entity.Property(e => e.AverageStars).HasColumnName("average_stars");

                entity.Property(e => e.ComplimentCool)
                    .HasColumnName("compliment_cool")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ComplimentCute)
                    .HasColumnName("compliment_cute")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ComplimentFunny)
                    .HasColumnName("compliment_funny")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ComplimentHot)
                    .HasColumnName("compliment_hot")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ComplimentList)
                    .HasColumnName("compliment_list")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ComplimentMore)
                    .HasColumnName("compliment_more")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ComplimentNote)
                    .HasColumnName("compliment_note")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ComplimentPhotos)
                    .HasColumnName("compliment_photos")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ComplimentPlain)
                    .HasColumnName("compliment_plain")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ComplimentProfile)
                    .HasColumnName("compliment_profile")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ComplimentWriter)
                    .HasColumnName("compliment_writer")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cool)
                    .HasColumnName("cool")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fans)
                    .HasColumnName("fans")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Funny)
                    .HasColumnName("funny")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ReviewCount)
                    .HasColumnName("review_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Useful)
                    .HasColumnName("useful")
                    .HasColumnType("int(11)");

                entity.Property(e => e.YelpingSince)
                    .HasColumnName("yelping_since")
                    .HasColumnType("datetime");
            });
        }
    }
}
