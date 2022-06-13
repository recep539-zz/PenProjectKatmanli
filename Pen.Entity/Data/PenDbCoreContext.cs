using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Pen.Entity.Data
{
    public partial class PenDbCoreContext : DbContext
    {
        public PenDbCoreContext()
        {
        }

        public PenDbCoreContext(DbContextOptions<PenDbCoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BodyMaterial> BodyMaterials { get; set; } = null!;
        public virtual DbSet<Covertype> Covertypes { get; set; } = null!;
        public virtual DbSet<FillingMechanism> FillingMechanisms { get; set; } = null!;
        public virtual DbSet<FountainPen> FountainPens { get; set; } = null!;
        public virtual DbSet<PenInformation> PenInformations { get; set; } = null!;
        public virtual DbSet<PenStatus> PenStatuses { get; set; } = null!;
        public virtual DbSet<TipType> TipTypes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-F6HHAUL\\SQLEXPRESS;Database=PenDbCore;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BodyMaterial>(entity =>
            {
                entity.Property(e => e.Bodymaterial1).HasColumnName("Bodymaterial");
            });

            modelBuilder.Entity<Covertype>(entity =>
            {
                entity.ToTable("Covertype");
            });

            modelBuilder.Entity<FillingMechanism>(entity =>
            {
                entity.ToTable("FillingMechanism");
            });

            modelBuilder.Entity<FountainPen>(entity =>
            {
                entity.ToTable("FountainPen");
            });

            modelBuilder.Entity<PenInformation>(entity =>
            {
                entity.ToTable("PenInformation");

                entity.HasIndex(e => e.BodyMaterialId, "IX_PenInformation_BodyMaterialId");

                entity.HasIndex(e => e.CovertypeId, "IX_PenInformation_CovertypeId");

                entity.HasIndex(e => e.FillingMechanismId, "IX_PenInformation_FillingMechanismId");

                entity.HasIndex(e => e.PenStatusId, "IX_PenInformation_PenStatusId");

                entity.HasIndex(e => e.TipTypeId, "IX_PenInformation_TipTypeId");

                entity.HasOne(d => d.BodyMaterial)
                    .WithMany(p => p.PenInformations)
                    .HasForeignKey(d => d.BodyMaterialId);

                entity.HasOne(d => d.Covertype)
                    .WithMany(p => p.PenInformations)
                    .HasForeignKey(d => d.CovertypeId);

                entity.HasOne(d => d.FillingMechanism)
                    .WithMany(p => p.PenInformations)
                    .HasForeignKey(d => d.FillingMechanismId);

                entity.HasOne(d => d.PenStatus)
                    .WithMany(p => p.PenInformations)
                    .HasForeignKey(d => d.PenStatusId);

                entity.HasOne(d => d.TipType)
                    .WithMany(p => p.PenInformations)
                    .HasForeignKey(d => d.TipTypeId);
            });

            modelBuilder.Entity<PenStatus>(entity =>
            {
                entity.ToTable("PenStatus");

                entity.Property(e => e.Penstatus1).HasColumnName("Penstatus");
            });

            modelBuilder.Entity<TipType>(entity =>
            {
                entity.Property(e => e.TipType1).HasColumnName("TipType");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
