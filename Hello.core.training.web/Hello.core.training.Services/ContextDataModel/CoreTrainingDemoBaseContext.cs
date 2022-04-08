using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Hello.core.training.Services.ContextDataModel
{
    public partial class CoreTrainingDemoBaseContext : DbContext
    {
        public CoreTrainingDemoBaseContext()
        {
        }

        public CoreTrainingDemoBaseContext(DbContextOptions<CoreTrainingDemoBaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CoreTable> CoreTables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=ESLAPIT2\\SQL2019;Database=CoreTrainingDemoBase;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoreTable>(entity =>
            {
                entity.HasKey(e => e.ProjId)
                    .HasName("PK__CoreTabl__16212A1C24DA8499");

                entity.ToTable("CoreTable");

                entity.Property(e => e.AssignedBy)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProjAim)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("projAim");

                entity.Property(e => e.ProjEndDate).HasColumnType("date");

                entity.Property(e => e.ProjName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProjStartDate).HasColumnType("date");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
