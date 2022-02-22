using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using KeuAPI.Models;
using KeuAPI.Models.SP;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable
namespace KeuAPI.Data
{
    public class KeuApiContext : DbContext
    {
        public KeuApiContext(DbContextOptions<KeuApiContext> options)
            : base(options)
        { }

        //public override int SaveChanges()
        //{
        //    var entries = ChangeTracker
        //        .Entries()
        //        .Where(e => e.Entity is Entity && (
        //                e.State == EntityState.Added
        //                || e.State == EntityState.Modified));

        //    foreach (var entityEntry in entries)
        //    {
        //        ((Entity)entityEntry.Entity).UpdatedDate = DateTime.Now;

        //        if (entityEntry.State == EntityState.Added)
        //        {
        //            ((Entity)entityEntry.Entity).CreatedDate = DateTime.Now;
        //        }
        //    }

        //    return base.SaveChanges();
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agama>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AgamaId).HasColumnName("AgamaID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PrefixVa)
                    .HasColumnName("PrefixVA")
                    .HasMaxLength(50);

                entity.Property(e => e.PrefixVadanaSatuTahun)
                    .HasColumnName("PrefixVADanaSatuTahun")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Siswa>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.NoSpj, e.SekolahKelasId, e.AgamaId, e.SubAgamaId, e.KodePosId, e.GolonganDarahId })
                    .HasName("IX_Siswa")
                    .IsUnique();

                entity.Property(e => e.AgamaId).HasColumnName("AgamaID");

                entity.Property(e => e.Alamat).HasMaxLength(255);

                entity.Property(e => e.Angkatan).HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.EmailPenabur).HasMaxLength(255);

                entity.Property(e => e.GolonganDarahId).HasColumnName("GolonganDarahID");

                entity.Property(e => e.JarakRumah).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JenisKelamin).HasMaxLength(255);

                entity.Property(e => e.KodePosId).HasColumnName("KodePosID");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.NoInduk).HasMaxLength(255);

                entity.Property(e => e.NoMobile).HasMaxLength(255);

                entity.Property(e => e.NoRegPsb)
                    .HasColumnName("NoRegPSB")
                    .HasMaxLength(50);

                entity.Property(e => e.NoSpj)
                    .HasColumnName("NoSPJ")
                    .HasMaxLength(10);

                entity.Property(e => e.NoTelepon).HasMaxLength(255);

                entity.Property(e => e.NoUrut).HasMaxLength(255);

                entity.Property(e => e.PasswordDefaultEmailPenabur).HasMaxLength(255);

                entity.Property(e => e.PengisianId).HasColumnName("PengisianID");

                entity.Property(e => e.SekolahKelasId).HasColumnName("SekolahKelasID");

                entity.Property(e => e.SubAgamaId).HasColumnName("SubAgamaID");

                entity.Property(e => e.TanggalLahir).HasColumnType("datetime");

                entity.Property(e => e.TempatLahir).HasMaxLength(255);

                entity.Property(e => e.UrlPhoto).HasMaxLength(255);
            });

            modelBuilder.Entity<SubAgama>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AgamaId).HasColumnName("AgamaID");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.SubAgamaId).HasColumnName("SubAgamaID");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserId);
                //entity.HasNoKey();

                entity.HasIndex(e => e.UserId)
                    .HasName("UQ__tmp_ms_x__1788CCAD9C158E87")
                    .IsUnique();

                entity.HasIndex(e => e.UserName)
                    .HasName("UQ__tmp_ms_x__C9F28456182DFBF5")
                    .IsUnique();

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Nik)
                    .HasColumnName("NIK")
                    .HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255);

                //entity.Property(e => e.RefreshToken).HasMaxLength(255);

                //entity.Property(e => e.RefreshTokenExpiryTime).HasColumnType("datetime");
                
                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<ViewMasterSiswa2122>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Master_Siswa_2122");

                entity.Property(e => e.Agama).HasMaxLength(50);

                entity.Property(e => e.AlamatSiswa).HasMaxLength(255);

                entity.Property(e => e.Alumni)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAyah)
                    .HasColumnName("email_ayah")
                    .HasMaxLength(50);

                entity.Property(e => e.EmailIbu)
                    .HasColumnName("email_ibu")
                    .HasMaxLength(50);

                entity.Property(e => e.GolDarah).HasMaxLength(50);

                entity.Property(e => e.Hp).HasMaxLength(255);

                entity.Property(e => e.IdGki)
                    .IsRequired()
                    .HasColumnName("IdGKI")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.JenKel).HasMaxLength(255);

                entity.Property(e => e.Kelas).HasMaxLength(50);

                entity.Property(e => e.Kode)
                    .HasColumnName("kode")
                    .HasMaxLength(10);

                entity.Property(e => e.KodePos).HasMaxLength(50);

                entity.Property(e => e.KodePosAyah)
                    .HasColumnName("kode_pos_ayah")
                    .HasMaxLength(50);

                entity.Property(e => e.KodeSek).HasMaxLength(10);

                entity.Property(e => e.Kota).HasMaxLength(50);

                entity.Property(e => e.KotaAyah)
                    .HasColumnName("kota_ayah")
                    .HasMaxLength(50);

                entity.Property(e => e.NamaAyah).HasMaxLength(50);

                entity.Property(e => e.NamaIbu).HasMaxLength(50);

                entity.Property(e => e.NamaSiswa).HasMaxLength(200);

                entity.Property(e => e.NamaWali).HasMaxLength(50);

                entity.Property(e => e.NoHp)
                    .HasColumnName("no_hp")
                    .HasMaxLength(50);

                entity.Property(e => e.NoHpIbu)
                    .HasColumnName("no_hp_ibu")
                    .HasMaxLength(50);

                entity.Property(e => e.NoInduk)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NoTelp)
                    .HasColumnName("no_telp")
                    .HasMaxLength(50);

                entity.Property(e => e.Noregpsb)
                    .HasColumnName("noregpsb")
                    .HasMaxLength(50);

                entity.Property(e => e.Nospj)
                    .HasColumnName("nospj")
                    .HasMaxLength(10);

                entity.Property(e => e.PekerjaanAyah)
                    .IsRequired()
                    .HasColumnName("pekerjaan_ayah")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SubAgama).HasMaxLength(255);

                entity.Property(e => e.TanggalMasuk).HasColumnType("datetime");

                entity.Property(e => e.Telpon).HasMaxLength(255);

                entity.Property(e => e.TglAkhirStudi).HasColumnType("datetime");

                entity.Property(e => e.TglLahir).HasColumnType("datetime");

                entity.Property(e => e.TmpLahir).HasMaxLength(255);
            });
            //modelBuilder.Entity<TblProduct>(entity =>
            //{
            //    entity.HasKey(e => e.ProductId);

            //    entity.ToTable("tbl_product");

            //    entity.Property(e => e.ProductId).HasColumnName("ProductID");

            //    entity.Property(e => e.Color).IsRequired();

            //    entity.Property(e => e.Name).IsRequired();

            //    entity.Property(e => e.Price).HasColumnType("money");

            //    entity.Property(e => e.ProductNumber).IsRequired();
            //});

            //modelBuilder.Query<GetAgamaByAgamaID>();
            //modelBuilder.Query<GetAllAgama>();
        }
        public DbSet<Agama> Agama { get; set; }
        public DbSet<Bank> Bank { get; set; }
        public DbSet<Siswa> Siswa { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<ViewMasterSiswa2122> ViewMasterSiswa2122 { get; set; }
    }
}
