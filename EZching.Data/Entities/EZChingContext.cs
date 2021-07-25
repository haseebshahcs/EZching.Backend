using System;
using EZching.Data.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EZching.Data.Entities
{
    public partial class EZChingContext : DbContext
    {
        public EZChingContext()
        {
        }

        public EZChingContext(DbContextOptions<EZChingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SystemConfig> SystemConfigs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(AppConfiguration.SQLConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<SystemConfig>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasPrecision(6);

                entity.Property(e => e.EndDate).HasPrecision(6);

                entity.Property(e => e.KeyName).IsUnicode(false);

                entity.Property(e => e.KeyValue).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
