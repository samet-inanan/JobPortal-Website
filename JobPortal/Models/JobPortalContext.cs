using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace JobPortal.Models
{
    public partial class JobPortalContext : DbContext
    {
        public JobPortalContext()
        {
        }

        public JobPortalContext(DbContextOptions<JobPortalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Beceri> Beceri { get; set; }
        public virtual DbSet<Diller> Diller { get; set; }
        public virtual DbSet<Egitim> Egitim { get; set; }
        public virtual DbSet<HesapDurumu> HesapDurumu { get; set; }
        public virtual DbSet<IsBasvuru> IsBasvuru { get; set; }
        public virtual DbSet<IsBasvuruDurumu> IsBasvuruDurumu { get; set; }
        public virtual DbSet<IsDeneyim> IsDeneyim { get; set; }
        public virtual DbSet<IsDurumu> IsDurumu { get; set; }
        public virtual DbSet<IsGereklilikler> IsGereklilikler { get; set; }
        public virtual DbSet<IsGerekliliklerDetay> IsGerekliliklerDetay { get; set; }
        public virtual DbSet<IsIlani> IsIlani { get; set; }
        public virtual DbSet<IsKategori> IsKategori { get; set; }
        public virtual DbSet<IsZamani> IsZamani { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<KullaniciTipi> KullaniciTipi { get; set; }
        public virtual DbSet<Personel> Personel { get; set; }
        public virtual DbSet<Sertifika> Sertifika { get; set; }
        public virtual DbSet<Sirket> Sirket { get; set; }
        public virtual DbSet<Ulke> Ulke { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=SAMET-INANAN\\MSSQLSERVER02;Database=JobPortal; Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Beceri>(entity =>
            {
                entity.HasOne(d => d.Personel)
                    .WithMany(p => p.Beceri)
                    .HasForeignKey(d => d.PersonelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Beceri_Personel");
            });

            modelBuilder.Entity<Diller>(entity =>
            {
                entity.HasOne(d => d.Personel)
                    .WithMany(p => p.Diller)
                    .HasForeignKey(d => d.PersonelId)
                    .HasConstraintName("FK_Diller_Personel");
            });

            modelBuilder.Entity<Egitim>(entity =>
            {
                entity.HasOne(d => d.Personel)
                    .WithMany(p => p.Egitim)
                    .HasForeignKey(d => d.PersonelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Egitim_Personel");

                entity.HasOne(d => d.Ulke)
                    .WithMany(p => p.Egitim)
                    .HasForeignKey(d => d.UlkeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Egitim_Ulke");
            });

            modelBuilder.Entity<IsBasvuru>(entity =>
            {
                entity.HasOne(d => d.IsBasvuruDurumu)
                    .WithMany(p => p.IsBasvuru)
                    .HasForeignKey(d => d.IsBasvuruDurumuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IsBasvuru_IsBasvuruDurumu");

                entity.HasOne(d => d.IsIlani)
                    .WithMany(p => p.IsBasvuru)
                    .HasForeignKey(d => d.IsIlaniId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IsBasvuru_IsIlani");

                entity.HasOne(d => d.Personel)
                    .WithMany(p => p.IsBasvuru)
                    .HasForeignKey(d => d.PersonelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IsBasvuru_Personel");
            });

            modelBuilder.Entity<IsDeneyim>(entity =>
            {
                entity.HasOne(d => d.Personel)
                    .WithMany(p => p.IsDeneyim)
                    .HasForeignKey(d => d.PersonelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IsDeneyim_Personel");

                entity.HasOne(d => d.Ulke)
                    .WithMany(p => p.IsDeneyim)
                    .HasForeignKey(d => d.UlkeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IsDeneyim_Ulke");
            });

            modelBuilder.Entity<IsGerekliliklerDetay>(entity =>
            {
                entity.HasOne(d => d.IsGereklilikler)
                    .WithMany(p => p.IsGerekliliklerDetay)
                    .HasForeignKey(d => d.IsGerekliliklerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IsGerekliliklerDetay_IsGereklilikler");
            });

            modelBuilder.Entity<IsIlani>(entity =>
            {
                entity.HasOne(d => d.IsDurumu)
                    .WithMany(p => p.IsIlani)
                    .HasForeignKey(d => d.IsDurumuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IsIlani_IsDurumu");

                entity.HasOne(d => d.IsDurumuNavigation)
                    .WithMany(p => p.IsIlani)
                    .HasForeignKey(d => d.IsDurumuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IsIlani_IsZamani");

                entity.HasOne(d => d.IsGereklilikler)
                    .WithMany(p => p.IsIlani)
                    .HasForeignKey(d => d.IsGerekliliklerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IsIlani_IsGereklilikler");

                entity.HasOne(d => d.IsKategori)
                    .WithMany(p => p.IsIlani)
                    .HasForeignKey(d => d.IsKategoriId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IsIlani_IsKategori");

                entity.HasOne(d => d.Kullanici)
                    .WithMany(p => p.IsIlani)
                    .HasForeignKey(d => d.KullaniciId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IsIlani_Kullanici");

                entity.HasOne(d => d.Sirket)
                    .WithMany(p => p.IsIlani)
                    .HasForeignKey(d => d.SirketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IsIlani_Sirket");
            });

            modelBuilder.Entity<IsZamani>(entity =>
            {
                entity.Property(e => e.IsZamaniId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Kullanici>(entity =>
            {
                entity.Property(e => e.İletisimNo).IsUnicode(false);

                entity.HasOne(d => d.HesapDurumu)
                    .WithMany(p => p.Kullanici)
                    .HasForeignKey(d => d.HesapDurumuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kullanici_HesapDurumu");

                entity.HasOne(d => d.KullaniciTip)
                    .WithMany(p => p.Kullanici)
                    .HasForeignKey(d => d.KullaniciTipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KullaniciTipi_Kullanici");
            });

            modelBuilder.Entity<Personel>(entity =>
            {
                entity.HasOne(d => d.IsKategori)
                    .WithMany(p => p.Personel)
                    .HasForeignKey(d => d.IsKategoriId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Personel_IsKategori");

                entity.HasOne(d => d.Kullanici)
                    .WithMany(p => p.Personel)
                    .HasForeignKey(d => d.KullaniciId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Personel_Kullanici");

                entity.HasOne(d => d.KullaniciNavigation)
                    .WithMany(p => p.Personel)
                    .HasForeignKey(d => d.KullaniciId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Personel_Ulke");
            });

            modelBuilder.Entity<Sertifika>(entity =>
            {
                entity.HasOne(d => d.Personel)
                    .WithMany(p => p.Sertifika)
                    .HasForeignKey(d => d.PersonelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sertifika_Personel");
            });

            modelBuilder.Entity<Sirket>(entity =>
            {
                entity.Property(e => e.SirketId).ValueGeneratedNever();

                entity.Property(e => e.KullaniciId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Kullanici)
                    .WithMany(p => p.Sirket)
                    .HasForeignKey(d => d.KullaniciId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sirket_Kullanici");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
