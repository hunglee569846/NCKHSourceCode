using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CreateDataBase.Models
{
    public partial class QLDADbCotext : DbContext
    {
        public QLDADbCotext()
            : base("name=QLDADbCotext")
        {
        }

        public virtual DbSet<Bo_Mon> Bo_Mon { get; set; }
        public virtual DbSet<Chuyen_Nganh> Chuyen_Nganh { get; set; }
        public virtual DbSet<Don_Vi> Don_Vi { get; set; }
        public virtual DbSet<Giang_Vien> Giang_Vien { get; set; }
        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<Lop> Lops { get; set; }
        public virtual DbSet<Nganh> Nganhs { get; set; }
        public virtual DbSet<Sinh_Vien> Sinh_Vien { get; set; }
        public virtual DbSet<Tai_Khoan> Tai_Khoan { get; set; }
        public virtual DbSet<De_Tai> De_Tais { get; set; }
        public virtual DbSet<Mon_Hoc> Mon_Hocs { get; set; }
        public virtual DbSet<De_Cuong> De_Cuongs { get; set; }
        public virtual DbSet<Bao_Cao> Bao_Caos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Khoa>()
                .Property(e => e.Ten_Khoa)
                .IsUnicode(false);

            modelBuilder.Entity<Khoa>()
                .Property(e => e.Dia_Chi)
                .IsUnicode(false);
        }
    }
}
