using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.Models
{
    public partial class Demo_DBFirstContext : DbContext
    {
        public Demo_DBFirstContext()
        {
        }

        public Demo_DBFirstContext(DbContextOptions<Demo_DBFirstContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Hdct> Hdcts { get; set; } = null!;
        public virtual DbSet<HoaDon> HoaDons { get; set; } = null!;
        public virtual DbSet<SanPham> SanPhams { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=SHANGHAIK;Database=Demo_DBFirst;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hdct>(entity =>
            {
                entity.ToTable("HDCT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Gia).HasColumnType("money");

                entity.Property(e => e.Idhd).HasColumnName("IDHD");

                entity.Property(e => e.Idsp).HasColumnName("IDSP");

                entity.HasOne(d => d.IdhdNavigation)
                    .WithMany(p => p.Hdcts)
                    .HasForeignKey(d => d.Idhd)
                    .HasConstraintName("FK_HDCT_HD");

                entity.HasOne(d => d.IdspNavigation)
                    .WithMany(p => p.Hdcts)
                    .HasForeignKey(d => d.Idsp)
                    .HasConstraintName("FK_HDCT_SP");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.ToTable("HoaDon");

                entity.Property(e => e.Mota).HasMaxLength(1000);

                entity.Property(e => e.TongTien).HasColumnType("money");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.ToTable("SanPham");

                entity.Property(e => e.Gia).HasColumnType("money");

                entity.Property(e => e.Mota).HasMaxLength(1000);

                entity.Property(e => e.Ten).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
