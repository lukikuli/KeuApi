//using System;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata;

//// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
//// If you have enabled NRTs for your project, then un-comment the following line:
//// #nullable disable

//namespace KeuAPI.Models
//{
//    public partial class KeuApiContext1 : DbContext
//    {
//        public KeuApiContext1()
//        {
//        }

//        public KeuApiContext1(DbContextOptions<KeuApiContext1> options)
//            : base(options)
//        {
//        }

//        public virtual DbSet<Access> Access { get; set; }
//        public virtual DbSet<Agama> Agama { get; set; }
//        public virtual DbSet<AlasanPergantianKelas> AlasanPergantianKelas { get; set; }
//        public virtual DbSet<Bank> Bank { get; set; }
//        public virtual DbSet<CaraBayar> CaraBayar { get; set; }
//        public virtual DbSet<DaftarUlang> DaftarUlang { get; set; }
//        public virtual DbSet<DaftarUlangH> DaftarUlangH { get; set; }
//        public virtual DbSet<GolonganDarah> GolonganDarah { get; set; }
//        public virtual DbSet<Hubungan> Hubungan { get; set; }
//        public virtual DbSet<JenjangPendidikan> JenjangPendidikan { get; set; }
//        public virtual DbSet<KodePos> KodePos { get; set; }
//        public virtual DbSet<Kota> Kota { get; set; }
//        public virtual DbSet<PembayaranDanaSatuTahun> PembayaranDanaSatuTahun { get; set; }
//        public virtual DbSet<PembayaranUangSekolah> PembayaranUangSekolah { get; set; }
//        public virtual DbSet<PembayaranUangSekolahH> PembayaranUangSekolahH { get; set; }
//        public virtual DbSet<Pengisian> Pengisian { get; set; }
//        public virtual DbSet<Pengurus> Pengurus { get; set; }
//        public virtual DbSet<PergantianKelas> PergantianKelas { get; set; }
//        public virtual DbSet<PergantianKelasLog> PergantianKelasLog { get; set; }
//        public virtual DbSet<PerubahanUangSekolahSiswa> PerubahanUangSekolahSiswa { get; set; }
//        public virtual DbSet<Role> Role { get; set; }
//        public virtual DbSet<RoleAccess> RoleAccess { get; set; }
//        public virtual DbSet<SasMasterSiswaAll> SasMasterSiswaAll { get; set; }
//        public virtual DbSet<Sekolah> Sekolah { get; set; }
//        public virtual DbSet<SekolahKelas> SekolahKelas { get; set; }
//        public virtual DbSet<Siswa> Siswa { get; set; }
//        public virtual DbSet<SubAgama> SubAgama { get; set; }
//        public virtual DbSet<TahunAjaran> TahunAjaran { get; set; }
//        public virtual DbSet<TempSiswa> TempSiswa { get; set; }
//        public virtual DbSet<Trial> Trial { get; set; }
//        public virtual DbSet<TunggakanAll1920> TunggakanAll1920 { get; set; }
//        public virtual DbSet<TunggakanAll2021> TunggakanAll2021 { get; set; }
//        public virtual DbSet<TunggakanAll2122> TunggakanAll2122 { get; set; }
//        public virtual DbSet<TvSyncKeringanan> TvSyncKeringanan { get; set; }
//        public virtual DbSet<UangSekolah> UangSekolah { get; set; }
//        public virtual DbSet<UangSekolahLog> UangSekolahLog { get; set; }
//        public virtual DbSet<User> User { get; set; }
//        public virtual DbSet<ViewAlumniSma> ViewAlumniSma { get; set; }
//        public virtual DbSet<ViewDanaAll> ViewDanaAll { get; set; }
//        public virtual DbSet<ViewMasterSiswa> ViewMasterSiswa { get; set; }
//        public virtual DbSet<ViewMasterSiswa1920> ViewMasterSiswa1920 { get; set; }
//        public virtual DbSet<ViewMasterSiswa1920Pusat> ViewMasterSiswa1920Pusat { get; set; }
//        public virtual DbSet<ViewMasterSiswa1920Tm> ViewMasterSiswa1920Tm { get; set; }
//        public virtual DbSet<ViewMasterSiswa2021> ViewMasterSiswa2021 { get; set; }
//        public virtual DbSet<ViewMasterSiswa2021Pusat> ViewMasterSiswa2021Pusat { get; set; }
//        public virtual DbSet<ViewMasterSiswa2021Tm> ViewMasterSiswa2021Tm { get; set; }
//        public virtual DbSet<ViewMasterSiswa2122> ViewMasterSiswa2122 { get; set; }
//        public virtual DbSet<ViewMasterSiswa2122Pusat> ViewMasterSiswa2122Pusat { get; set; }
//        public virtual DbSet<ViewMasterSiswa2122Tm> ViewMasterSiswa2122Tm { get; set; }
//        public virtual DbSet<ViewMasterSiswaNew> ViewMasterSiswaNew { get; set; }
//        public virtual DbSet<ViewSekolahKelasAll> ViewSekolahKelasAll { get; set; }
//        public virtual DbSet<ViewSekolahKelasAll1920> ViewSekolahKelasAll1920 { get; set; }
//        public virtual DbSet<ViewSekolahKelasAll2021> ViewSekolahKelasAll2021 { get; set; }
//        public virtual DbSet<ViewSekolahKelasAll2122> ViewSekolahKelasAll2122 { get; set; }
//        public virtual DbSet<ViewTunggakanAll> ViewTunggakanAll { get; set; }
//        public virtual DbSet<ViewTunggakanAll1920> ViewTunggakanAll1920 { get; set; }
//        public virtual DbSet<ViewTunggakanAll2021> ViewTunggakanAll2021 { get; set; }
//        public virtual DbSet<ViewTunggakanAll2122> ViewTunggakanAll2122 { get; set; }
//        public virtual DbSet<ViewTunggakanDstAll> ViewTunggakanDstAll { get; set; }
//        public virtual DbSet<ViewTunggakanDstAll1920> ViewTunggakanDstAll1920 { get; set; }
//        public virtual DbSet<ViewTunggakanDstAll2021> ViewTunggakanDstAll2021 { get; set; }
//        public virtual DbSet<ViewTunggakanDstAll2122> ViewTunggakanDstAll2122 { get; set; }
//        public virtual DbSet<ViewTunggakanUsekAll> ViewTunggakanUsekAll { get; set; }
//        public virtual DbSet<ViewTunggakanUsekAll1920> ViewTunggakanUsekAll1920 { get; set; }
//        public virtual DbSet<ViewTunggakanUsekAll2021> ViewTunggakanUsekAll2021 { get; set; }
//        public virtual DbSet<ViewTunggakanUsekAll2122> ViewTunggakanUsekAll2122 { get; set; }
//        public virtual DbSet<ViewUsekAll> ViewUsekAll { get; set; }
//        public virtual DbSet<ViewUsekAll1920> ViewUsekAll1920 { get; set; }
//        public virtual DbSet<ViewUsekAll2021> ViewUsekAll2021 { get; set; }
//        public virtual DbSet<ViewUsekAll2122> ViewUsekAll2122 { get; set; }
//        public virtual DbSet<ViewUsekAllB> ViewUsekAllB { get; set; }
//        public virtual DbSet<WaliSiswa> WaliSiswa { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=localhost;Database=KeuApi;Trusted_Connection=True;MultipleActiveResultSets=true;User ID=BPA-0004\\\\\\\\USER;Password='';");
//            }
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<Access>(entity =>
//            {
//                entity.HasNoKey();

//                entity.Property(e => e.AccessId).HasColumnName("AccessID");

//                entity.Property(e => e.Code)
//                    .IsRequired()
//                    .HasMaxLength(50);

//                entity.Property(e => e.Name)
//                    .IsRequired()
//                    .HasMaxLength(50);
//            });

//            modelBuilder.Entity<Agama>(entity =>
//            {
//                entity.HasNoKey();

//                entity.Property(e => e.AgamaId).HasColumnName("AgamaID");

//                entity.Property(e => e.Name).HasMaxLength(50);
//            });

//            modelBuilder.Entity<AlasanPergantianKelas>(entity =>
//            {
//                entity.HasNoKey();

//                entity.Property(e => e.AlasanPergantianKelasId).HasColumnName("AlasanPergantianKelasID");

//                entity.Property(e => e.Name).HasMaxLength(50);
//            });

//            modelBuilder.Entity<Bank>(entity =>
//            {
//                entity.HasNoKey();

//                entity.Property(e => e.BankId).HasColumnName("BankID");

//                entity.Property(e => e.Name).HasMaxLength(50);

//                entity.Property(e => e.PrefixVa)
//                    .HasColumnName("PrefixVA")
//                    .HasMaxLength(50);

//                entity.Property(e => e.PrefixVadanaSatuTahun)
//                    .HasColumnName("PrefixVADanaSatuTahun")
//                    .HasMaxLength(50);
//            });

//            modelBuilder.Entity<CaraBayar>(entity =>
//            {
//                entity.HasNoKey();

//                entity.Property(e => e.CaraBayarId).HasColumnName("CaraBayarID");

//                entity.Property(e => e.DetailCicilan).HasMaxLength(50);

//                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Name).HasMaxLength(50);

//                entity.Property(e => e.SekolahId).HasColumnName("SekolahID");
//            });

//            modelBuilder.Entity<DaftarUlang>(entity =>
//            {
//                entity.HasNoKey();

//                entity.Property(e => e.ArchivedDate).HasColumnType("datetime");

//                entity.Property(e => e.DafulId).HasColumnName("DafulID");

//                entity.Property(e => e.DafulNo)
//                    .IsRequired()
//                    .HasMaxLength(50);

//                entity.Property(e => e.Dinaikkan).HasDefaultValueSql("((0))");

//                entity.Property(e => e.EditUserId).HasColumnName("EditUserID");

//                entity.Property(e => e.Keterangan)
//                    .HasMaxLength(250)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoSpj)
//                    .IsRequired()
//                    .HasColumnName("NoSPJ")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NoVabca)
//                    .HasColumnName("NoVABCA")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NominalAdmin).HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.NominalUsek).HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.PengisianId).HasColumnName("PengisianID");

//                entity.Property(e => e.SekolahKelasId).HasColumnName("SekolahKelasID");

//                entity.Property(e => e.TahunAjaranId).HasColumnName("TahunAjaranID");

//                entity.Property(e => e.TanggalCreated).HasColumnType("datetime");

//                entity.Property(e => e.TanggalEdit).HasColumnType("datetime");

//                entity.Property(e => e.TanggalEntry).HasColumnType("datetime");

//                entity.Property(e => e.TanggalJatuhTempo).HasColumnType("datetime");

//                entity.Property(e => e.TanggalLunas).HasColumnType("datetime");
//            });

//            modelBuilder.Entity<DaftarUlangH>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("DaftarUlang_H");

//                entity.Property(e => e.ArchivedDate).HasColumnType("datetime");

//                entity.Property(e => e.DafulId).HasColumnName("DafulID");

//                entity.Property(e => e.DafulNo)
//                    .IsRequired()
//                    .HasMaxLength(50);

//                entity.Property(e => e.EditUserId).HasColumnName("EditUserID");

//                entity.Property(e => e.Keterangan)
//                    .HasMaxLength(250)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoSpj)
//                    .IsRequired()
//                    .HasColumnName("NoSPJ")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NoVabca)
//                    .HasColumnName("NoVABCA")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NominalAdmin).HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.NominalUsek).HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.PengisianId).HasColumnName("PengisianID");

//                entity.Property(e => e.SekolahKelasId).HasColumnName("SekolahKelasID");

//                entity.Property(e => e.TahunAjaranId).HasColumnName("TahunAjaranID");

//                entity.Property(e => e.TanggalCreated).HasColumnType("datetime");

//                entity.Property(e => e.TanggalEdit).HasColumnType("datetime");

//                entity.Property(e => e.TanggalEntry).HasColumnType("datetime");

//                entity.Property(e => e.TanggalJatuhTempo).HasColumnType("datetime");

//                entity.Property(e => e.TanggalLunas).HasColumnType("datetime");
//            });

//            modelBuilder.Entity<GolonganDarah>(entity =>
//            {
//                entity.HasNoKey();

//                entity.Property(e => e.GolonganDarahId).HasColumnName("GolonganDarahID");

//                entity.Property(e => e.Name).HasMaxLength(50);
//            });

//            modelBuilder.Entity<Hubungan>(entity =>
//            {
//                entity.HasNoKey();

//                entity.Property(e => e.HubunganId).HasColumnName("HubunganID");

//                entity.Property(e => e.HubunganName).HasMaxLength(50);

//                entity.Property(e => e.NoSpj)
//                    .HasColumnName("NoSPJ")
//                    .HasMaxLength(50);

//                entity.Property(e => e.WaliSiswaId).HasColumnName("WaliSiswaID");
//            });

//            modelBuilder.Entity<JenjangPendidikan>(entity =>
//            {
//                entity.HasNoKey();

//                entity.Property(e => e.JenjangPendidikanId).HasColumnName("JenjangPendidikanID");

//                entity.Property(e => e.Keterangan).HasMaxLength(250);

//                entity.Property(e => e.Name).HasMaxLength(50);
//            });

//            modelBuilder.Entity<KodePos>(entity =>
//            {
//                entity.HasNoKey();

//                entity.Property(e => e.KodePosId).HasColumnName("KodePosID");

//                entity.Property(e => e.KotaId).HasColumnName("KotaID");

//                entity.Property(e => e.Name).HasMaxLength(50);
//            });

//            modelBuilder.Entity<Kota>(entity =>
//            {
//                entity.HasNoKey();

//                entity.Property(e => e.KotaId).HasColumnName("KotaID");

//                entity.Property(e => e.Name)
//                    .IsRequired()
//                    .HasMaxLength(50);
//            });

//            modelBuilder.Entity<PembayaranDanaSatuTahun>(entity =>
//            {
//                entity.HasNoKey();

//                entity.HasIndex(e => new { e.PembayaranDanaSatuTahunId, e.UangSekolahId, e.BankId })
//                    .HasName("NonClusteredIndex-20180814-105725");

//                entity.Property(e => e.BankId).HasColumnName("BankID");

//                entity.Property(e => e.CaraPembayaran).HasMaxLength(50);

//                entity.Property(e => e.EditUserId).HasColumnName("EditUserID");

//                entity.Property(e => e.NoRekening).HasMaxLength(50);

//                entity.Property(e => e.NoVa)
//                    .HasColumnName("NoVA")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Nominal).HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.NominalDibayar).HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.PembayaranDanaSatuTahunId).HasColumnName("PembayaranDanaSatuTahunID");

//                entity.Property(e => e.TanggalEdit).HasColumnType("datetime");

//                entity.Property(e => e.TanggalEntry).HasColumnType("datetime");

//                entity.Property(e => e.TanggalJatuhTempo).HasColumnType("datetime");

//                entity.Property(e => e.TanggalLunas).HasColumnType("datetime");

//                entity.Property(e => e.UangSekolahId).HasColumnName("UangSekolahID");
//            });

//            modelBuilder.Entity<PembayaranUangSekolah>(entity =>
//            {
//                entity.HasNoKey();

//                entity.HasIndex(e => e.UangSekolahId)
//                    .HasName("NonClusteredIndex-20180718-084238");

//                entity.Property(e => e.BankId).HasColumnName("BankID");

//                entity.Property(e => e.CaraPembayaran).HasMaxLength(50);

//                entity.Property(e => e.EditUserId).HasColumnName("EditUserID");

//                entity.Property(e => e.NoRekening).HasMaxLength(50);

//                entity.Property(e => e.NoVa)
//                    .HasColumnName("NoVA")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Nominal).HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.NominalDibayar).HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.PembayaranUangSekolahId).HasColumnName("PembayaranUangSekolahID");

//                entity.Property(e => e.TanggalEdit).HasColumnType("datetime");

//                entity.Property(e => e.TanggalEntry).HasColumnType("datetime");

//                entity.Property(e => e.TanggalJatuhTempo).HasColumnType("datetime");

//                entity.Property(e => e.TanggalLunas).HasColumnType("datetime");

//                entity.Property(e => e.UangSekolahId).HasColumnName("UangSekolahID");
//            });

//            modelBuilder.Entity<PembayaranUangSekolahH>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("PembayaranUangSekolah_H");

//                entity.Property(e => e.BankId).HasColumnName("BankID");

//                entity.Property(e => e.CaraPembayaran).HasMaxLength(50);

//                entity.Property(e => e.EditUserId).HasColumnName("EditUserID");

//                entity.Property(e => e.NoRekening).HasMaxLength(50);

//                entity.Property(e => e.NoVa)
//                    .HasColumnName("NoVA")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Nominal).HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.NominalDibayar).HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.PembayaranUangSekolahId).HasColumnName("PembayaranUangSekolahID");

//                entity.Property(e => e.TanggalEdit).HasColumnType("datetime");

//                entity.Property(e => e.TanggalEntry).HasColumnType("datetime");

//                entity.Property(e => e.TanggalJatuhTempo).HasColumnType("datetime");

//                entity.Property(e => e.TanggalLunas).HasColumnType("datetime");

//                entity.Property(e => e.UangSekolahId).HasColumnName("UangSekolahID");
//            });

//            modelBuilder.Entity<Pengisian>(entity =>
//            {
//                entity.HasNoKey();

//                entity.HasIndex(e => new { e.Kode, e.TahunAjaranId })
//                    .HasName("Pengisian")
//                    .IsUnique();

//                entity.Property(e => e.EditDate).HasColumnType("datetime");

//                entity.Property(e => e.EditUserId).HasColumnName("EditUserID");

//                entity.Property(e => e.Keterangan).HasMaxLength(255);

//                entity.Property(e => e.Kode).HasMaxLength(10);

//                entity.Property(e => e.PengisianId).HasColumnName("PengisianID");

//                entity.Property(e => e.Ssp)
//                    .HasColumnName("SSP")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.TahunAjaranId).HasColumnName("TahunAjaranID");

//                entity.Property(e => e.Usek)
//                    .HasColumnName("USek")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.UsekMin)
//                    .HasColumnName("USekMin")
//                    .HasColumnType("decimal(18, 2)");
//            });

//            modelBuilder.Entity<Pengurus>(entity =>
//            {
//                entity.HasNoKey();

//                entity.Property(e => e.Keterangan).HasMaxLength(255);

//                entity.Property(e => e.Name).HasMaxLength(50);

//                entity.Property(e => e.PengurusId).HasColumnName("PengurusID");
//            });

//            modelBuilder.Entity<PergantianKelas>(entity =>
//            {
//                entity.HasNoKey();

//                entity.HasIndex(e => new { e.PergantianKelasId, e.SekolahKelasIdasal, e.SekolahKelasIdtujuan, e.AlasanPergantianKelasId, e.NoSpj })
//                    .HasName("NonClusteredIndex-20180814-105600");

//                entity.Property(e => e.AlasanPergantianKelasId).HasColumnName("AlasanPergantianKelasID");

//                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

//                entity.Property(e => e.Keterangan).HasMaxLength(255);

//                entity.Property(e => e.NoSpj)
//                    .HasColumnName("NoSPJ")
//                    .HasMaxLength(50);

//                entity.Property(e => e.PergantianKelasId).HasColumnName("PergantianKelasID");

//                entity.Property(e => e.SekolahKelasIdasal).HasColumnName("SekolahKelasIDAsal");

//                entity.Property(e => e.SekolahKelasIdtujuan).HasColumnName("SekolahKelasIDTujuan");

//                entity.Property(e => e.TanggalKeluar).HasColumnType("datetime");

//                entity.Property(e => e.TanggalMasuk).HasColumnType("datetime");

//                entity.Property(e => e.TanggalProses).HasColumnType("datetime");
//            });

//            modelBuilder.Entity<PergantianKelasLog>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("PergantianKelas_Log");

//                entity.Property(e => e.AlasanPergantianKelasId).HasColumnName("AlasanPergantianKelasID");

//                entity.Property(e => e.Keterangan).HasMaxLength(255);

//                entity.Property(e => e.NoSpj)
//                    .HasColumnName("NoSPJ")
//                    .HasMaxLength(50);

//                entity.Property(e => e.PergantianKelasId).HasColumnName("PergantianKelasID");

//                entity.Property(e => e.SekolahKelasIdasal).HasColumnName("SekolahKelasIDAsal");

//                entity.Property(e => e.SekolahKelasIdtujuan).HasColumnName("SekolahKelasIDTujuan");

//                entity.Property(e => e.TanggalKeluar).HasColumnType("datetime");

//                entity.Property(e => e.TanggalMasuk).HasColumnType("datetime");
//            });

//            modelBuilder.Entity<PerubahanUangSekolahSiswa>(entity =>
//            {
//                entity.HasNoKey();

//                entity.Property(e => e.EditUserId).HasColumnName("EditUserID");

//                entity.Property(e => e.Keterangan).HasMaxLength(255);

//                entity.Property(e => e.NominalAkhir).HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.NominalAwal).HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.PengurusId).HasColumnName("PengurusID");

//                entity.Property(e => e.PerubahanUangSekolahSiswaId).HasColumnName("PerubahanUangSekolahSiswaID");

//                entity.Property(e => e.TanggalPermohonan).HasColumnType("datetime");

//                entity.Property(e => e.TanggalProses).HasColumnType("datetime");

//                entity.Property(e => e.UangSekolahId).HasColumnName("UangSekolahID");
//            });

//            modelBuilder.Entity<Role>(entity =>
//            {
//                entity.HasNoKey();

//                entity.Property(e => e.Name)
//                    .IsRequired()
//                    .HasMaxLength(50);

//                entity.Property(e => e.RoleId).HasColumnName("RoleID");
//            });

//            modelBuilder.Entity<RoleAccess>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("Role_Access");

//                entity.Property(e => e.AccessId).HasColumnName("AccessID");

//                entity.Property(e => e.RoleId).HasColumnName("RoleID");
//            });

//            modelBuilder.Entity<SasMasterSiswaAll>(entity =>
//            {
//                entity.ToTable("sas_master_siswa_all");

//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.Agama)
//                    .HasColumnName("agama")
//                    .HasMaxLength(3)
//                    .IsUnicode(false);

//                entity.Property(e => e.AgamaAyah)
//                    .HasColumnName("agama_ayah")
//                    .HasMaxLength(3)
//                    .IsUnicode(false);

//                entity.Property(e => e.AgamaIbu)
//                    .HasColumnName("agama_ibu")
//                    .HasMaxLength(3)
//                    .IsUnicode(false);

//                entity.Property(e => e.AgamaKepercayaanLain)
//                    .HasColumnName("agama_kepercayaan_lain")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.AgamaKepercayaanLainAyah)
//                    .HasColumnName("agama_kepercayaan_lain_ayah")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.AgamaKepercayaanLainIbu)
//                    .HasColumnName("agama_kepercayaan_lain_ibu")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.AgamaKepercayaanLainWali)
//                    .HasColumnName("agama_kepercayaan_lain_wali")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.AgamaWali)
//                    .HasColumnName("agama_wali")
//                    .HasMaxLength(3)
//                    .IsUnicode(false);

//                entity.Property(e => e.AktaGantiNama)
//                    .HasColumnName("akta_ganti_nama")
//                    .HasColumnType("text");

//                entity.Property(e => e.AlamatAyah)
//                    .HasColumnName("alamat_ayah")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.AlamatIbu)
//                    .HasColumnName("alamat_ibu")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.AlamatKantorAyah)
//                    .HasColumnName("alamat_kantor_ayah")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.AlamatKantorIbu)
//                    .HasColumnName("alamat_kantor_ibu")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.AlamatKantorWali)
//                    .HasColumnName("alamat_kantor_wali")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.AlamatSiswa)
//                    .HasColumnName("alamat_siswa")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.AlamatWali)
//                    .HasColumnName("alamat_wali")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.Anakke)
//                    .HasColumnName("anakke")
//                    .HasMaxLength(4)
//                    .IsUnicode(false);

//                entity.Property(e => e.Asalsekolah)
//                    .HasColumnName("asalsekolah")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.Bahasa)
//                    .HasColumnName("bahasa")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.Creator).HasColumnName("creator");

//                entity.Property(e => e.DateTime)
//                    .HasColumnName("date_time")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Diterimakelas)
//                    .HasColumnName("diterimakelas")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.Diterimatanggal)
//                    .HasColumnName("diterimatanggal")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.EmailAyah)
//                    .HasColumnName("email_ayah")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.EmailIbu)
//                    .HasColumnName("email_ibu")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.EmailPenabur)
//                    .HasColumnName("email_penabur")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.EmailPenaburFlag)
//                    .HasColumnName("email_penabur_flag")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.EmailPribadi)
//                    .HasColumnName("email_pribadi")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.EmailWali)
//                    .HasColumnName("email_wali")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Facebook)
//                    .HasColumnName("facebook")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.FacebookAyah)
//                    .HasColumnName("facebook_ayah")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.FacebookIbu)
//                    .HasColumnName("facebook_ibu")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.FacebookWali)
//                    .HasColumnName("facebook_wali")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.GeoAyah)
//                    .HasColumnName("geo_ayah")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.GeoIbu)
//                    .HasColumnName("geo_ibu")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.GeoSiswa)
//                    .HasColumnName("geo_siswa")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.GeoWali)
//                    .HasColumnName("geo_wali")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.Goldarah)
//                    .HasColumnName("goldarah")
//                    .HasMaxLength(3)
//                    .IsUnicode(false);

//                entity.Property(e => e.HpAyah)
//                    .HasColumnName("hp_ayah")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.HpIbu)
//                    .HasColumnName("hp_ibu")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.HpOrangtua)
//                    .HasColumnName("hp_orangtua")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.HpPribadi)
//                    .HasColumnName("hp_pribadi")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.HpWali)
//                    .HasColumnName("hp_wali")
//                    .HasMaxLength(12)
//                    .IsUnicode(false);

//                entity.Property(e => e.Idgki).HasColumnName("idgki");

//                entity.Property(e => e.IdgkiAyah).HasColumnName("idgki_ayah");

//                entity.Property(e => e.IdgkiIbu).HasColumnName("idgki_ibu");

//                entity.Property(e => e.IdgkiWali).HasColumnName("idgki_wali");

//                entity.Property(e => e.Instagram)
//                    .HasColumnName("instagram")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.InstagramAyah)
//                    .HasColumnName("instagram_ayah")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.InstagramIbu)
//                    .HasColumnName("instagram_ibu")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.InstagramWali)
//                    .HasColumnName("instagram_wali")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.Ip)
//                    .HasColumnName("ip")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.JarakRumah)
//                    .HasColumnName("jarak_rumah")
//                    .HasColumnType("text");

//                entity.Property(e => e.JarakRumahSd)
//                    .HasColumnName("jarak_rumah_sd")
//                    .HasColumnType("text");

//                entity.Property(e => e.JarakRumahSmp)
//                    .HasColumnName("jarak_rumah_smp")
//                    .HasColumnType("text");

//                entity.Property(e => e.JarakRumahTk)
//                    .HasColumnName("jarak_rumah_tk")
//                    .HasColumnType("text");

//                entity.Property(e => e.Jenkel)
//                    .HasColumnName("jenkel")
//                    .HasMaxLength(3)
//                    .IsUnicode(false);

//                entity.Property(e => e.JenkelWali)
//                    .HasColumnName("jenkel_wali")
//                    .HasColumnType("text");

//                entity.Property(e => e.JumlahSaudaraAngkat)
//                    .HasColumnName("jumlah_saudara_angkat")
//                    .HasColumnType("text");

//                entity.Property(e => e.JumlahSaudaraKandung)
//                    .HasColumnName("jumlah_saudara_kandung")
//                    .HasColumnType("text");

//                entity.Property(e => e.JumlahSaudaraTiri)
//                    .HasColumnName("jumlah_saudara_tiri")
//                    .HasColumnType("text");

//                entity.Property(e => e.JurusanFakultasAyah)
//                    .HasColumnName("jurusan_fakultas_ayah")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.JurusanFakultasIbu)
//                    .HasColumnName("jurusan_fakultas_ibu")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.JurusanFakultasWali)
//                    .HasColumnName("jurusan_fakultas_wali")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.Kecamatan)
//                    .HasColumnName("kecamatan")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.KecamatanAyah)
//                    .HasColumnName("kecamatan_ayah")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.KecamatanIbu)
//                    .HasColumnName("kecamatan_ibu")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.KecamatanWali)
//                    .HasColumnName("kecamatan_wali")
//                    .HasColumnType("text");

//                entity.Property(e => e.Kelurahan)
//                    .HasColumnName("kelurahan")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.KelurahanAyah)
//                    .HasColumnName("kelurahan_ayah")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.KelurahanIbu)
//                    .HasColumnName("kelurahan_ibu")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.KelurahanWali)
//                    .HasColumnName("kelurahan_wali")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Kodepos)
//                    .HasColumnName("kodepos")
//                    .HasMaxLength(5)
//                    .IsUnicode(false);

//                entity.Property(e => e.KodeposAyah)
//                    .HasColumnName("kodepos_ayah")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.KodeposIbu)
//                    .HasColumnName("kodepos_ibu")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.KodeposWali)
//                    .HasColumnName("kodepos_wali")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.KondisiAyah)
//                    .HasColumnName("kondisi_ayah")
//                    .HasColumnType("text");

//                entity.Property(e => e.KondisiIbu)
//                    .HasColumnName("kondisi_ibu")
//                    .HasColumnType("text");

//                entity.Property(e => e.Kota)
//                    .HasColumnName("kota")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.KotaAyah)
//                    .HasColumnName("kota_ayah")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.KotaIbu)
//                    .HasColumnName("kota_ibu")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.KotaWali)
//                    .HasColumnName("kota_wali")
//                    .HasColumnType("text");

//                entity.Property(e => e.LatitudeAyah)
//                    .HasColumnName("latitude_ayah")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.LatitudeIbu)
//                    .HasColumnName("latitude_ibu")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.LatitudeSiswa)
//                    .HasColumnName("latitude_siswa")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.LatitudeWali)
//                    .HasColumnName("latitude_wali")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.Line)
//                    .HasColumnName("line")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.LineAyah)
//                    .HasColumnName("line_ayah")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.LineIbu)
//                    .HasColumnName("line_ibu")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.LineWali)
//                    .HasColumnName("line_wali")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.LongitudeAyah)
//                    .HasColumnName("longitude_ayah")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.LongitudeIbu)
//                    .HasColumnName("longitude_ibu")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.LongitudeSiswa)
//                    .HasColumnName("longitude_siswa")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.LongitudeWali)
//                    .HasColumnName("longitude_wali")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.Modified)
//                    .HasColumnName("modified")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Modifier).HasColumnName("modifier");

//                entity.Property(e => e.NamaLengkapGantiNama)
//                    .HasColumnName("nama_lengkap_ganti_nama")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.NamaPanggilan)
//                    .HasColumnName("nama_panggilan")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.NamaPenyingkatan)
//                    .HasColumnName("nama_penyingkatan")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.Namaayah)
//                    .HasColumnName("namaayah")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Namaibu)
//                    .HasColumnName("namaibu")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Namasiswa)
//                    .HasColumnName("namasiswa")
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.Namawali)
//                    .HasColumnName("namawali")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Negara)
//                    .HasColumnName("negara")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.NegaraAyah)
//                    .HasColumnName("negara_ayah")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.NegaraIbu)
//                    .HasColumnName("negara_ibu")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.NegaraWali)
//                    .HasColumnName("negara_wali")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.Nik)
//                    .HasColumnName("nik")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.NikAyah)
//                    .HasColumnName("nik_ayah")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.NikIbu)
//                    .HasColumnName("nik_ibu")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.NikWali)
//                    .HasColumnName("nik_wali")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.Nis)
//                    .HasColumnName("nis")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.Nisn)
//                    .HasColumnName("nisn")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoKkPasporAyah)
//                    .HasColumnName("no_kk_paspor_ayah")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoKkPasporIbu)
//                    .HasColumnName("no_kk_paspor_ibu")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoKkPasporWali)
//                    .HasColumnName("no_kk_paspor_wali")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoKtpKitasAyah)
//                    .HasColumnName("no_ktp_kitas_ayah")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoKtpKitasIbu)
//                    .HasColumnName("no_ktp_kitas_ibu")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoKtpKitasWali)
//                    .HasColumnName("no_ktp_kitas_wali")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoregAktaLahir)
//                    .HasColumnName("noreg_akta_lahir")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.Noregpsb)
//                    .HasColumnName("noregpsb")
//                    .HasMaxLength(25)
//                    .IsUnicode(false);

//                entity.Property(e => e.Nospj)
//                    .IsRequired()
//                    .HasColumnName("nospj")
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.PasswordEmailPenabur)
//                    .HasColumnName("password_email_penabur")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.PekerjaanLainAyah)
//                    .HasColumnName("pekerjaan_lain_ayah")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.PekerjaanLainIbu)
//                    .HasColumnName("pekerjaan_lain_ibu")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.PekerjaanLainWali)
//                    .HasColumnName("pekerjaan_lain_wali")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.Pekerjaanayah)
//                    .HasColumnName("pekerjaanayah")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.Pekerjaanibu)
//                    .HasColumnName("pekerjaanibu")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.Pekerjaanwali)
//                    .HasColumnName("pekerjaanwali")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.PendidikanAyah)
//                    .HasColumnName("pendidikan_ayah")
//                    .HasColumnType("text");

//                entity.Property(e => e.PendidikanIbu)
//                    .HasColumnName("pendidikan_ibu")
//                    .HasColumnType("text");

//                entity.Property(e => e.PendidikanWali)
//                    .HasColumnName("pendidikan_wali")
//                    .HasColumnType("text");

//                entity.Property(e => e.PenghasilanAyah)
//                    .HasColumnName("penghasilan_ayah")
//                    .HasColumnType("text");

//                entity.Property(e => e.PenghasilanIbu)
//                    .HasColumnName("penghasilan_ibu")
//                    .HasColumnType("text");

//                entity.Property(e => e.PenghasilanWali)
//                    .HasColumnName("penghasilan_wali")
//                    .HasColumnType("text");

//                entity.Property(e => e.PenyebabMeninggalAyah)
//                    .HasColumnName("penyebab_meninggal_ayah")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.PenyebabMeninggalIbu)
//                    .HasColumnName("penyebab_meninggal_ibu")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.PeriodeAyah)
//                    .HasColumnName("periode_ayah")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.PeriodeIbu)
//                    .HasColumnName("periode_ibu")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.PeriodeWali)
//                    .HasColumnName("periode_wali")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.PreferensiKontak)
//                    .HasColumnName("preferensi_kontak")
//                    .HasColumnType("text");

//                entity.Property(e => e.Provinsi)
//                    .HasColumnName("provinsi")
//                    .HasColumnType("text");

//                entity.Property(e => e.ProvinsiAyah)
//                    .HasColumnName("provinsi_ayah")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.ProvinsiIbu)
//                    .HasColumnName("provinsi_ibu")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.ProvinsiWali)
//                    .HasColumnName("provinsi_wali")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.StatusAnak)
//                    .HasColumnName("status_anak")
//                    .HasColumnType("text");

//                entity.Property(e => e.StatusAyah)
//                    .HasColumnName("status_ayah")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.StatusIbu)
//                    .HasColumnName("status_ibu")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.StatusPenaburAyah)
//                    .HasColumnName("status_penabur_ayah")
//                    .HasColumnType("text");

//                entity.Property(e => e.StatusPenaburIbu)
//                    .HasColumnName("status_penabur_ibu")
//                    .HasColumnType("text");

//                entity.Property(e => e.StatusPenaburWali)
//                    .HasColumnName("status_penabur_wali")
//                    .HasMaxLength(3)
//                    .IsUnicode(false);

//                entity.Property(e => e.StatusPernikahanAyah)
//                    .HasColumnName("status_pernikahan_ayah")
//                    .HasColumnType("text");

//                entity.Property(e => e.StatusPernikahanIbu)
//                    .HasColumnName("status_pernikahan_ibu")
//                    .HasColumnType("text");

//                entity.Property(e => e.StatusTempatTinggal)
//                    .HasColumnName("status_tempat_tinggal")
//                    .HasColumnType("text");

//                entity.Property(e => e.StatusWali)
//                    .HasColumnName("status_wali")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.Statusdalamkeluarga)
//                    .HasColumnName("statusdalamkeluarga")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.Subagama)
//                    .HasColumnName("subagama")
//                    .HasMaxLength(3)
//                    .IsUnicode(false);

//                entity.Property(e => e.SubagamaAyah)
//                    .HasColumnName("subagama_ayah")
//                    .HasMaxLength(3)
//                    .IsUnicode(false);

//                entity.Property(e => e.SubagamaIbu)
//                    .HasColumnName("subagama_ibu")
//                    .HasMaxLength(3)
//                    .IsUnicode(false);

//                entity.Property(e => e.SubagamaWali)
//                    .HasColumnName("subagama_wali")
//                    .HasMaxLength(3)
//                    .IsUnicode(false);

//                entity.Property(e => e.TanggalMeninggalAyah)
//                    .HasColumnName("tanggal_meninggal_ayah")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.TanggalMeninggalIbu)
//                    .HasColumnName("tanggal_meninggal_ibu")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.Telpon)
//                    .HasColumnName("telpon")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.TelponAyah)
//                    .HasColumnName("telpon_ayah")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.TelponIbu)
//                    .HasColumnName("telpon_ibu")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.TelponWali)
//                    .HasColumnName("telpon_wali")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.TempatIbadah)
//                    .HasColumnName("tempat_ibadah")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.TempatIbadahAyah)
//                    .HasColumnName("tempat_ibadah_ayah")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.TempatIbadahIbu)
//                    .HasColumnName("tempat_ibadah_ibu")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.TempatIbadahWali)
//                    .HasColumnName("tempat_ibadah_wali")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tgllahir)
//                    .HasColumnName("tgllahir")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.TgllahirAyah)
//                    .HasColumnName("tgllahir_ayah")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.TgllahirIbu)
//                    .HasColumnName("tgllahir_ibu")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.TgllahirWali)
//                    .HasColumnName("tgllahir_wali")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.TinggalBersama)
//                    .HasColumnName("tinggal_bersama")
//                    .HasColumnType("text");

//                entity.Property(e => e.Tmplahir)
//                    .HasColumnName("tmplahir")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.TmplahirAyah)
//                    .HasColumnName("tmplahir_ayah")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.TmplahirIbu)
//                    .HasColumnName("tmplahir_ibu")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.TmplahirWali)
//                    .HasColumnName("tmplahir_wali")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.Transportasi)
//                    .HasColumnName("transportasi")
//                    .HasColumnType("text");

//                entity.Property(e => e.TransportasiPulang)
//                    .HasColumnName("transportasi_pulang")
//                    .HasColumnType("text");

//                entity.Property(e => e.TransportasiPulangSd)
//                    .HasColumnName("transportasi_pulang_sd")
//                    .HasColumnType("text");

//                entity.Property(e => e.TransportasiPulangSmp)
//                    .HasColumnName("transportasi_pulang_smp")
//                    .HasColumnType("text");

//                entity.Property(e => e.TransportasiPulangTk)
//                    .HasColumnName("transportasi_pulang_tk")
//                    .HasColumnType("text");

//                entity.Property(e => e.TransportasiSd)
//                    .HasColumnName("transportasi_sd")
//                    .HasColumnType("text");

//                entity.Property(e => e.TransportasiSmp)
//                    .HasColumnName("transportasi_smp")
//                    .HasColumnType("text");

//                entity.Property(e => e.TransportasiTk)
//                    .HasColumnName("transportasi_tk")
//                    .HasColumnType("text");

//                entity.Property(e => e.Umur)
//                    .HasColumnName("umur")
//                    .HasColumnType("text");

//                entity.Property(e => e.WaktuTempuhSd)
//                    .HasColumnName("waktu_tempuh_sd")
//                    .HasColumnType("text");

//                entity.Property(e => e.WaktuTempuhSlta)
//                    .HasColumnName("waktu_tempuh_slta")
//                    .HasColumnType("text");

//                entity.Property(e => e.WaktuTempuhSmp)
//                    .HasColumnName("waktu_tempuh_smp")
//                    .HasColumnType("text");

//                entity.Property(e => e.WaktuTempuhTk)
//                    .HasColumnName("waktu_tempuh_tk")
//                    .HasColumnType("text");

//                entity.Property(e => e.Whatsapp)
//                    .HasColumnName("whatsapp")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.WhatsappAyah)
//                    .HasColumnName("whatsapp_ayah")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.WhatsappIbu)
//                    .HasColumnName("whatsapp_ibu")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.WhatsappWali)
//                    .HasColumnName("whatsapp_wali")
//                    .HasMaxLength(255)
//                    .IsUnicode(false);

//                entity.Property(e => e.Wn)
//                    .HasColumnName("wn")
//                    .HasColumnType("text");

//                entity.Property(e => e.WnAyah)
//                    .HasColumnName("wn_ayah")
//                    .HasMaxLength(3)
//                    .IsUnicode(false);

//                entity.Property(e => e.WnIbu)
//                    .HasColumnName("wn_ibu")
//                    .HasMaxLength(3)
//                    .IsUnicode(false);

//                entity.Property(e => e.WnWali)
//                    .HasColumnName("wn_wali")
//                    .HasMaxLength(3)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<Sekolah>(entity =>
//            {
//                entity.HasNoKey();

//                entity.HasIndex(e => new { e.SekolahId, e.JenjangPendidikanId })
//                    .HasName("NonClusteredIndex-20180718-084408");

//                entity.Property(e => e.Administrasi).HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Alamat).HasMaxLength(300);

//                entity.Property(e => e.Email).HasMaxLength(50);

//                entity.Property(e => e.JenjangPendidikanId).HasColumnName("JenjangPendidikanID");

//                entity.Property(e => e.Keuangan).HasDefaultValueSql("((0))");

//                entity.Property(e => e.KodeSekolah).HasMaxLength(50);

//                entity.Property(e => e.KotaId).HasColumnName("KotaID");

//                entity.Property(e => e.Name).HasMaxLength(50);

//                entity.Property(e => e.NoFax).HasMaxLength(50);

//                entity.Property(e => e.NoTelepon).HasMaxLength(50);

//                entity.Property(e => e.SekolahId).HasColumnName("SekolahID");
//            });

//            modelBuilder.Entity<SekolahKelas>(entity =>
//            {
//                entity.HasNoKey();

//                entity.HasIndex(e => new { e.SekolahKelasId, e.TahunAjaranId, e.SekolahId })
//                    .HasName("NonClusteredIndex-20180718-084350");

//                entity.Property(e => e.Name).HasMaxLength(50);

//                entity.Property(e => e.NominalDanaSatuTahun).HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.NominalUangSekolah).HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Pembayaran).HasMaxLength(50);

//                entity.Property(e => e.SekolahId).HasColumnName("SekolahID");

//                entity.Property(e => e.SekolahKelasId).HasColumnName("SekolahKelasID");

//                entity.Property(e => e.TahunAjaranId).HasColumnName("TahunAjaranID");
//            });

//            modelBuilder.Entity<Siswa>(entity =>
//            {
//                entity.HasNoKey();

//                entity.HasIndex(e => new { e.NoSpj, e.SekolahKelasId, e.AgamaId, e.SubAgamaId, e.KodePosId, e.GolonganDarahId })
//                    .HasName("IX_Siswa")
//                    .IsUnique();

//                entity.Property(e => e.AgamaId).HasColumnName("AgamaID");

//                entity.Property(e => e.Alamat).HasMaxLength(255);

//                entity.Property(e => e.Angkatan).HasMaxLength(255);

//                entity.Property(e => e.Email).HasMaxLength(255);

//                entity.Property(e => e.EmailPenabur).HasMaxLength(255);

//                entity.Property(e => e.GolonganDarahId).HasColumnName("GolonganDarahID");

//                entity.Property(e => e.JarakRumah).HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.JenisKelamin).HasMaxLength(255);

//                entity.Property(e => e.KodePosId).HasColumnName("KodePosID");

//                entity.Property(e => e.Name).HasMaxLength(200);

//                entity.Property(e => e.NoInduk).HasMaxLength(255);

//                entity.Property(e => e.NoMobile).HasMaxLength(255);

//                entity.Property(e => e.NoRegPsb)
//                    .HasColumnName("NoRegPSB")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NoSpj)
//                    .HasColumnName("NoSPJ")
//                    .HasMaxLength(10);

//                entity.Property(e => e.NoTelepon).HasMaxLength(255);

//                entity.Property(e => e.NoUrut).HasMaxLength(255);

//                entity.Property(e => e.PasswordDefaultEmailPenabur).HasMaxLength(255);

//                entity.Property(e => e.PengisianId).HasColumnName("PengisianID");

//                entity.Property(e => e.SekolahKelasId).HasColumnName("SekolahKelasID");

//                entity.Property(e => e.SubAgamaId).HasColumnName("SubAgamaID");

//                entity.Property(e => e.TanggalLahir).HasColumnType("datetime");

//                entity.Property(e => e.TempatLahir).HasMaxLength(255);

//                entity.Property(e => e.UrlPhoto).HasMaxLength(255);
//            });

//            modelBuilder.Entity<SubAgama>(entity =>
//            {
//                entity.HasNoKey();

//                entity.Property(e => e.AgamaId).HasColumnName("AgamaID");

//                entity.Property(e => e.Name).HasMaxLength(255);

//                entity.Property(e => e.SubAgamaId).HasColumnName("SubAgamaID");
//            });

//            modelBuilder.Entity<TahunAjaran>(entity =>
//            {
//                entity.HasNoKey();

//                entity.HasIndex(e => e.TahunAjaranId)
//                    .HasName("NonClusteredIndex-20180820-134300");

//                entity.Property(e => e.EndDate).HasColumnType("datetime");

//                entity.Property(e => e.Name).HasMaxLength(50);

//                entity.Property(e => e.StartDate).HasColumnType("datetime");

//                entity.Property(e => e.TahunAjaranId).HasColumnName("TahunAjaranID");
//            });

//            modelBuilder.Entity<TempSiswa>(entity =>
//            {
//                entity.HasNoKey();

//                entity.Property(e => e.Alamat).IsUnicode(false);

//                entity.Property(e => e.AlasanPergantianKelasId).HasColumnName("AlasanPergantianKelasID");

//                entity.Property(e => e.CaraBayarId).HasColumnName("CaraBayarID");

//                entity.Property(e => e.Email).IsUnicode(false);

//                entity.Property(e => e.IdSiswa).HasColumnName("id_siswa");

//                entity.Property(e => e.JenisKelamin)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Keterangan).IsUnicode(false);

//                entity.Property(e => e.Nama).IsUnicode(false);

//                entity.Property(e => e.NoRegPsb).HasColumnName("NoRegPSB");

//                entity.Property(e => e.NoSpj)
//                    .HasColumnName("NoSPJ")
//                    .IsUnicode(false);

//                entity.Property(e => e.NoTelepon)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Nominal).HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.PengisianId).HasColumnName("PengisianID");

//                entity.Property(e => e.PergantianKelasId).HasColumnName("PergantianKelasID");

//                entity.Property(e => e.SekolahKelasId).HasColumnName("SekolahKelasID");

//                entity.Property(e => e.SekolahKelasIdasal).HasColumnName("SekolahKelasIDAsal");

//                entity.Property(e => e.SekolahKelasIdtujuan).HasColumnName("SekolahKelasIDTujuan");

//                entity.Property(e => e.TahunAjaranId).HasColumnName("TahunAjaranID");

//                entity.Property(e => e.TanggalKeluar).HasColumnType("datetime");

//                entity.Property(e => e.TanggalLahir).HasColumnType("datetime");

//                entity.Property(e => e.TanggalMasuk).HasColumnType("datetime");

//                entity.Property(e => e.TempatLahir)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.TglEntryDibayar)
//                    .HasColumnName("tgl_entry_dibayar")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.UangSekolahId).HasColumnName("UangSekolahID");
//            });

//            modelBuilder.Entity<Trial>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("trial");

//                entity.Property(e => e.Field1)
//                    .HasColumnName("field1")
//                    .HasMaxLength(200);

//                entity.Property(e => e.Field2)
//                    .HasColumnName("field2")
//                    .HasMaxLength(200);

//                entity.Property(e => e.Field3)
//                    .HasColumnName("field3")
//                    .HasMaxLength(200);

//                entity.Property(e => e.Field4)
//                    .HasColumnName("field4")
//                    .HasMaxLength(200);

//                entity.Property(e => e.Field5)
//                    .HasColumnName("field5")
//                    .HasMaxLength(200);

//                entity.Property(e => e.Field6)
//                    .HasColumnName("field6")
//                    .HasMaxLength(200);

//                entity.Property(e => e.Field7)
//                    .HasColumnName("field7")
//                    .HasMaxLength(200);
//            });

//            modelBuilder.Entity<TunggakanAll1920>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("TUNGGAKAN_ALL_1920");

//                entity.Property(e => e.CaraBayar)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.JnsPemb)
//                    .IsRequired()
//                    .HasMaxLength(4)
//                    .IsUnicode(false);

//                entity.Property(e => e.Kelas).HasMaxLength(50);

//                entity.Property(e => e.Kodesek).HasMaxLength(10);

//                entity.Property(e => e.Lastupdate)
//                    .HasColumnName("lastupdate")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.NamaSek).HasMaxLength(50);

//                entity.Property(e => e.NamaSiswa).HasMaxLength(200);

//                entity.Property(e => e.NoInduk)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoSpj)
//                    .HasColumnName("NoSPJ")
//                    .HasMaxLength(10);

//                entity.Property(e => e.Nominal)
//                    .HasColumnName("nominal")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Nominal01)
//                    .HasColumnName("nominal01")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Nominal02)
//                    .HasColumnName("nominal02")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Nominal03)
//                    .HasColumnName("nominal03")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Nominal04)
//                    .HasColumnName("nominal04")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Nominal05)
//                    .HasColumnName("nominal05")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Nominal06)
//                    .HasColumnName("nominal06")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Nominal07)
//                    .HasColumnName("nominal07")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Nominal08)
//                    .HasColumnName("nominal08")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Nominal09)
//                    .HasColumnName("nominal09")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Nominal10)
//                    .HasColumnName("nominal10")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Nominal11)
//                    .HasColumnName("nominal11")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Nominal12)
//                    .HasColumnName("nominal12")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Tahun).HasMaxLength(50);

//                entity.Property(e => e.Tglentry01)
//                    .HasColumnName("tglentry01")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry02)
//                    .HasColumnName("tglentry02")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry03)
//                    .HasColumnName("tglentry03")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry04)
//                    .HasColumnName("tglentry04")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry05)
//                    .HasColumnName("tglentry05")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry06)
//                    .HasColumnName("tglentry06")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry07)
//                    .HasColumnName("tglentry07")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry08)
//                    .HasColumnName("tglentry08")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry09)
//                    .HasColumnName("tglentry09")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry10)
//                    .HasColumnName("tglentry10")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry11)
//                    .HasColumnName("tglentry11")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry12)
//                    .HasColumnName("tglentry12")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas01)
//                    .HasColumnName("tgllunas01")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas02)
//                    .HasColumnName("tgllunas02")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas03)
//                    .HasColumnName("tgllunas03")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas04)
//                    .HasColumnName("tgllunas04")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas05)
//                    .HasColumnName("tgllunas05")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas06)
//                    .HasColumnName("tgllunas06")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas07)
//                    .HasColumnName("tgllunas07")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas08)
//                    .HasColumnName("tgllunas08")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas09)
//                    .HasColumnName("tgllunas09")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas10)
//                    .HasColumnName("tgllunas10")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas11)
//                    .HasColumnName("tgllunas11")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas12)
//                    .HasColumnName("tgllunas12")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.UserGroup).HasMaxLength(10);
//            });

//            modelBuilder.Entity<TunggakanAll2021>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("TUNGGAKAN_ALL_2021");

//                entity.Property(e => e.CaraBayar)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.JnsPemb)
//                    .IsRequired()
//                    .HasMaxLength(4)
//                    .IsUnicode(false);

//                entity.Property(e => e.Kelas).HasMaxLength(50);

//                entity.Property(e => e.Kodesek).HasMaxLength(10);

//                entity.Property(e => e.Lastupdate)
//                    .HasColumnName("lastupdate")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.NamaSek).HasMaxLength(50);

//                entity.Property(e => e.NamaSiswa).HasMaxLength(200);

//                entity.Property(e => e.NoInduk)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoSpj)
//                    .HasColumnName("NoSPJ")
//                    .HasMaxLength(10);

//                entity.Property(e => e.Nominal)
//                    .HasColumnName("nominal")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Nominal01)
//                    .HasColumnName("nominal01")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Nominal02)
//                    .HasColumnName("nominal02")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Nominal03)
//                    .HasColumnName("nominal03")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Nominal04)
//                    .HasColumnName("nominal04")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Nominal05)
//                    .HasColumnName("nominal05")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Nominal06)
//                    .HasColumnName("nominal06")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Nominal07)
//                    .HasColumnName("nominal07")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Nominal08)
//                    .HasColumnName("nominal08")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Nominal09)
//                    .HasColumnName("nominal09")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Nominal10)
//                    .HasColumnName("nominal10")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Nominal11)
//                    .HasColumnName("nominal11")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Nominal12)
//                    .HasColumnName("nominal12")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Tahun).HasMaxLength(50);

//                entity.Property(e => e.Tglentry01)
//                    .HasColumnName("tglentry01")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry02)
//                    .HasColumnName("tglentry02")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry03)
//                    .HasColumnName("tglentry03")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry04)
//                    .HasColumnName("tglentry04")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry05)
//                    .HasColumnName("tglentry05")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry06)
//                    .HasColumnName("tglentry06")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry07)
//                    .HasColumnName("tglentry07")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry08)
//                    .HasColumnName("tglentry08")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry09)
//                    .HasColumnName("tglentry09")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry10)
//                    .HasColumnName("tglentry10")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry11)
//                    .HasColumnName("tglentry11")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry12)
//                    .HasColumnName("tglentry12")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas01)
//                    .HasColumnName("tgllunas01")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas02)
//                    .HasColumnName("tgllunas02")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas03)
//                    .HasColumnName("tgllunas03")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas04)
//                    .HasColumnName("tgllunas04")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas05)
//                    .HasColumnName("tgllunas05")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas06)
//                    .HasColumnName("tgllunas06")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas07)
//                    .HasColumnName("tgllunas07")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas08)
//                    .HasColumnName("tgllunas08")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas09)
//                    .HasColumnName("tgllunas09")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas10)
//                    .HasColumnName("tgllunas10")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas11)
//                    .HasColumnName("tgllunas11")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas12)
//                    .HasColumnName("tgllunas12")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.UserGroup).HasMaxLength(10);
//            });

//            modelBuilder.Entity<TunggakanAll2122>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("TUNGGAKAN_ALL_2122");

//                entity.Property(e => e.CaraBayar)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.JnsPemb)
//                    .IsRequired()
//                    .HasMaxLength(4)
//                    .IsUnicode(false);

//                entity.Property(e => e.Kelas).HasMaxLength(50);

//                entity.Property(e => e.Kodesek).HasMaxLength(10);

//                entity.Property(e => e.Lastupdate)
//                    .HasColumnName("lastupdate")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.NamaSek).HasMaxLength(50);

//                entity.Property(e => e.NamaSiswa).HasMaxLength(200);

//                entity.Property(e => e.NoInduk)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoSpj)
//                    .HasColumnName("NoSPJ")
//                    .HasMaxLength(10);

//                entity.Property(e => e.Nominal)
//                    .HasColumnName("nominal")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Nominal01)
//                    .HasColumnName("nominal01")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Nominal02)
//                    .HasColumnName("nominal02")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Nominal03)
//                    .HasColumnName("nominal03")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Nominal04)
//                    .HasColumnName("nominal04")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Nominal05)
//                    .HasColumnName("nominal05")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Nominal06)
//                    .HasColumnName("nominal06")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Nominal07)
//                    .HasColumnName("nominal07")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Nominal08)
//                    .HasColumnName("nominal08")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Nominal09)
//                    .HasColumnName("nominal09")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Nominal10)
//                    .HasColumnName("nominal10")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Nominal11)
//                    .HasColumnName("nominal11")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Nominal12)
//                    .HasColumnName("nominal12")
//                    .HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Tahun).HasMaxLength(50);

//                entity.Property(e => e.Tglentry01)
//                    .HasColumnName("tglentry01")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry02)
//                    .HasColumnName("tglentry02")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry03)
//                    .HasColumnName("tglentry03")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry04)
//                    .HasColumnName("tglentry04")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry05)
//                    .HasColumnName("tglentry05")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry06)
//                    .HasColumnName("tglentry06")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry07)
//                    .HasColumnName("tglentry07")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry08)
//                    .HasColumnName("tglentry08")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry09)
//                    .HasColumnName("tglentry09")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry10)
//                    .HasColumnName("tglentry10")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry11)
//                    .HasColumnName("tglentry11")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry12)
//                    .HasColumnName("tglentry12")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas01)
//                    .HasColumnName("tgllunas01")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas02)
//                    .HasColumnName("tgllunas02")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas03)
//                    .HasColumnName("tgllunas03")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas04)
//                    .HasColumnName("tgllunas04")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas05)
//                    .HasColumnName("tgllunas05")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas06)
//                    .HasColumnName("tgllunas06")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas07)
//                    .HasColumnName("tgllunas07")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas08)
//                    .HasColumnName("tgllunas08")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas09)
//                    .HasColumnName("tgllunas09")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas10)
//                    .HasColumnName("tgllunas10")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas11)
//                    .HasColumnName("tgllunas11")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas12)
//                    .HasColumnName("tgllunas12")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.UserGroup).HasMaxLength(10);
//            });

//            modelBuilder.Entity<TvSyncKeringanan>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("tv_sync_keringanan");

//                entity.Property(e => e.Approval)
//                    .HasColumnName("approval")
//                    .HasMaxLength(500)
//                    .IsUnicode(false);

//                entity.Property(e => e.BlnBerlaku)
//                    .HasColumnName("bln_berlaku")
//                    .HasMaxLength(500)
//                    .IsUnicode(false);

//                entity.Property(e => e.Id)
//                    .HasColumnName("id")
//                    .ValueGeneratedOnAdd();

//                entity.Property(e => e.IdKeringanan).HasColumnName("id_keringanan");

//                entity.Property(e => e.Nama)
//                    .HasColumnName("nama")
//                    .HasMaxLength(500)
//                    .IsUnicode(false);

//                entity.Property(e => e.Nospj)
//                    .HasColumnName("nospj")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Status)
//                    .HasColumnName("status")
//                    .HasMaxLength(500)
//                    .IsUnicode(false);

//                entity.Property(e => e.TglApproval)
//                    .HasColumnName("tgl_approval")
//                    .HasMaxLength(500)
//                    .IsUnicode(false);

//                entity.Property(e => e.UsekFinal).HasColumnName("usek_final");
//            });

//            modelBuilder.Entity<UangSekolah>(entity =>
//            {
//                entity.HasNoKey();

//                entity.HasIndex(e => new { e.NoSpj, e.SekolahKelasId })
//                    .HasName("UangSekolahConstraint")
//                    .IsUnique();

//                entity.HasIndex(e => new { e.UangSekolahId, e.SekolahKelasId, e.TahunAjaranId, e.CaraBayarId, e.PengisianId, e.NoSpj, e.CaraBayarDanaSatuTahunId, e.DanaSatuTahunBankId })
//                    .HasName("NonClusteredIndex-20180718-084324");

//                entity.Property(e => e.CaraBayarDanaSatuTahunId).HasColumnName("CaraBayarDanaSatuTahunID");

//                entity.Property(e => e.CaraBayarId).HasColumnName("CaraBayarID");

//                entity.Property(e => e.DanaSatuTahunBankId).HasColumnName("DanaSatuTahunBankID");

//                entity.Property(e => e.EditUserId).HasColumnName("EditUserID");

//                entity.Property(e => e.NoSpj)
//                    .HasColumnName("NoSPJ")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Nominal).HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.NominalDanaSatuTahun).HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Pembayaran).HasMaxLength(50);

//                entity.Property(e => e.PengisianId).HasColumnName("PengisianID");

//                entity.Property(e => e.SekolahKelasId).HasColumnName("SekolahKelasID");

//                entity.Property(e => e.TahunAjaranId).HasColumnName("TahunAjaranID");

//                entity.Property(e => e.TanggalEdit).HasColumnType("datetime");

//                entity.Property(e => e.UangSekolahBankId).HasColumnName("UangSekolahBankID");

//                entity.Property(e => e.UangSekolahId).HasColumnName("UangSekolahID");
//            });

//            modelBuilder.Entity<UangSekolahLog>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToTable("UangSekolah_Log");

//                entity.Property(e => e.CaraBayarDanaSatuTahunId).HasColumnName("CaraBayarDanaSatuTahunID");

//                entity.Property(e => e.CaraBayarId).HasColumnName("CaraBayarID");

//                entity.Property(e => e.DanaSatuTahunBankId).HasColumnName("DanaSatuTahunBankID");

//                entity.Property(e => e.EditUserId).HasColumnName("EditUserID");

//                entity.Property(e => e.NoSpj)
//                    .HasColumnName("NoSPJ")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Nominal).HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.NominalDanaSatuTahun).HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Pembayaran).HasMaxLength(50);

//                entity.Property(e => e.PengisianId).HasColumnName("PengisianID");

//                entity.Property(e => e.SekolahKelasId).HasColumnName("SekolahKelasID");

//                entity.Property(e => e.TahunAjaranId).HasColumnName("TahunAjaranID");

//                entity.Property(e => e.TanggalEdit).HasColumnType("datetime");

//                entity.Property(e => e.UangSekolahBankId).HasColumnName("UangSekolahBankID");

//                entity.Property(e => e.UangSekolahId).HasColumnName("UangSekolahID");
//            });

//            modelBuilder.Entity<User>(entity =>
//            {
//                entity.HasNoKey();

//                entity.HasIndex(e => e.UserId)
//                    .HasName("UQ__tmp_ms_x__1788CCAD9C158E87")
//                    .IsUnique();

//                entity.HasIndex(e => e.UserName)
//                    .HasName("UQ__tmp_ms_x__C9F28456182DFBF5")
//                    .IsUnique();

//                entity.Property(e => e.Name).HasMaxLength(50);

//                entity.Property(e => e.Nik)
//                    .HasColumnName("NIK")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Password)
//                    .IsRequired()
//                    .HasMaxLength(255);

//                entity.Property(e => e.RefreshToken).HasMaxLength(255);

//                entity.Property(e => e.RefreshTokenExpiryTime).HasColumnType("datetime");

//                entity.Property(e => e.RoleId).HasColumnName("RoleID");

//                entity.Property(e => e.UserId).HasColumnName("UserID");

//                entity.Property(e => e.UserName)
//                    .IsRequired()
//                    .HasMaxLength(50);
//            });

//            modelBuilder.Entity<ViewAlumniSma>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("View_ALUMNI_SMA");

//                entity.Property(e => e.Angkatan)
//                    .HasColumnName("angkatan")
//                    .HasMaxLength(50);

//                entity.Property(e => e.DateTime)
//                    .HasColumnName("date_time")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Jurusan)
//                    .HasColumnName("jurusan")
//                    .HasMaxLength(3);

//                entity.Property(e => e.Kelas).HasMaxLength(50);

//                entity.Property(e => e.NamaSiswa)
//                    .HasColumnName("nama_siswa")
//                    .HasMaxLength(200);

//                entity.Property(e => e.Sekolah)
//                    .HasColumnName("sekolah")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Spj)
//                    .HasColumnName("spj")
//                    .HasMaxLength(10);
//            });

//            modelBuilder.Entity<ViewDanaAll>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("View_DANA_ALL");

//                entity.Property(e => e.Cicilan1)
//                    .HasMaxLength(64)
//                    .IsUnicode(false);

//                entity.Property(e => e.Cicilan2)
//                    .HasMaxLength(64)
//                    .IsUnicode(false);

//                entity.Property(e => e.Cicilan3)
//                    .HasMaxLength(64)
//                    .IsUnicode(false);

//                entity.Property(e => e.JnsPemb)
//                    .IsRequired()
//                    .HasMaxLength(4)
//                    .IsUnicode(false);

//                entity.Property(e => e.Kelas).HasMaxLength(50);

//                entity.Property(e => e.Kodesek).HasMaxLength(50);

//                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

//                entity.Property(e => e.NamaSek).HasMaxLength(50);

//                entity.Property(e => e.Namasiswa)
//                    .HasColumnName("namasiswa")
//                    .HasMaxLength(200);

//                entity.Property(e => e.NoSpj)
//                    .HasColumnName("NoSPJ")
//                    .HasMaxLength(10);

//                entity.Property(e => e.Tahun).HasMaxLength(50);
//            });

//            modelBuilder.Entity<ViewMasterSiswa>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("View_Master_Siswa");

//                entity.Property(e => e.Agama).HasMaxLength(50);

//                entity.Property(e => e.AlamatSiswa).HasMaxLength(255);

//                entity.Property(e => e.Alumni)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.EmailAyah)
//                    .HasColumnName("email_ayah")
//                    .HasMaxLength(50);

//                entity.Property(e => e.EmailIbu)
//                    .HasColumnName("email_ibu")
//                    .HasMaxLength(50);

//                entity.Property(e => e.GolDarah).HasMaxLength(50);

//                entity.Property(e => e.Hp).HasMaxLength(255);

//                entity.Property(e => e.IdGki)
//                    .IsRequired()
//                    .HasColumnName("IdGKI")
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.JenKel).HasMaxLength(255);

//                entity.Property(e => e.Kelas).HasMaxLength(50);

//                entity.Property(e => e.Kode)
//                    .HasColumnName("kode")
//                    .HasMaxLength(10);

//                entity.Property(e => e.KodePos).HasMaxLength(50);

//                entity.Property(e => e.KodePosAyah)
//                    .HasColumnName("kode_pos_ayah")
//                    .HasMaxLength(50);

//                entity.Property(e => e.KodeSek).HasMaxLength(10);

//                entity.Property(e => e.Kota).HasMaxLength(50);

//                entity.Property(e => e.KotaAyah)
//                    .HasColumnName("kota_ayah")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NamaAyah).HasMaxLength(50);

//                entity.Property(e => e.NamaIbu).HasMaxLength(50);

//                entity.Property(e => e.NamaSiswa).HasMaxLength(200);

//                entity.Property(e => e.NamaWali).HasMaxLength(50);

//                entity.Property(e => e.NoHp)
//                    .HasColumnName("no_hp")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NoHpIbu)
//                    .HasColumnName("no_hp_ibu")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NoInduk)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoTelp)
//                    .HasColumnName("no_telp")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Noregpsb)
//                    .HasColumnName("noregpsb")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Nospj)
//                    .HasColumnName("nospj")
//                    .HasMaxLength(10);

//                entity.Property(e => e.PekerjaanAyah)
//                    .IsRequired()
//                    .HasColumnName("pekerjaan_ayah")
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.SubAgama).HasMaxLength(255);

//                entity.Property(e => e.TanggalMasuk).HasColumnType("datetime");

//                entity.Property(e => e.Telpon).HasMaxLength(255);

//                entity.Property(e => e.TglAkhirStudi).HasColumnType("datetime");

//                entity.Property(e => e.TglLahir).HasColumnType("datetime");

//                entity.Property(e => e.TmpLahir).HasMaxLength(255);
//            });

//            modelBuilder.Entity<ViewMasterSiswa1920>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("View_Master_Siswa_1920");

//                entity.Property(e => e.Agama).HasMaxLength(50);

//                entity.Property(e => e.AlamatSiswa).HasMaxLength(255);

//                entity.Property(e => e.Alumni)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.EmailAyah)
//                    .HasColumnName("email_ayah")
//                    .HasMaxLength(50);

//                entity.Property(e => e.EmailIbu)
//                    .HasColumnName("email_ibu")
//                    .HasMaxLength(50);

//                entity.Property(e => e.GolDarah).HasMaxLength(50);

//                entity.Property(e => e.Hp).HasMaxLength(255);

//                entity.Property(e => e.IdGki)
//                    .IsRequired()
//                    .HasColumnName("IdGKI")
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.JenKel).HasMaxLength(255);

//                entity.Property(e => e.Kelas).HasMaxLength(50);

//                entity.Property(e => e.Kode)
//                    .HasColumnName("kode")
//                    .HasMaxLength(10);

//                entity.Property(e => e.KodePos).HasMaxLength(50);

//                entity.Property(e => e.KodePosAyah)
//                    .HasColumnName("kode_pos_ayah")
//                    .HasMaxLength(50);

//                entity.Property(e => e.KodeSek).HasMaxLength(10);

//                entity.Property(e => e.Kota).HasMaxLength(50);

//                entity.Property(e => e.KotaAyah)
//                    .HasColumnName("kota_ayah")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NamaAyah).HasMaxLength(50);

//                entity.Property(e => e.NamaIbu).HasMaxLength(50);

//                entity.Property(e => e.NamaSiswa).HasMaxLength(200);

//                entity.Property(e => e.NamaWali).HasMaxLength(50);

//                entity.Property(e => e.NoHp)
//                    .HasColumnName("no_hp")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NoHpIbu)
//                    .HasColumnName("no_hp_ibu")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NoInduk)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoTelp)
//                    .HasColumnName("no_telp")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Noregpsb)
//                    .HasColumnName("noregpsb")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Nospj)
//                    .HasColumnName("nospj")
//                    .HasMaxLength(10);

//                entity.Property(e => e.PekerjaanAyah)
//                    .IsRequired()
//                    .HasColumnName("pekerjaan_ayah")
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.SubAgama).HasMaxLength(255);

//                entity.Property(e => e.TanggalMasuk).HasColumnType("datetime");

//                entity.Property(e => e.Telpon).HasMaxLength(255);

//                entity.Property(e => e.TglAkhirStudi).HasColumnType("datetime");

//                entity.Property(e => e.TglLahir).HasColumnType("datetime");

//                entity.Property(e => e.TmpLahir).HasMaxLength(255);
//            });

//            modelBuilder.Entity<ViewMasterSiswa1920Pusat>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("View_Master_Siswa_1920_Pusat");

//                entity.Property(e => e.Agama).HasMaxLength(50);

//                entity.Property(e => e.AlamatSiswa).HasMaxLength(255);

//                entity.Property(e => e.Alumni)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.EmailAyah)
//                    .HasColumnName("email_ayah")
//                    .HasMaxLength(50);

//                entity.Property(e => e.EmailIbu)
//                    .HasColumnName("email_ibu")
//                    .HasMaxLength(50);

//                entity.Property(e => e.GolDarah).HasMaxLength(50);

//                entity.Property(e => e.Hp).HasMaxLength(255);

//                entity.Property(e => e.IdGki)
//                    .IsRequired()
//                    .HasColumnName("IdGKI")
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.JenKel).HasMaxLength(255);

//                entity.Property(e => e.Kelas).HasMaxLength(50);

//                entity.Property(e => e.Kode)
//                    .HasColumnName("kode")
//                    .HasMaxLength(10);

//                entity.Property(e => e.KodePos).HasMaxLength(50);

//                entity.Property(e => e.KodePosAyah)
//                    .HasColumnName("kode_pos_ayah")
//                    .HasMaxLength(50);

//                entity.Property(e => e.KodeSek).HasMaxLength(10);

//                entity.Property(e => e.Kota).HasMaxLength(50);

//                entity.Property(e => e.KotaAyah)
//                    .HasColumnName("kota_ayah")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NamaAyah).HasMaxLength(50);

//                entity.Property(e => e.NamaIbu).HasMaxLength(50);

//                entity.Property(e => e.NamaSiswa).HasMaxLength(200);

//                entity.Property(e => e.NamaWali).HasMaxLength(50);

//                entity.Property(e => e.NoHp)
//                    .HasColumnName("no_hp")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NoHpIbu)
//                    .HasColumnName("no_hp_ibu")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NoInduk)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoTelp)
//                    .HasColumnName("no_telp")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Noregpsb)
//                    .HasColumnName("noregpsb")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Nospj)
//                    .HasColumnName("nospj")
//                    .HasMaxLength(10);

//                entity.Property(e => e.PekerjaanAyah)
//                    .IsRequired()
//                    .HasColumnName("pekerjaan_ayah")
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.SubAgama).HasMaxLength(255);

//                entity.Property(e => e.TanggalMasuk).HasColumnType("datetime");

//                entity.Property(e => e.Telpon).HasMaxLength(255);

//                entity.Property(e => e.TglAkhirStudi).HasColumnType("datetime");

//                entity.Property(e => e.TglLahir).HasColumnType("datetime");

//                entity.Property(e => e.TmpLahir).HasMaxLength(255);
//            });

//            modelBuilder.Entity<ViewMasterSiswa1920Tm>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("View_Master_Siswa_1920_TM");

//                entity.Property(e => e.Agama).HasMaxLength(50);

//                entity.Property(e => e.AlamatSiswa).HasMaxLength(255);

//                entity.Property(e => e.Alumni)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.EmailAyah)
//                    .HasColumnName("email_ayah")
//                    .HasMaxLength(50);

//                entity.Property(e => e.EmailIbu)
//                    .HasColumnName("email_ibu")
//                    .HasMaxLength(50);

//                entity.Property(e => e.GolDarah).HasMaxLength(50);

//                entity.Property(e => e.Hp).HasMaxLength(255);

//                entity.Property(e => e.IdGki)
//                    .IsRequired()
//                    .HasColumnName("IdGKI")
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.JenKel).HasMaxLength(255);

//                entity.Property(e => e.Kelas).HasMaxLength(50);

//                entity.Property(e => e.Kode)
//                    .HasColumnName("kode")
//                    .HasMaxLength(10);

//                entity.Property(e => e.KodePos).HasMaxLength(50);

//                entity.Property(e => e.KodePosAyah)
//                    .HasColumnName("kode_pos_ayah")
//                    .HasMaxLength(50);

//                entity.Property(e => e.KodeSek).HasMaxLength(10);

//                entity.Property(e => e.Kota).HasMaxLength(50);

//                entity.Property(e => e.KotaAyah)
//                    .HasColumnName("kota_ayah")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NamaAyah).HasMaxLength(50);

//                entity.Property(e => e.NamaIbu).HasMaxLength(50);

//                entity.Property(e => e.NamaSiswa).HasMaxLength(200);

//                entity.Property(e => e.NamaWali).HasMaxLength(50);

//                entity.Property(e => e.NoHp)
//                    .HasColumnName("no_hp")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NoHpIbu)
//                    .HasColumnName("no_hp_ibu")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NoInduk)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoTelp)
//                    .HasColumnName("no_telp")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Noregpsb)
//                    .HasColumnName("noregpsb")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Nospj)
//                    .HasColumnName("nospj")
//                    .HasMaxLength(10);

//                entity.Property(e => e.PekerjaanAyah)
//                    .IsRequired()
//                    .HasColumnName("pekerjaan_ayah")
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.SubAgama).HasMaxLength(255);

//                entity.Property(e => e.TanggalMasuk).HasColumnType("datetime");

//                entity.Property(e => e.Telpon).HasMaxLength(255);

//                entity.Property(e => e.TglAkhirStudi).HasColumnType("datetime");

//                entity.Property(e => e.TglLahir).HasColumnType("datetime");

//                entity.Property(e => e.TmpLahir).HasMaxLength(255);
//            });

//            modelBuilder.Entity<ViewMasterSiswa2021>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("View_Master_Siswa_2021");

//                entity.Property(e => e.Agama).HasMaxLength(50);

//                entity.Property(e => e.AlamatSiswa).HasMaxLength(255);

//                entity.Property(e => e.Alumni)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.EmailAyah)
//                    .HasColumnName("email_ayah")
//                    .HasMaxLength(50);

//                entity.Property(e => e.EmailIbu)
//                    .HasColumnName("email_ibu")
//                    .HasMaxLength(50);

//                entity.Property(e => e.GolDarah).HasMaxLength(50);

//                entity.Property(e => e.Hp).HasMaxLength(255);

//                entity.Property(e => e.IdGki)
//                    .IsRequired()
//                    .HasColumnName("IdGKI")
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.JenKel).HasMaxLength(255);

//                entity.Property(e => e.Kelas).HasMaxLength(50);

//                entity.Property(e => e.Kode)
//                    .HasColumnName("kode")
//                    .HasMaxLength(10);

//                entity.Property(e => e.KodePos).HasMaxLength(50);

//                entity.Property(e => e.KodePosAyah)
//                    .HasColumnName("kode_pos_ayah")
//                    .HasMaxLength(50);

//                entity.Property(e => e.KodeSek).HasMaxLength(10);

//                entity.Property(e => e.Kota).HasMaxLength(50);

//                entity.Property(e => e.KotaAyah)
//                    .HasColumnName("kota_ayah")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NamaAyah).HasMaxLength(50);

//                entity.Property(e => e.NamaIbu).HasMaxLength(50);

//                entity.Property(e => e.NamaSiswa).HasMaxLength(200);

//                entity.Property(e => e.NamaWali).HasMaxLength(50);

//                entity.Property(e => e.NoHp)
//                    .HasColumnName("no_hp")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NoHpIbu)
//                    .HasColumnName("no_hp_ibu")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NoInduk)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoTelp)
//                    .HasColumnName("no_telp")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Noregpsb)
//                    .HasColumnName("noregpsb")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Nospj)
//                    .HasColumnName("nospj")
//                    .HasMaxLength(10);

//                entity.Property(e => e.PekerjaanAyah)
//                    .IsRequired()
//                    .HasColumnName("pekerjaan_ayah")
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.SubAgama).HasMaxLength(255);

//                entity.Property(e => e.TanggalMasuk).HasColumnType("datetime");

//                entity.Property(e => e.Telpon).HasMaxLength(255);

//                entity.Property(e => e.TglAkhirStudi).HasColumnType("datetime");

//                entity.Property(e => e.TglLahir).HasColumnType("datetime");

//                entity.Property(e => e.TmpLahir).HasMaxLength(255);
//            });

//            modelBuilder.Entity<ViewMasterSiswa2021Pusat>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("View_Master_Siswa_2021_Pusat");

//                entity.Property(e => e.Agama).HasMaxLength(50);

//                entity.Property(e => e.AlamatSiswa).HasMaxLength(255);

//                entity.Property(e => e.Alumni)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.EmailAyah)
//                    .HasColumnName("email_ayah")
//                    .HasMaxLength(50);

//                entity.Property(e => e.EmailIbu)
//                    .HasColumnName("email_ibu")
//                    .HasMaxLength(50);

//                entity.Property(e => e.GolDarah).HasMaxLength(50);

//                entity.Property(e => e.Hp).HasMaxLength(255);

//                entity.Property(e => e.IdGki)
//                    .IsRequired()
//                    .HasColumnName("IdGKI")
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.JenKel).HasMaxLength(255);

//                entity.Property(e => e.Kelas).HasMaxLength(50);

//                entity.Property(e => e.Kode)
//                    .HasColumnName("kode")
//                    .HasMaxLength(10);

//                entity.Property(e => e.KodePos).HasMaxLength(50);

//                entity.Property(e => e.KodePosAyah)
//                    .HasColumnName("kode_pos_ayah")
//                    .HasMaxLength(50);

//                entity.Property(e => e.KodeSek).HasMaxLength(10);

//                entity.Property(e => e.Kota).HasMaxLength(50);

//                entity.Property(e => e.KotaAyah)
//                    .HasColumnName("kota_ayah")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NamaAyah).HasMaxLength(50);

//                entity.Property(e => e.NamaIbu).HasMaxLength(50);

//                entity.Property(e => e.NamaSiswa).HasMaxLength(200);

//                entity.Property(e => e.NamaWali).HasMaxLength(50);

//                entity.Property(e => e.NoHp)
//                    .HasColumnName("no_hp")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NoHpIbu)
//                    .HasColumnName("no_hp_ibu")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NoInduk)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoTelp)
//                    .HasColumnName("no_telp")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Noregpsb)
//                    .HasColumnName("noregpsb")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Nospj)
//                    .HasColumnName("nospj")
//                    .HasMaxLength(10);

//                entity.Property(e => e.PekerjaanAyah)
//                    .IsRequired()
//                    .HasColumnName("pekerjaan_ayah")
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.SubAgama).HasMaxLength(255);

//                entity.Property(e => e.TanggalMasuk).HasColumnType("datetime");

//                entity.Property(e => e.Telpon).HasMaxLength(255);

//                entity.Property(e => e.TglAkhirStudi).HasColumnType("datetime");

//                entity.Property(e => e.TglLahir).HasColumnType("datetime");

//                entity.Property(e => e.TmpLahir).HasMaxLength(255);
//            });

//            modelBuilder.Entity<ViewMasterSiswa2021Tm>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("View_Master_Siswa_2021_TM");

//                entity.Property(e => e.Agama).HasMaxLength(50);

//                entity.Property(e => e.AlamatSiswa).HasMaxLength(255);

//                entity.Property(e => e.Alumni)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.EmailAyah)
//                    .HasColumnName("email_ayah")
//                    .HasMaxLength(50);

//                entity.Property(e => e.EmailIbu)
//                    .HasColumnName("email_ibu")
//                    .HasMaxLength(50);

//                entity.Property(e => e.GolDarah).HasMaxLength(50);

//                entity.Property(e => e.Hp).HasMaxLength(255);

//                entity.Property(e => e.IdGki)
//                    .IsRequired()
//                    .HasColumnName("IdGKI")
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.JenKel).HasMaxLength(255);

//                entity.Property(e => e.Kelas).HasMaxLength(50);

//                entity.Property(e => e.Kode)
//                    .HasColumnName("kode")
//                    .HasMaxLength(10);

//                entity.Property(e => e.KodePos).HasMaxLength(50);

//                entity.Property(e => e.KodePosAyah)
//                    .HasColumnName("kode_pos_ayah")
//                    .HasMaxLength(50);

//                entity.Property(e => e.KodeSek).HasMaxLength(10);

//                entity.Property(e => e.Kota).HasMaxLength(50);

//                entity.Property(e => e.KotaAyah)
//                    .HasColumnName("kota_ayah")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NamaAyah).HasMaxLength(50);

//                entity.Property(e => e.NamaIbu).HasMaxLength(50);

//                entity.Property(e => e.NamaSiswa).HasMaxLength(200);

//                entity.Property(e => e.NamaWali).HasMaxLength(50);

//                entity.Property(e => e.NoHp)
//                    .HasColumnName("no_hp")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NoHpIbu)
//                    .HasColumnName("no_hp_ibu")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NoInduk)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoTelp)
//                    .HasColumnName("no_telp")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Noregpsb)
//                    .HasColumnName("noregpsb")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Nospj)
//                    .HasColumnName("nospj")
//                    .HasMaxLength(10);

//                entity.Property(e => e.PekerjaanAyah)
//                    .IsRequired()
//                    .HasColumnName("pekerjaan_ayah")
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.SubAgama).HasMaxLength(255);

//                entity.Property(e => e.TanggalMasuk).HasColumnType("datetime");

//                entity.Property(e => e.Telpon).HasMaxLength(255);

//                entity.Property(e => e.TglAkhirStudi).HasColumnType("datetime");

//                entity.Property(e => e.TglLahir).HasColumnType("datetime");

//                entity.Property(e => e.TmpLahir).HasMaxLength(255);
//            });

//            modelBuilder.Entity<ViewMasterSiswa2122>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("View_Master_Siswa_2122");

//                entity.Property(e => e.Agama).HasMaxLength(50);

//                entity.Property(e => e.AlamatSiswa).HasMaxLength(255);

//                entity.Property(e => e.Alumni)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.EmailAyah)
//                    .HasColumnName("email_ayah")
//                    .HasMaxLength(50);

//                entity.Property(e => e.EmailIbu)
//                    .HasColumnName("email_ibu")
//                    .HasMaxLength(50);

//                entity.Property(e => e.GolDarah).HasMaxLength(50);

//                entity.Property(e => e.Hp).HasMaxLength(255);

//                entity.Property(e => e.IdGki)
//                    .IsRequired()
//                    .HasColumnName("IdGKI")
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.JenKel).HasMaxLength(255);

//                entity.Property(e => e.Kelas).HasMaxLength(50);

//                entity.Property(e => e.Kode)
//                    .HasColumnName("kode")
//                    .HasMaxLength(10);

//                entity.Property(e => e.KodePos).HasMaxLength(50);

//                entity.Property(e => e.KodePosAyah)
//                    .HasColumnName("kode_pos_ayah")
//                    .HasMaxLength(50);

//                entity.Property(e => e.KodeSek).HasMaxLength(10);

//                entity.Property(e => e.Kota).HasMaxLength(50);

//                entity.Property(e => e.KotaAyah)
//                    .HasColumnName("kota_ayah")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NamaAyah).HasMaxLength(50);

//                entity.Property(e => e.NamaIbu).HasMaxLength(50);

//                entity.Property(e => e.NamaSiswa).HasMaxLength(200);

//                entity.Property(e => e.NamaWali).HasMaxLength(50);

//                entity.Property(e => e.NoHp)
//                    .HasColumnName("no_hp")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NoHpIbu)
//                    .HasColumnName("no_hp_ibu")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NoInduk)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoTelp)
//                    .HasColumnName("no_telp")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Noregpsb)
//                    .HasColumnName("noregpsb")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Nospj)
//                    .HasColumnName("nospj")
//                    .HasMaxLength(10);

//                entity.Property(e => e.PekerjaanAyah)
//                    .IsRequired()
//                    .HasColumnName("pekerjaan_ayah")
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.SubAgama).HasMaxLength(255);

//                entity.Property(e => e.TanggalMasuk).HasColumnType("datetime");

//                entity.Property(e => e.Telpon).HasMaxLength(255);

//                entity.Property(e => e.TglAkhirStudi).HasColumnType("datetime");

//                entity.Property(e => e.TglLahir).HasColumnType("datetime");

//                entity.Property(e => e.TmpLahir).HasMaxLength(255);
//            });

//            modelBuilder.Entity<ViewMasterSiswa2122Pusat>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("View_Master_Siswa_2122_Pusat");

//                entity.Property(e => e.Agama).HasMaxLength(50);

//                entity.Property(e => e.AlamatSiswa).HasMaxLength(255);

//                entity.Property(e => e.Alumni)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.EmailAyah)
//                    .HasColumnName("email_ayah")
//                    .HasMaxLength(50);

//                entity.Property(e => e.EmailIbu)
//                    .HasColumnName("email_ibu")
//                    .HasMaxLength(50);

//                entity.Property(e => e.GolDarah).HasMaxLength(50);

//                entity.Property(e => e.Hp).HasMaxLength(255);

//                entity.Property(e => e.IdGki)
//                    .IsRequired()
//                    .HasColumnName("IdGKI")
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.JenKel).HasMaxLength(255);

//                entity.Property(e => e.Kelas).HasMaxLength(50);

//                entity.Property(e => e.Kode)
//                    .HasColumnName("kode")
//                    .HasMaxLength(10);

//                entity.Property(e => e.KodePos).HasMaxLength(50);

//                entity.Property(e => e.KodePosAyah)
//                    .HasColumnName("kode_pos_ayah")
//                    .HasMaxLength(50);

//                entity.Property(e => e.KodeSek).HasMaxLength(10);

//                entity.Property(e => e.Kota).HasMaxLength(50);

//                entity.Property(e => e.KotaAyah)
//                    .HasColumnName("kota_ayah")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NamaAyah).HasMaxLength(50);

//                entity.Property(e => e.NamaIbu).HasMaxLength(50);

//                entity.Property(e => e.NamaSiswa).HasMaxLength(200);

//                entity.Property(e => e.NamaWali).HasMaxLength(50);

//                entity.Property(e => e.NoHp)
//                    .HasColumnName("no_hp")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NoHpIbu)
//                    .HasColumnName("no_hp_ibu")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NoInduk)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoTelp)
//                    .HasColumnName("no_telp")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Noregpsb)
//                    .HasColumnName("noregpsb")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Nospj)
//                    .HasColumnName("nospj")
//                    .HasMaxLength(10);

//                entity.Property(e => e.PekerjaanAyah)
//                    .IsRequired()
//                    .HasColumnName("pekerjaan_ayah")
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.SubAgama).HasMaxLength(255);

//                entity.Property(e => e.TanggalMasuk).HasColumnType("datetime");

//                entity.Property(e => e.Telpon).HasMaxLength(255);

//                entity.Property(e => e.TglAkhirStudi).HasColumnType("datetime");

//                entity.Property(e => e.TglLahir).HasColumnType("datetime");

//                entity.Property(e => e.TmpLahir).HasMaxLength(255);
//            });

//            modelBuilder.Entity<ViewMasterSiswa2122Tm>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("View_Master_Siswa_2122_TM");

//                entity.Property(e => e.Agama).HasMaxLength(50);

//                entity.Property(e => e.AlamatSiswa).HasMaxLength(255);

//                entity.Property(e => e.Alumni)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.EmailAyah)
//                    .HasColumnName("email_ayah")
//                    .HasMaxLength(50);

//                entity.Property(e => e.EmailIbu)
//                    .HasColumnName("email_ibu")
//                    .HasMaxLength(50);

//                entity.Property(e => e.GolDarah).HasMaxLength(50);

//                entity.Property(e => e.Hp).HasMaxLength(255);

//                entity.Property(e => e.IdGki)
//                    .IsRequired()
//                    .HasColumnName("IdGKI")
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.JenKel).HasMaxLength(255);

//                entity.Property(e => e.Kelas).HasMaxLength(50);

//                entity.Property(e => e.Kode)
//                    .HasColumnName("kode")
//                    .HasMaxLength(10);

//                entity.Property(e => e.KodePos).HasMaxLength(50);

//                entity.Property(e => e.KodePosAyah)
//                    .HasColumnName("kode_pos_ayah")
//                    .HasMaxLength(50);

//                entity.Property(e => e.KodeSek).HasMaxLength(10);

//                entity.Property(e => e.Kota).HasMaxLength(50);

//                entity.Property(e => e.KotaAyah)
//                    .HasColumnName("kota_ayah")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NamaAyah).HasMaxLength(50);

//                entity.Property(e => e.NamaIbu).HasMaxLength(50);

//                entity.Property(e => e.NamaSiswa).HasMaxLength(200);

//                entity.Property(e => e.NamaWali).HasMaxLength(50);

//                entity.Property(e => e.NoHp)
//                    .HasColumnName("no_hp")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NoHpIbu)
//                    .HasColumnName("no_hp_ibu")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NoInduk)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoTelp)
//                    .HasColumnName("no_telp")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Noregpsb)
//                    .HasColumnName("noregpsb")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Nospj)
//                    .HasColumnName("nospj")
//                    .HasMaxLength(10);

//                entity.Property(e => e.PekerjaanAyah)
//                    .IsRequired()
//                    .HasColumnName("pekerjaan_ayah")
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.SubAgama).HasMaxLength(255);

//                entity.Property(e => e.TanggalMasuk).HasColumnType("datetime");

//                entity.Property(e => e.Telpon).HasMaxLength(255);

//                entity.Property(e => e.TglAkhirStudi).HasColumnType("datetime");

//                entity.Property(e => e.TglLahir).HasColumnType("datetime");

//                entity.Property(e => e.TmpLahir).HasMaxLength(255);
//            });

//            modelBuilder.Entity<ViewMasterSiswaNew>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("View_Master_Siswa_New");

//                entity.Property(e => e.Agama).HasMaxLength(50);

//                entity.Property(e => e.AlamatSiswa).HasMaxLength(255);

//                entity.Property(e => e.Alumni)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.EmailAyah)
//                    .HasColumnName("email_ayah")
//                    .HasMaxLength(50);

//                entity.Property(e => e.EmailIbu)
//                    .HasColumnName("email_ibu")
//                    .HasMaxLength(50);

//                entity.Property(e => e.GolDarah).HasMaxLength(50);

//                entity.Property(e => e.Hp).HasMaxLength(255);

//                entity.Property(e => e.IdGki)
//                    .IsRequired()
//                    .HasColumnName("IdGKI")
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.JenKel).HasMaxLength(255);

//                entity.Property(e => e.Kelas).HasMaxLength(50);

//                entity.Property(e => e.Kode).HasMaxLength(10);

//                entity.Property(e => e.KodePos).HasMaxLength(50);

//                entity.Property(e => e.KodePosAyah)
//                    .HasColumnName("kode_pos_ayah")
//                    .HasMaxLength(50);

//                entity.Property(e => e.KodeSek).HasMaxLength(10);

//                entity.Property(e => e.Kota).HasMaxLength(50);

//                entity.Property(e => e.KotaAyah)
//                    .HasColumnName("kota_ayah")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NamaAyah).HasMaxLength(50);

//                entity.Property(e => e.NamaIbu).HasMaxLength(50);

//                entity.Property(e => e.NamaSiswa).HasMaxLength(200);

//                entity.Property(e => e.NamaWali).HasMaxLength(50);

//                entity.Property(e => e.NoHp)
//                    .HasColumnName("no_hp")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NoHpIbu)
//                    .HasColumnName("no_hp_ibu")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NoInduk)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoRegPsb)
//                    .HasColumnName("NoRegPSB")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NoSpj)
//                    .HasColumnName("NoSPJ")
//                    .HasMaxLength(10);

//                entity.Property(e => e.NoTelp)
//                    .HasColumnName("no_telp")
//                    .HasMaxLength(50);

//                entity.Property(e => e.PekerjaanAyah)
//                    .IsRequired()
//                    .HasColumnName("pekerjaan_ayah")
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.SubAgama).HasMaxLength(255);

//                entity.Property(e => e.Telpon).HasMaxLength(255);

//                entity.Property(e => e.TglAkhirStudi).HasColumnType("datetime");

//                entity.Property(e => e.TglLahir).HasColumnType("datetime");

//                entity.Property(e => e.TmpLahir).HasMaxLength(255);
//            });

//            modelBuilder.Entity<ViewSekolahKelasAll>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("View_Sekolah_Kelas_All");

//                entity.Property(e => e.KodeSekolah).HasMaxLength(50);

//                entity.Property(e => e.Name).HasMaxLength(50);

//                entity.Property(e => e.TahunAjar).HasMaxLength(50);
//            });

//            modelBuilder.Entity<ViewSekolahKelasAll1920>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("View_Sekolah_Kelas_All_1920");

//                entity.Property(e => e.KodeSekolah).HasMaxLength(50);

//                entity.Property(e => e.Name).HasMaxLength(50);

//                entity.Property(e => e.TahunAjar).HasMaxLength(50);
//            });

//            modelBuilder.Entity<ViewSekolahKelasAll2021>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("View_Sekolah_Kelas_All_2021");

//                entity.Property(e => e.KodeSekolah).HasMaxLength(50);

//                entity.Property(e => e.Name).HasMaxLength(50);

//                entity.Property(e => e.TahunAjar).HasMaxLength(50);
//            });

//            modelBuilder.Entity<ViewSekolahKelasAll2122>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("View_Sekolah_Kelas_All_2122");

//                entity.Property(e => e.KodeSekolah).HasMaxLength(50);

//                entity.Property(e => e.Name).HasMaxLength(50);

//                entity.Property(e => e.TahunAjar).HasMaxLength(50);
//            });

//            modelBuilder.Entity<ViewTunggakanAll>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("View_TUNGGAKAN_ALL");

//                entity.Property(e => e.CaraBayar)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.JnsPemb)
//                    .IsRequired()
//                    .HasMaxLength(4)
//                    .IsUnicode(false);

//                entity.Property(e => e.Kelas).HasMaxLength(50);

//                entity.Property(e => e.Kodesek).HasMaxLength(10);

//                entity.Property(e => e.Lastupdate)
//                    .HasColumnName("lastupdate")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.NamaSek).HasMaxLength(50);

//                entity.Property(e => e.NamaSiswa).HasMaxLength(200);

//                entity.Property(e => e.NoInduk)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoSpj)
//                    .HasColumnName("NoSPJ")
//                    .HasMaxLength(10);

//                entity.Property(e => e.Nominal)
//                    .HasColumnName("nominal")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal01)
//                    .HasColumnName("nominal01")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal02)
//                    .HasColumnName("nominal02")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal03)
//                    .HasColumnName("nominal03")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal04)
//                    .HasColumnName("nominal04")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal05)
//                    .HasColumnName("nominal05")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal06)
//                    .HasColumnName("nominal06")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal07)
//                    .HasColumnName("nominal07")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal08)
//                    .HasColumnName("nominal08")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal09)
//                    .HasColumnName("nominal09")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal10)
//                    .HasColumnName("nominal10")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal11)
//                    .HasColumnName("nominal11")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal12)
//                    .HasColumnName("nominal12")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Tahun).HasMaxLength(50);

//                entity.Property(e => e.Tglentry01)
//                    .HasColumnName("tglentry01")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry02)
//                    .HasColumnName("tglentry02")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry03)
//                    .HasColumnName("tglentry03")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry04)
//                    .HasColumnName("tglentry04")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry05)
//                    .HasColumnName("tglentry05")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry06)
//                    .HasColumnName("tglentry06")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry07)
//                    .HasColumnName("tglentry07")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry08)
//                    .HasColumnName("tglentry08")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry09)
//                    .HasColumnName("tglentry09")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry10)
//                    .HasColumnName("tglentry10")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry11)
//                    .HasColumnName("tglentry11")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry12)
//                    .HasColumnName("tglentry12")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas01).HasColumnName("tgllunas01");

//                entity.Property(e => e.Tgllunas02).HasColumnName("tgllunas02");

//                entity.Property(e => e.Tgllunas03).HasColumnName("tgllunas03");

//                entity.Property(e => e.Tgllunas04).HasColumnName("tgllunas04");

//                entity.Property(e => e.Tgllunas05).HasColumnName("tgllunas05");

//                entity.Property(e => e.Tgllunas06).HasColumnName("tgllunas06");

//                entity.Property(e => e.Tgllunas07)
//                    .HasColumnName("tgllunas07")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas08)
//                    .HasColumnName("tgllunas08")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas09)
//                    .HasColumnName("tgllunas09")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas10)
//                    .HasColumnName("tgllunas10")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas11).HasColumnName("tgllunas11");

//                entity.Property(e => e.Tgllunas12)
//                    .HasColumnName("tgllunas12")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.UserGroup).HasMaxLength(10);
//            });

//            modelBuilder.Entity<ViewTunggakanAll1920>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("View_TUNGGAKAN_ALL_1920");

//                entity.Property(e => e.CaraBayar)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.JnsPemb)
//                    .IsRequired()
//                    .HasMaxLength(4)
//                    .IsUnicode(false);

//                entity.Property(e => e.Kelas).HasMaxLength(50);

//                entity.Property(e => e.Kodesek).HasMaxLength(10);

//                entity.Property(e => e.Lastupdate)
//                    .HasColumnName("lastupdate")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.NamaSek).HasMaxLength(50);

//                entity.Property(e => e.NamaSiswa).HasMaxLength(200);

//                entity.Property(e => e.NoInduk)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoSpj)
//                    .HasColumnName("NoSPJ")
//                    .HasMaxLength(10);

//                entity.Property(e => e.Nominal)
//                    .HasColumnName("nominal")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal01)
//                    .HasColumnName("nominal01")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal02)
//                    .HasColumnName("nominal02")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal03)
//                    .HasColumnName("nominal03")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal04)
//                    .HasColumnName("nominal04")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal05)
//                    .HasColumnName("nominal05")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal06)
//                    .HasColumnName("nominal06")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal07)
//                    .HasColumnName("nominal07")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal08)
//                    .HasColumnName("nominal08")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal09)
//                    .HasColumnName("nominal09")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal10)
//                    .HasColumnName("nominal10")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal11)
//                    .HasColumnName("nominal11")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal12)
//                    .HasColumnName("nominal12")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Tahun).HasMaxLength(50);

//                entity.Property(e => e.Tglentry01)
//                    .HasColumnName("tglentry01")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry02)
//                    .HasColumnName("tglentry02")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry03)
//                    .HasColumnName("tglentry03")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry04)
//                    .HasColumnName("tglentry04")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry05)
//                    .HasColumnName("tglentry05")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry06)
//                    .HasColumnName("tglentry06")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry07)
//                    .HasColumnName("tglentry07")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry08)
//                    .HasColumnName("tglentry08")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry09)
//                    .HasColumnName("tglentry09")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry10)
//                    .HasColumnName("tglentry10")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry11)
//                    .HasColumnName("tglentry11")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry12)
//                    .HasColumnName("tglentry12")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas01).HasColumnName("tgllunas01");

//                entity.Property(e => e.Tgllunas02).HasColumnName("tgllunas02");

//                entity.Property(e => e.Tgllunas03).HasColumnName("tgllunas03");

//                entity.Property(e => e.Tgllunas04).HasColumnName("tgllunas04");

//                entity.Property(e => e.Tgllunas05).HasColumnName("tgllunas05");

//                entity.Property(e => e.Tgllunas06).HasColumnName("tgllunas06");

//                entity.Property(e => e.Tgllunas07)
//                    .HasColumnName("tgllunas07")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas08)
//                    .HasColumnName("tgllunas08")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas09)
//                    .HasColumnName("tgllunas09")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas10)
//                    .HasColumnName("tgllunas10")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas11).HasColumnName("tgllunas11");

//                entity.Property(e => e.Tgllunas12)
//                    .HasColumnName("tgllunas12")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.UserGroup).HasMaxLength(10);
//            });

//            modelBuilder.Entity<ViewTunggakanAll2021>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("View_TUNGGAKAN_ALL_2021");

//                entity.Property(e => e.CaraBayar)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.JnsPemb)
//                    .IsRequired()
//                    .HasMaxLength(4)
//                    .IsUnicode(false);

//                entity.Property(e => e.Kelas).HasMaxLength(50);

//                entity.Property(e => e.Kodesek).HasMaxLength(10);

//                entity.Property(e => e.Lastupdate)
//                    .HasColumnName("lastupdate")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.NamaSek).HasMaxLength(50);

//                entity.Property(e => e.NamaSiswa).HasMaxLength(200);

//                entity.Property(e => e.NoInduk)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoSpj)
//                    .HasColumnName("NoSPJ")
//                    .HasMaxLength(10);

//                entity.Property(e => e.Nominal)
//                    .HasColumnName("nominal")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal01)
//                    .HasColumnName("nominal01")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal02)
//                    .HasColumnName("nominal02")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal03)
//                    .HasColumnName("nominal03")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal04)
//                    .HasColumnName("nominal04")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal05)
//                    .HasColumnName("nominal05")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal06)
//                    .HasColumnName("nominal06")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal07)
//                    .HasColumnName("nominal07")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal08)
//                    .HasColumnName("nominal08")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal09)
//                    .HasColumnName("nominal09")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal10)
//                    .HasColumnName("nominal10")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal11)
//                    .HasColumnName("nominal11")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal12)
//                    .HasColumnName("nominal12")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Tahun).HasMaxLength(50);

//                entity.Property(e => e.Tglentry01)
//                    .HasColumnName("tglentry01")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry02)
//                    .HasColumnName("tglentry02")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry03)
//                    .HasColumnName("tglentry03")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry04)
//                    .HasColumnName("tglentry04")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry05)
//                    .HasColumnName("tglentry05")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry06)
//                    .HasColumnName("tglentry06")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry07)
//                    .HasColumnName("tglentry07")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry08)
//                    .HasColumnName("tglentry08")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry09)
//                    .HasColumnName("tglentry09")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry10)
//                    .HasColumnName("tglentry10")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry11)
//                    .HasColumnName("tglentry11")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry12)
//                    .HasColumnName("tglentry12")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas01).HasColumnName("tgllunas01");

//                entity.Property(e => e.Tgllunas02).HasColumnName("tgllunas02");

//                entity.Property(e => e.Tgllunas03).HasColumnName("tgllunas03");

//                entity.Property(e => e.Tgllunas04).HasColumnName("tgllunas04");

//                entity.Property(e => e.Tgllunas05).HasColumnName("tgllunas05");

//                entity.Property(e => e.Tgllunas06).HasColumnName("tgllunas06");

//                entity.Property(e => e.Tgllunas07)
//                    .HasColumnName("tgllunas07")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas08)
//                    .HasColumnName("tgllunas08")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas09)
//                    .HasColumnName("tgllunas09")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas10)
//                    .HasColumnName("tgllunas10")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas11).HasColumnName("tgllunas11");

//                entity.Property(e => e.Tgllunas12)
//                    .HasColumnName("tgllunas12")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.UserGroup).HasMaxLength(10);
//            });

//            modelBuilder.Entity<ViewTunggakanAll2122>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("View_TUNGGAKAN_ALL_2122");

//                entity.Property(e => e.CaraBayar)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.JnsPemb)
//                    .IsRequired()
//                    .HasMaxLength(4)
//                    .IsUnicode(false);

//                entity.Property(e => e.Kelas).HasMaxLength(50);

//                entity.Property(e => e.Kodesek).HasMaxLength(10);

//                entity.Property(e => e.Lastupdate)
//                    .HasColumnName("lastupdate")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.NamaSek).HasMaxLength(50);

//                entity.Property(e => e.NamaSiswa).HasMaxLength(200);

//                entity.Property(e => e.NoInduk)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoSpj)
//                    .HasColumnName("NoSPJ")
//                    .HasMaxLength(10);

//                entity.Property(e => e.Nominal)
//                    .HasColumnName("nominal")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal01)
//                    .HasColumnName("nominal01")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal02)
//                    .HasColumnName("nominal02")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal03)
//                    .HasColumnName("nominal03")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal04)
//                    .HasColumnName("nominal04")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal05)
//                    .HasColumnName("nominal05")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal06)
//                    .HasColumnName("nominal06")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal07)
//                    .HasColumnName("nominal07")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal08)
//                    .HasColumnName("nominal08")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal09)
//                    .HasColumnName("nominal09")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal10)
//                    .HasColumnName("nominal10")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal11)
//                    .HasColumnName("nominal11")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal12)
//                    .HasColumnName("nominal12")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Tahun).HasMaxLength(50);

//                entity.Property(e => e.Tglentry01)
//                    .HasColumnName("tglentry01")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry02)
//                    .HasColumnName("tglentry02")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry03)
//                    .HasColumnName("tglentry03")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry04)
//                    .HasColumnName("tglentry04")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry05)
//                    .HasColumnName("tglentry05")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry06)
//                    .HasColumnName("tglentry06")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry07)
//                    .HasColumnName("tglentry07")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry08)
//                    .HasColumnName("tglentry08")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry09)
//                    .HasColumnName("tglentry09")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry10)
//                    .HasColumnName("tglentry10")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry11)
//                    .HasColumnName("tglentry11")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry12)
//                    .HasColumnName("tglentry12")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas01)
//                    .HasColumnName("tgllunas01")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas02)
//                    .HasColumnName("tgllunas02")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas03)
//                    .HasColumnName("tgllunas03")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas04).HasColumnName("tgllunas04");

//                entity.Property(e => e.Tgllunas05).HasColumnName("tgllunas05");

//                entity.Property(e => e.Tgllunas06).HasColumnName("tgllunas06");

//                entity.Property(e => e.Tgllunas07)
//                    .HasColumnName("tgllunas07")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas08)
//                    .HasColumnName("tgllunas08")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas09)
//                    .HasColumnName("tgllunas09")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas10)
//                    .HasColumnName("tgllunas10")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas11).HasColumnName("tgllunas11");

//                entity.Property(e => e.Tgllunas12)
//                    .HasColumnName("tgllunas12")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.UserGroup).HasMaxLength(10);
//            });

//            modelBuilder.Entity<ViewTunggakanDstAll>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("View_TUNGGAKAN_DST_ALL");

//                entity.Property(e => e.CaraBayar)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.JnsPemb)
//                    .IsRequired()
//                    .HasMaxLength(4)
//                    .IsUnicode(false);

//                entity.Property(e => e.Kelas).HasMaxLength(50);

//                entity.Property(e => e.Kodesek).HasMaxLength(10);

//                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

//                entity.Property(e => e.NamaSek).HasMaxLength(50);

//                entity.Property(e => e.NamaSiswa).HasMaxLength(200);

//                entity.Property(e => e.NoInduk)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoSpj)
//                    .HasColumnName("NoSPJ")
//                    .HasMaxLength(10);

//                entity.Property(e => e.Nominal)
//                    .HasColumnName("nominal")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal01)
//                    .HasColumnName("nominal01")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal02)
//                    .HasColumnName("nominal02")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal03)
//                    .HasColumnName("nominal03")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal04).HasColumnName("nominal04");

//                entity.Property(e => e.Nominal05).HasColumnName("nominal05");

//                entity.Property(e => e.Nominal06).HasColumnName("nominal06");

//                entity.Property(e => e.Nominal07).HasColumnName("nominal07");

//                entity.Property(e => e.Nominal08).HasColumnName("nominal08");

//                entity.Property(e => e.Nominal09).HasColumnName("nominal09");

//                entity.Property(e => e.Nominal10).HasColumnName("nominal10");

//                entity.Property(e => e.Nominal11).HasColumnName("nominal11");

//                entity.Property(e => e.Nominal12).HasColumnName("nominal12");

//                entity.Property(e => e.Tahun).HasMaxLength(50);

//                entity.Property(e => e.Tglentry01)
//                    .HasColumnName("tglentry01")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry02)
//                    .HasColumnName("tglentry02")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry03)
//                    .HasColumnName("tglentry03")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry04).HasColumnName("tglentry04");

//                entity.Property(e => e.Tglentry05).HasColumnName("tglentry05");

//                entity.Property(e => e.Tglentry06).HasColumnName("tglentry06");

//                entity.Property(e => e.Tglentry07).HasColumnName("tglentry07");

//                entity.Property(e => e.Tglentry08).HasColumnName("tglentry08");

//                entity.Property(e => e.Tglentry09).HasColumnName("tglentry09");

//                entity.Property(e => e.Tglentry10).HasColumnName("tglentry10");

//                entity.Property(e => e.Tglentry11).HasColumnName("tglentry11");

//                entity.Property(e => e.Tglentry12).HasColumnName("tglentry12");

//                entity.Property(e => e.Tgllunas01)
//                    .HasColumnName("tgllunas01")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas02)
//                    .HasColumnName("tgllunas02")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas03)
//                    .HasColumnName("tgllunas03")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas04).HasColumnName("tgllunas04");

//                entity.Property(e => e.Tgllunas05).HasColumnName("tgllunas05");

//                entity.Property(e => e.Tgllunas06).HasColumnName("tgllunas06");

//                entity.Property(e => e.Tgllunas07).HasColumnName("tgllunas07");

//                entity.Property(e => e.Tgllunas08).HasColumnName("tgllunas08");

//                entity.Property(e => e.Tgllunas09).HasColumnName("tgllunas09");

//                entity.Property(e => e.Tgllunas10).HasColumnName("tgllunas10");

//                entity.Property(e => e.Tgllunas11).HasColumnName("tgllunas11");

//                entity.Property(e => e.Tgllunas12).HasColumnName("tgllunas12");

//                entity.Property(e => e.UserGroup).HasMaxLength(10);
//            });

//            modelBuilder.Entity<ViewTunggakanDstAll1920>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("View_TUNGGAKAN_DST_ALL_1920");

//                entity.Property(e => e.CaraBayar)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.JnsPemb)
//                    .IsRequired()
//                    .HasMaxLength(4)
//                    .IsUnicode(false);

//                entity.Property(e => e.Kelas).HasMaxLength(50);

//                entity.Property(e => e.Kodesek).HasMaxLength(10);

//                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

//                entity.Property(e => e.NamaSek).HasMaxLength(50);

//                entity.Property(e => e.NamaSiswa).HasMaxLength(200);

//                entity.Property(e => e.NoInduk)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoSpj)
//                    .HasColumnName("NoSPJ")
//                    .HasMaxLength(10);

//                entity.Property(e => e.Nominal)
//                    .HasColumnName("nominal")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal01)
//                    .HasColumnName("nominal01")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal02)
//                    .HasColumnName("nominal02")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal03)
//                    .HasColumnName("nominal03")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal04).HasColumnName("nominal04");

//                entity.Property(e => e.Nominal05).HasColumnName("nominal05");

//                entity.Property(e => e.Nominal06).HasColumnName("nominal06");

//                entity.Property(e => e.Nominal07).HasColumnName("nominal07");

//                entity.Property(e => e.Nominal08).HasColumnName("nominal08");

//                entity.Property(e => e.Nominal09).HasColumnName("nominal09");

//                entity.Property(e => e.Nominal10).HasColumnName("nominal10");

//                entity.Property(e => e.Nominal11).HasColumnName("nominal11");

//                entity.Property(e => e.Nominal12).HasColumnName("nominal12");

//                entity.Property(e => e.Tahun).HasMaxLength(50);

//                entity.Property(e => e.Tglentry01)
//                    .HasColumnName("tglentry01")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry02)
//                    .HasColumnName("tglentry02")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry03)
//                    .HasColumnName("tglentry03")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry04).HasColumnName("tglentry04");

//                entity.Property(e => e.Tglentry05).HasColumnName("tglentry05");

//                entity.Property(e => e.Tglentry06).HasColumnName("tglentry06");

//                entity.Property(e => e.Tglentry07).HasColumnName("tglentry07");

//                entity.Property(e => e.Tglentry08).HasColumnName("tglentry08");

//                entity.Property(e => e.Tglentry09).HasColumnName("tglentry09");

//                entity.Property(e => e.Tglentry10).HasColumnName("tglentry10");

//                entity.Property(e => e.Tglentry11).HasColumnName("tglentry11");

//                entity.Property(e => e.Tglentry12).HasColumnName("tglentry12");

//                entity.Property(e => e.Tgllunas01)
//                    .HasColumnName("tgllunas01")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas02)
//                    .HasColumnName("tgllunas02")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas03)
//                    .HasColumnName("tgllunas03")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas04).HasColumnName("tgllunas04");

//                entity.Property(e => e.Tgllunas05).HasColumnName("tgllunas05");

//                entity.Property(e => e.Tgllunas06).HasColumnName("tgllunas06");

//                entity.Property(e => e.Tgllunas07).HasColumnName("tgllunas07");

//                entity.Property(e => e.Tgllunas08).HasColumnName("tgllunas08");

//                entity.Property(e => e.Tgllunas09).HasColumnName("tgllunas09");

//                entity.Property(e => e.Tgllunas10).HasColumnName("tgllunas10");

//                entity.Property(e => e.Tgllunas11).HasColumnName("tgllunas11");

//                entity.Property(e => e.Tgllunas12).HasColumnName("tgllunas12");

//                entity.Property(e => e.UserGroup).HasMaxLength(10);
//            });

//            modelBuilder.Entity<ViewTunggakanDstAll2021>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("View_TUNGGAKAN_DST_ALL_2021");

//                entity.Property(e => e.CaraBayar)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.JnsPemb)
//                    .IsRequired()
//                    .HasMaxLength(4)
//                    .IsUnicode(false);

//                entity.Property(e => e.Kelas).HasMaxLength(50);

//                entity.Property(e => e.Kodesek).HasMaxLength(10);

//                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

//                entity.Property(e => e.NamaSek).HasMaxLength(50);

//                entity.Property(e => e.NamaSiswa).HasMaxLength(200);

//                entity.Property(e => e.NoInduk)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoSpj)
//                    .HasColumnName("NoSPJ")
//                    .HasMaxLength(10);

//                entity.Property(e => e.Nominal)
//                    .HasColumnName("nominal")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal01)
//                    .HasColumnName("nominal01")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal02)
//                    .HasColumnName("nominal02")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal03)
//                    .HasColumnName("nominal03")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal04).HasColumnName("nominal04");

//                entity.Property(e => e.Nominal05).HasColumnName("nominal05");

//                entity.Property(e => e.Nominal06).HasColumnName("nominal06");

//                entity.Property(e => e.Nominal07).HasColumnName("nominal07");

//                entity.Property(e => e.Nominal08).HasColumnName("nominal08");

//                entity.Property(e => e.Nominal09).HasColumnName("nominal09");

//                entity.Property(e => e.Nominal10).HasColumnName("nominal10");

//                entity.Property(e => e.Nominal11).HasColumnName("nominal11");

//                entity.Property(e => e.Nominal12).HasColumnName("nominal12");

//                entity.Property(e => e.Tahun).HasMaxLength(50);

//                entity.Property(e => e.Tglentry01)
//                    .HasColumnName("tglentry01")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry02)
//                    .HasColumnName("tglentry02")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry03)
//                    .HasColumnName("tglentry03")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry04).HasColumnName("tglentry04");

//                entity.Property(e => e.Tglentry05).HasColumnName("tglentry05");

//                entity.Property(e => e.Tglentry06).HasColumnName("tglentry06");

//                entity.Property(e => e.Tglentry07).HasColumnName("tglentry07");

//                entity.Property(e => e.Tglentry08).HasColumnName("tglentry08");

//                entity.Property(e => e.Tglentry09).HasColumnName("tglentry09");

//                entity.Property(e => e.Tglentry10).HasColumnName("tglentry10");

//                entity.Property(e => e.Tglentry11).HasColumnName("tglentry11");

//                entity.Property(e => e.Tglentry12).HasColumnName("tglentry12");

//                entity.Property(e => e.Tgllunas01)
//                    .HasColumnName("tgllunas01")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas02)
//                    .HasColumnName("tgllunas02")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas03)
//                    .HasColumnName("tgllunas03")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas04).HasColumnName("tgllunas04");

//                entity.Property(e => e.Tgllunas05).HasColumnName("tgllunas05");

//                entity.Property(e => e.Tgllunas06).HasColumnName("tgllunas06");

//                entity.Property(e => e.Tgllunas07).HasColumnName("tgllunas07");

//                entity.Property(e => e.Tgllunas08).HasColumnName("tgllunas08");

//                entity.Property(e => e.Tgllunas09).HasColumnName("tgllunas09");

//                entity.Property(e => e.Tgllunas10).HasColumnName("tgllunas10");

//                entity.Property(e => e.Tgllunas11).HasColumnName("tgllunas11");

//                entity.Property(e => e.Tgllunas12).HasColumnName("tgllunas12");

//                entity.Property(e => e.UserGroup).HasMaxLength(10);
//            });

//            modelBuilder.Entity<ViewTunggakanDstAll2122>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("View_TUNGGAKAN_DST_ALL_2122");

//                entity.Property(e => e.CaraBayar)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.JnsPemb)
//                    .IsRequired()
//                    .HasMaxLength(4)
//                    .IsUnicode(false);

//                entity.Property(e => e.Kelas).HasMaxLength(50);

//                entity.Property(e => e.Kodesek).HasMaxLength(10);

//                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

//                entity.Property(e => e.NamaSek).HasMaxLength(50);

//                entity.Property(e => e.NamaSiswa).HasMaxLength(200);

//                entity.Property(e => e.NoInduk)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoSpj)
//                    .HasColumnName("NoSPJ")
//                    .HasMaxLength(10);

//                entity.Property(e => e.Nominal)
//                    .HasColumnName("nominal")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal01)
//                    .HasColumnName("nominal01")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal02)
//                    .HasColumnName("nominal02")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal03)
//                    .HasColumnName("nominal03")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal04).HasColumnName("nominal04");

//                entity.Property(e => e.Nominal05).HasColumnName("nominal05");

//                entity.Property(e => e.Nominal06).HasColumnName("nominal06");

//                entity.Property(e => e.Nominal07).HasColumnName("nominal07");

//                entity.Property(e => e.Nominal08).HasColumnName("nominal08");

//                entity.Property(e => e.Nominal09).HasColumnName("nominal09");

//                entity.Property(e => e.Nominal10).HasColumnName("nominal10");

//                entity.Property(e => e.Nominal11).HasColumnName("nominal11");

//                entity.Property(e => e.Nominal12).HasColumnName("nominal12");

//                entity.Property(e => e.Tahun).HasMaxLength(50);

//                entity.Property(e => e.Tglentry01)
//                    .HasColumnName("tglentry01")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry02)
//                    .HasColumnName("tglentry02")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry03)
//                    .HasColumnName("tglentry03")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry04).HasColumnName("tglentry04");

//                entity.Property(e => e.Tglentry05).HasColumnName("tglentry05");

//                entity.Property(e => e.Tglentry06).HasColumnName("tglentry06");

//                entity.Property(e => e.Tglentry07).HasColumnName("tglentry07");

//                entity.Property(e => e.Tglentry08).HasColumnName("tglentry08");

//                entity.Property(e => e.Tglentry09).HasColumnName("tglentry09");

//                entity.Property(e => e.Tglentry10).HasColumnName("tglentry10");

//                entity.Property(e => e.Tglentry11).HasColumnName("tglentry11");

//                entity.Property(e => e.Tglentry12).HasColumnName("tglentry12");

//                entity.Property(e => e.Tgllunas01)
//                    .HasColumnName("tgllunas01")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas02)
//                    .HasColumnName("tgllunas02")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas03)
//                    .HasColumnName("tgllunas03")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas04).HasColumnName("tgllunas04");

//                entity.Property(e => e.Tgllunas05).HasColumnName("tgllunas05");

//                entity.Property(e => e.Tgllunas06).HasColumnName("tgllunas06");

//                entity.Property(e => e.Tgllunas07).HasColumnName("tgllunas07");

//                entity.Property(e => e.Tgllunas08).HasColumnName("tgllunas08");

//                entity.Property(e => e.Tgllunas09).HasColumnName("tgllunas09");

//                entity.Property(e => e.Tgllunas10).HasColumnName("tgllunas10");

//                entity.Property(e => e.Tgllunas11).HasColumnName("tgllunas11");

//                entity.Property(e => e.Tgllunas12).HasColumnName("tgllunas12");

//                entity.Property(e => e.UserGroup).HasMaxLength(10);
//            });

//            modelBuilder.Entity<ViewTunggakanUsekAll>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("View_TUNGGAKAN_USEK_ALL");

//                entity.Property(e => e.CaraBayar)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.JnsPemb)
//                    .IsRequired()
//                    .HasMaxLength(4)
//                    .IsUnicode(false);

//                entity.Property(e => e.Kelas).HasMaxLength(50);

//                entity.Property(e => e.Kodesek).HasMaxLength(10);

//                entity.Property(e => e.Lastupdate)
//                    .HasColumnName("lastupdate")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.NamaSek).HasMaxLength(50);

//                entity.Property(e => e.NamaSiswa).HasMaxLength(200);

//                entity.Property(e => e.NoInduk)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoSpj)
//                    .HasColumnName("NoSPJ")
//                    .HasMaxLength(10);

//                entity.Property(e => e.Nominal)
//                    .HasColumnName("nominal")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal01)
//                    .HasColumnName("nominal01")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal02)
//                    .HasColumnName("nominal02")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal03)
//                    .HasColumnName("nominal03")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal04)
//                    .HasColumnName("nominal04")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal05)
//                    .HasColumnName("nominal05")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal06)
//                    .HasColumnName("nominal06")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal07)
//                    .HasColumnName("nominal07")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal08)
//                    .HasColumnName("nominal08")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal09)
//                    .HasColumnName("nominal09")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal10)
//                    .HasColumnName("nominal10")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal11)
//                    .HasColumnName("nominal11")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal12)
//                    .HasColumnName("nominal12")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Tahun).HasMaxLength(50);

//                entity.Property(e => e.Tglentry01)
//                    .HasColumnName("tglentry01")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry02)
//                    .HasColumnName("tglentry02")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry03)
//                    .HasColumnName("tglentry03")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry04)
//                    .HasColumnName("tglentry04")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry05)
//                    .HasColumnName("tglentry05")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry06)
//                    .HasColumnName("tglentry06")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry07)
//                    .HasColumnName("tglentry07")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry08)
//                    .HasColumnName("tglentry08")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry09)
//                    .HasColumnName("tglentry09")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry10)
//                    .HasColumnName("tglentry10")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry11)
//                    .HasColumnName("tglentry11")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry12)
//                    .HasColumnName("tglentry12")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas01)
//                    .HasColumnName("tgllunas01")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tgllunas02)
//                    .HasColumnName("tgllunas02")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tgllunas03)
//                    .HasColumnName("tgllunas03")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tgllunas04)
//                    .HasColumnName("tgllunas04")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tgllunas05)
//                    .HasColumnName("tgllunas05")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tgllunas06)
//                    .HasColumnName("tgllunas06")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tgllunas07)
//                    .HasColumnName("tgllunas07")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas08)
//                    .HasColumnName("tgllunas08")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas09)
//                    .HasColumnName("tgllunas09")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas10)
//                    .HasColumnName("tgllunas10")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas11)
//                    .HasColumnName("tgllunas11")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tgllunas12)
//                    .HasColumnName("tgllunas12")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.UserGroup).HasMaxLength(10);
//            });

//            modelBuilder.Entity<ViewTunggakanUsekAll1920>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("View_TUNGGAKAN_USEK_ALL_1920");

//                entity.Property(e => e.CaraBayar)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.JnsPemb)
//                    .IsRequired()
//                    .HasMaxLength(4)
//                    .IsUnicode(false);

//                entity.Property(e => e.Kelas).HasMaxLength(50);

//                entity.Property(e => e.Kodesek).HasMaxLength(10);

//                entity.Property(e => e.Lastupdate)
//                    .HasColumnName("lastupdate")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.NamaSek).HasMaxLength(50);

//                entity.Property(e => e.NamaSiswa).HasMaxLength(200);

//                entity.Property(e => e.NoInduk)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoSpj)
//                    .HasColumnName("NoSPJ")
//                    .HasMaxLength(10);

//                entity.Property(e => e.Nominal)
//                    .HasColumnName("nominal")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal01)
//                    .HasColumnName("nominal01")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal02)
//                    .HasColumnName("nominal02")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal03)
//                    .HasColumnName("nominal03")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal04)
//                    .HasColumnName("nominal04")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal05)
//                    .HasColumnName("nominal05")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal06)
//                    .HasColumnName("nominal06")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal07)
//                    .HasColumnName("nominal07")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal08)
//                    .HasColumnName("nominal08")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal09)
//                    .HasColumnName("nominal09")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal10)
//                    .HasColumnName("nominal10")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal11)
//                    .HasColumnName("nominal11")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal12)
//                    .HasColumnName("nominal12")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Tahun).HasMaxLength(50);

//                entity.Property(e => e.Tglentry01)
//                    .HasColumnName("tglentry01")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry02)
//                    .HasColumnName("tglentry02")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry03)
//                    .HasColumnName("tglentry03")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry04)
//                    .HasColumnName("tglentry04")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry05)
//                    .HasColumnName("tglentry05")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry06)
//                    .HasColumnName("tglentry06")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry07)
//                    .HasColumnName("tglentry07")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry08)
//                    .HasColumnName("tglentry08")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry09)
//                    .HasColumnName("tglentry09")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry10)
//                    .HasColumnName("tglentry10")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry11)
//                    .HasColumnName("tglentry11")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry12)
//                    .HasColumnName("tglentry12")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas01)
//                    .HasColumnName("tgllunas01")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tgllunas02)
//                    .HasColumnName("tgllunas02")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tgllunas03)
//                    .HasColumnName("tgllunas03")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tgllunas04)
//                    .HasColumnName("tgllunas04")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tgllunas05)
//                    .HasColumnName("tgllunas05")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tgllunas06)
//                    .HasColumnName("tgllunas06")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tgllunas07)
//                    .HasColumnName("tgllunas07")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas08)
//                    .HasColumnName("tgllunas08")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas09)
//                    .HasColumnName("tgllunas09")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas10)
//                    .HasColumnName("tgllunas10")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas11)
//                    .HasColumnName("tgllunas11")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tgllunas12)
//                    .HasColumnName("tgllunas12")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.UserGroup).HasMaxLength(10);
//            });

//            modelBuilder.Entity<ViewTunggakanUsekAll2021>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("View_TUNGGAKAN_USEK_ALL_2021");

//                entity.Property(e => e.CaraBayar)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.JnsPemb)
//                    .IsRequired()
//                    .HasMaxLength(4)
//                    .IsUnicode(false);

//                entity.Property(e => e.Kelas).HasMaxLength(50);

//                entity.Property(e => e.Kodesek).HasMaxLength(10);

//                entity.Property(e => e.Lastupdate)
//                    .HasColumnName("lastupdate")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.NamaSek).HasMaxLength(50);

//                entity.Property(e => e.NamaSiswa).HasMaxLength(200);

//                entity.Property(e => e.NoInduk)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoSpj)
//                    .HasColumnName("NoSPJ")
//                    .HasMaxLength(10);

//                entity.Property(e => e.Nominal)
//                    .HasColumnName("nominal")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal01)
//                    .HasColumnName("nominal01")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal02)
//                    .HasColumnName("nominal02")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal03)
//                    .HasColumnName("nominal03")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal04)
//                    .HasColumnName("nominal04")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal05)
//                    .HasColumnName("nominal05")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal06)
//                    .HasColumnName("nominal06")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal07)
//                    .HasColumnName("nominal07")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal08)
//                    .HasColumnName("nominal08")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal09)
//                    .HasColumnName("nominal09")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal10)
//                    .HasColumnName("nominal10")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal11)
//                    .HasColumnName("nominal11")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal12)
//                    .HasColumnName("nominal12")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Tahun).HasMaxLength(50);

//                entity.Property(e => e.Tglentry01)
//                    .HasColumnName("tglentry01")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry02)
//                    .HasColumnName("tglentry02")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry03)
//                    .HasColumnName("tglentry03")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry04)
//                    .HasColumnName("tglentry04")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry05)
//                    .HasColumnName("tglentry05")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry06)
//                    .HasColumnName("tglentry06")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry07)
//                    .HasColumnName("tglentry07")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry08)
//                    .HasColumnName("tglentry08")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry09)
//                    .HasColumnName("tglentry09")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry10)
//                    .HasColumnName("tglentry10")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry11)
//                    .HasColumnName("tglentry11")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry12)
//                    .HasColumnName("tglentry12")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas01)
//                    .HasColumnName("tgllunas01")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tgllunas02)
//                    .HasColumnName("tgllunas02")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tgllunas03)
//                    .HasColumnName("tgllunas03")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tgllunas04)
//                    .HasColumnName("tgllunas04")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tgllunas05)
//                    .HasColumnName("tgllunas05")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tgllunas06)
//                    .HasColumnName("tgllunas06")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tgllunas07)
//                    .HasColumnName("tgllunas07")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas08)
//                    .HasColumnName("tgllunas08")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas09)
//                    .HasColumnName("tgllunas09")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas10)
//                    .HasColumnName("tgllunas10")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas11)
//                    .HasColumnName("tgllunas11")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tgllunas12)
//                    .HasColumnName("tgllunas12")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.UserGroup).HasMaxLength(10);
//            });

//            modelBuilder.Entity<ViewTunggakanUsekAll2122>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("View_TUNGGAKAN_USEK_ALL_2122");

//                entity.Property(e => e.CaraBayar)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.JnsPemb)
//                    .IsRequired()
//                    .HasMaxLength(4)
//                    .IsUnicode(false);

//                entity.Property(e => e.Kelas).HasMaxLength(50);

//                entity.Property(e => e.Kodesek).HasMaxLength(10);

//                entity.Property(e => e.Lastupdate)
//                    .HasColumnName("lastupdate")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.NamaSek).HasMaxLength(50);

//                entity.Property(e => e.NamaSiswa).HasMaxLength(200);

//                entity.Property(e => e.NoInduk)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoSpj)
//                    .HasColumnName("NoSPJ")
//                    .HasMaxLength(10);

//                entity.Property(e => e.Nominal)
//                    .HasColumnName("nominal")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal01)
//                    .HasColumnName("nominal01")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal02)
//                    .HasColumnName("nominal02")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal03)
//                    .HasColumnName("nominal03")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal04)
//                    .HasColumnName("nominal04")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal05)
//                    .HasColumnName("nominal05")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal06)
//                    .HasColumnName("nominal06")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal07)
//                    .HasColumnName("nominal07")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal08)
//                    .HasColumnName("nominal08")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal09)
//                    .HasColumnName("nominal09")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal10)
//                    .HasColumnName("nominal10")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal11)
//                    .HasColumnName("nominal11")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Nominal12)
//                    .HasColumnName("nominal12")
//                    .HasColumnType("decimal(16, 0)");

//                entity.Property(e => e.Tahun).HasMaxLength(50);

//                entity.Property(e => e.Tglentry01)
//                    .HasColumnName("tglentry01")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry02)
//                    .HasColumnName("tglentry02")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry03)
//                    .HasColumnName("tglentry03")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry04)
//                    .HasColumnName("tglentry04")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry05)
//                    .HasColumnName("tglentry05")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry06)
//                    .HasColumnName("tglentry06")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry07)
//                    .HasColumnName("tglentry07")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry08)
//                    .HasColumnName("tglentry08")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry09)
//                    .HasColumnName("tglentry09")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry10)
//                    .HasColumnName("tglentry10")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry11)
//                    .HasColumnName("tglentry11")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tglentry12)
//                    .HasColumnName("tglentry12")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas01)
//                    .HasColumnName("tgllunas01")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tgllunas02)
//                    .HasColumnName("tgllunas02")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tgllunas03)
//                    .HasColumnName("tgllunas03")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tgllunas04)
//                    .HasColumnName("tgllunas04")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tgllunas05)
//                    .HasColumnName("tgllunas05")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tgllunas06)
//                    .HasColumnName("tgllunas06")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tgllunas07)
//                    .HasColumnName("tgllunas07")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas08)
//                    .HasColumnName("tgllunas08")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas09)
//                    .HasColumnName("tgllunas09")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas10)
//                    .HasColumnName("tgllunas10")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Tgllunas11)
//                    .HasColumnName("tgllunas11")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tgllunas12)
//                    .HasColumnName("tgllunas12")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.UserGroup).HasMaxLength(10);
//            });

//            modelBuilder.Entity<ViewUsekAll>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("View_USEK_ALL");

//                entity.Property(e => e.Agustus)
//                    .HasColumnName("agustus")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.April)
//                    .HasColumnName("april")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.CaraBayar)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.Desember)
//                    .HasColumnName("desember")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.Februari)
//                    .HasColumnName("februari")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.Januari)
//                    .HasColumnName("januari")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.JnsPemb)
//                    .IsRequired()
//                    .HasMaxLength(4)
//                    .IsUnicode(false);

//                entity.Property(e => e.Juli)
//                    .HasColumnName("juli")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.Juni)
//                    .HasColumnName("juni")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.Kelas).HasMaxLength(50);

//                entity.Property(e => e.Kodesek).HasMaxLength(10);

//                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

//                entity.Property(e => e.Maret)
//                    .HasColumnName("maret")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.Mei)
//                    .HasColumnName("mei")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.NamaSek).HasMaxLength(50);

//                entity.Property(e => e.Namasiswa)
//                    .HasColumnName("namasiswa")
//                    .HasMaxLength(200);

//                entity.Property(e => e.NoInduk)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoSpj)
//                    .HasColumnName("NoSPJ")
//                    .HasMaxLength(10);

//                entity.Property(e => e.November)
//                    .HasColumnName("november")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.Oktober)
//                    .HasColumnName("oktober")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.September)
//                    .HasColumnName("september")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tahun).HasMaxLength(50);

//                entity.Property(e => e.Usergroup)
//                    .HasColumnName("usergroup")
//                    .HasMaxLength(10);
//            });

//            modelBuilder.Entity<ViewUsekAll1920>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("View_USEK_ALL_1920");

//                entity.Property(e => e.Agustus)
//                    .HasColumnName("agustus")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.April)
//                    .HasColumnName("april")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.CaraBayar)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.Desember)
//                    .HasColumnName("desember")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.Februari)
//                    .HasColumnName("februari")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.Januari)
//                    .HasColumnName("januari")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.JnsPemb)
//                    .IsRequired()
//                    .HasMaxLength(4)
//                    .IsUnicode(false);

//                entity.Property(e => e.Juli)
//                    .HasColumnName("juli")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.Juni)
//                    .HasColumnName("juni")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.Kelas).HasMaxLength(50);

//                entity.Property(e => e.Kodesek).HasMaxLength(10);

//                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

//                entity.Property(e => e.Maret)
//                    .HasColumnName("maret")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.Mei)
//                    .HasColumnName("mei")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.NamaSek).HasMaxLength(50);

//                entity.Property(e => e.Namasiswa)
//                    .HasColumnName("namasiswa")
//                    .HasMaxLength(200);

//                entity.Property(e => e.NoInduk)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoSpj)
//                    .HasColumnName("NoSPJ")
//                    .HasMaxLength(10);

//                entity.Property(e => e.November)
//                    .HasColumnName("november")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.Oktober)
//                    .HasColumnName("oktober")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.September)
//                    .HasColumnName("september")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tahun).HasMaxLength(50);

//                entity.Property(e => e.Usergroup)
//                    .HasColumnName("usergroup")
//                    .HasMaxLength(10);
//            });

//            modelBuilder.Entity<ViewUsekAll2021>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("View_USEK_ALL_2021");

//                entity.Property(e => e.Agustus)
//                    .HasColumnName("agustus")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.April)
//                    .HasColumnName("april")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.CaraBayar)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.Desember)
//                    .HasColumnName("desember")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.Februari)
//                    .HasColumnName("februari")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.Januari)
//                    .HasColumnName("januari")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.JnsPemb)
//                    .IsRequired()
//                    .HasMaxLength(4)
//                    .IsUnicode(false);

//                entity.Property(e => e.Juli)
//                    .HasColumnName("juli")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.Juni)
//                    .HasColumnName("juni")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.Kelas).HasMaxLength(50);

//                entity.Property(e => e.Kodesek).HasMaxLength(10);

//                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

//                entity.Property(e => e.Maret)
//                    .HasColumnName("maret")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.Mei)
//                    .HasColumnName("mei")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.NamaSek).HasMaxLength(50);

//                entity.Property(e => e.Namasiswa)
//                    .HasColumnName("namasiswa")
//                    .HasMaxLength(200);

//                entity.Property(e => e.NoInduk)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoSpj)
//                    .HasColumnName("NoSPJ")
//                    .HasMaxLength(10);

//                entity.Property(e => e.November)
//                    .HasColumnName("november")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.Oktober)
//                    .HasColumnName("oktober")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.September)
//                    .HasColumnName("september")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tahun).HasMaxLength(50);

//                entity.Property(e => e.Usergroup)
//                    .HasColumnName("usergroup")
//                    .HasMaxLength(10);
//            });

//            modelBuilder.Entity<ViewUsekAll2122>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("View_USEK_ALL_2122");

//                entity.Property(e => e.Agustus)
//                    .HasColumnName("agustus")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.April)
//                    .HasColumnName("april")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.CaraBayar)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.Desember)
//                    .HasColumnName("desember")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.Februari)
//                    .HasColumnName("februari")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.Januari)
//                    .HasColumnName("januari")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.JnsPemb)
//                    .IsRequired()
//                    .HasMaxLength(4)
//                    .IsUnicode(false);

//                entity.Property(e => e.Juli)
//                    .HasColumnName("juli")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.Juni)
//                    .HasColumnName("juni")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.Kelas).HasMaxLength(50);

//                entity.Property(e => e.Kodesek).HasMaxLength(10);

//                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

//                entity.Property(e => e.Maret)
//                    .HasColumnName("maret")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.Mei)
//                    .HasColumnName("mei")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.NamaSek).HasMaxLength(50);

//                entity.Property(e => e.Namasiswa)
//                    .HasColumnName("namasiswa")
//                    .HasMaxLength(200);

//                entity.Property(e => e.NoInduk)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoSpj)
//                    .HasColumnName("NoSPJ")
//                    .HasMaxLength(10);

//                entity.Property(e => e.November)
//                    .HasColumnName("november")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.Oktober)
//                    .HasColumnName("oktober")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.September)
//                    .HasColumnName("september")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tahun).HasMaxLength(50);

//                entity.Property(e => e.Usergroup)
//                    .HasColumnName("usergroup")
//                    .HasMaxLength(10);
//            });

//            modelBuilder.Entity<ViewUsekAllB>(entity =>
//            {
//                entity.HasNoKey();

//                entity.ToView("View_USEK_ALL_B");

//                entity.Property(e => e.Agustus)
//                    .HasColumnName("agustus")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.April)
//                    .HasColumnName("april")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.CaraBayar)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.Desember)
//                    .HasColumnName("desember")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.Februari)
//                    .HasColumnName("februari")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.Id).HasColumnName("id");

//                entity.Property(e => e.Januari)
//                    .HasColumnName("januari")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.JnsPemb)
//                    .IsRequired()
//                    .HasMaxLength(4)
//                    .IsUnicode(false);

//                entity.Property(e => e.Juli)
//                    .HasColumnName("juli")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.Juni)
//                    .HasColumnName("juni")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.Kelas).HasMaxLength(50);

//                entity.Property(e => e.Kodesek).HasMaxLength(10);

//                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

//                entity.Property(e => e.Maret)
//                    .HasColumnName("maret")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.Mei)
//                    .HasColumnName("mei")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.NamaSek).HasMaxLength(50);

//                entity.Property(e => e.Namasiswa)
//                    .HasColumnName("namasiswa")
//                    .HasMaxLength(200);

//                entity.Property(e => e.NoInduk)
//                    .IsRequired()
//                    .HasMaxLength(1)
//                    .IsUnicode(false);

//                entity.Property(e => e.NoSpj)
//                    .HasColumnName("NoSPJ")
//                    .HasMaxLength(10);

//                entity.Property(e => e.Nominal).HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.November)
//                    .HasColumnName("november")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.Oktober)
//                    .HasColumnName("oktober")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.September)
//                    .HasColumnName("september")
//                    .HasMaxLength(131)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tahun).HasMaxLength(50);

//                entity.Property(e => e.UsekStd).HasColumnType("decimal(18, 2)");

//                entity.Property(e => e.Usergroup)
//                    .HasColumnName("usergroup")
//                    .HasMaxLength(10);
//            });

//            modelBuilder.Entity<WaliSiswa>(entity =>
//            {
//                entity.HasNoKey();

//                entity.Property(e => e.AgamaId).HasColumnName("AgamaID");

//                entity.Property(e => e.Alamat).HasMaxLength(255);

//                entity.Property(e => e.Email).HasMaxLength(50);

//                entity.Property(e => e.JenisKelamin).HasMaxLength(50);

//                entity.Property(e => e.KodePosId).HasColumnName("KodePosID");

//                entity.Property(e => e.Name).HasMaxLength(50);

//                entity.Property(e => e.NoMobile).HasMaxLength(50);

//                entity.Property(e => e.NoTelepon).HasMaxLength(50);

//                entity.Property(e => e.SubAgamaId).HasColumnName("SubAgamaID");

//                entity.Property(e => e.TanggalLahir).HasColumnType("datetime");

//                entity.Property(e => e.TempatLahir).HasMaxLength(255);

//                entity.Property(e => e.WaliSiswaId).HasColumnName("WaliSiswaID");
//            });

//            OnModelCreatingPartial(modelBuilder);
//        }

//        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//    }
//}
