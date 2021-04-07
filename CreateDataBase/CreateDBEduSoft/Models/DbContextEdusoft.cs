using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CreateDBEduSoft.Models
{
    public partial class DbContextEdusoft : DbContext
    {
        public DbContextEdusoft()
            : base("name=DbContextEdusoft")
        {
        }

        public virtual DbSet<LopHocs> LopHocs { get; set; }
        public virtual DbSet<BoMons> BoMons{ get; set; }
        public virtual DbSet<ChuongTrinhDaoTaos> ChuongTrinhDaoTaos{ get; set; }
        public virtual DbSet<ChuyenNganhs> ChuyenNganhs{ get; set; }
        public virtual DbSet<GiangViens> GiangViens { get; set; }
        public virtual DbSet<KetQuaHocTaps> KetQuaHocTaps{ get; set; }
        public virtual DbSet<Khoas> Khoas { get; set; }
        public virtual DbSet<Nganhs> Nganhs{ get; set; }
        public virtual DbSet<SinhViens> SinhViens{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<LopHocs>()
                .Property(e => e.Id)
                .IsUnicode(false);
            modelBuilder.Entity<LopHocs>()
                .Property(e => e.MaLop)
                .IsUnicode(false);
            modelBuilder.Entity<LopHocs>()
                .Property(e => e.MaChuyenNganh)
                .IsUnicode(false);
            modelBuilder.Entity<LopHocs>()
                .Property(e => e.MaChuongTrinhDaoTao)
                .IsUnicode(false);

            modelBuilder.Entity<BoMons>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<BoMons>()
                .Property(e => e.MaBoMon)
                .IsUnicode(false);

            modelBuilder.Entity<BoMons>()
                .Property(e => e.MaKhoa)
                .IsUnicode(false);

            modelBuilder.Entity<ChuongTrinhDaoTaos>()
                .Property(e => e.Id)
                .IsUnicode(false);
            modelBuilder.Entity<ChuongTrinhDaoTaos>()
                .Property(e => e.MaChuongTrinhDaoTao)
                .IsUnicode(false);

            modelBuilder.Entity<ChuyenNganhs>()
                .Property(e => e.Id)
                .IsUnicode(false);
            modelBuilder.Entity<ChuyenNganhs>()
                .Property(e => e.MaChuyenNganh)
                .IsUnicode(false);
            modelBuilder.Entity<ChuyenNganhs>()
                .Property(e => e.MaNganh)
                .IsUnicode(false);


            modelBuilder.Entity<GiangViens>()
                .Property(e => e.Id)
                .IsUnicode(false);
            modelBuilder.Entity<GiangViens>()
               .Property(e => e.MaBoMon)
               .IsUnicode(false);
            modelBuilder.Entity<GiangViens>()
               .Property(e => e.MaGiangVien)
               .IsUnicode(false);

            modelBuilder.Entity<Khoas>()
                .Property(e => e.Id)
                .IsUnicode(false);
            modelBuilder.Entity<Khoas>()
                .Property(e => e.MaKhoa)
                .IsUnicode(false);

            modelBuilder.Entity<SinhViens>()
                .Property(e => e.Id)
                .IsUnicode(false);
            modelBuilder.Entity<SinhViens>()
               .Property(e => e.MaLop)
               .IsUnicode(false);
            modelBuilder.Entity<SinhViens>()
               .Property(e => e.MaSinhVien)
               .IsUnicode(false);

            modelBuilder.Entity<KetQuaHocTaps>()
               .Property(e => e.MaLop)
               .IsUnicode(false);
            modelBuilder.Entity<KetQuaHocTaps>()
               .Property(e => e.MaSinhVien)
               .IsUnicode(false);
            modelBuilder.Entity<KetQuaHocTaps>()
               .Property(e => e.Id)
               .IsUnicode(false);

            modelBuilder.Entity<Nganhs>()
               .Property(e => e.MaBoMon)
               .IsUnicode(false);
            modelBuilder.Entity<Nganhs>()
               .Property(e => e.MaNganh)
               .IsUnicode(false);
            modelBuilder.Entity<Nganhs>()
               .Property(e => e.Id)
               .IsUnicode(false);
        }
    }
}
