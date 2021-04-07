namespace CreateDBEduSoft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDBedusoft : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BoMons",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaBoMon = c.String(maxLength: 50, unicode: false),
                        TenBoMon = c.String(nullable: false, maxLength: 300),
                        VanPhong = c.String(maxLength: 500),
                        DiaChi = c.String(maxLength: 500),
                        HomThu = c.String(),
                        DienThoai = c.String(maxLength: 11),
                        MaKhoa = c.String(nullable: false, maxLength: 50, unicode: false),
                        NgayTao = c.DateTime(precision: 7, storeType: "datetime2"),
                        NgayCapNhat = c.DateTime(storeType: "date"),
                        NgayXoa = c.DateTime(precision: 7, storeType: "datetime2"),
                        IsDelete = c.Boolean(),
                        IsActive = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ChuongTrinhDaoTaos",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaChuongTrinhDaoTao = c.String(maxLength: 50, unicode: false),
                        TenChuongTrinhDaoTao = c.String(maxLength: 300),
                        HeDaoTao = c.String(nullable: false, maxLength: 50),
                        ThoiGianDaoTao = c.Int(nullable: false),
                        SoTinChi = c.Int(nullable: false),
                        IsDelete = c.Boolean(),
                        IsActive = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ChuyenNganhs",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaChuyenNganh = c.String(nullable: false, maxLength: 50, unicode: false),
                        TenChuyenNganh = c.String(nullable: false, maxLength: 500),
                        VanPhong = c.String(maxLength: 300),
                        HopThu = c.String(maxLength: 300),
                        DienThoai = c.String(maxLength: 11),
                        DiaChi = c.String(maxLength: 500),
                        GhiChu = c.String(maxLength: 500),
                        MaNganh = c.String(nullable: false, maxLength: 50, unicode: false),
                        NgayCapNhat = c.DateTime(precision: 7, storeType: "datetime2"),
                        NgayTao = c.DateTime(precision: 7, storeType: "datetime2"),
                        IsDelete = c.Boolean(),
                        IsActive = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GiangViens",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaGiangVien = c.String(nullable: false, maxLength: 50, unicode: false),
                        HoDem = c.String(maxLength: 200),
                        Ten = c.String(maxLength: 50),
                        HoTen = c.String(nullable: false, maxLength: 50),
                        HomThu = c.String(nullable: false),
                        MaBoMon = c.String(maxLength: 50, unicode: false),
                        GhiChu = c.String(),
                        DonViCongTac = c.String(maxLength: 500),
                        DienThoai = c.String(maxLength: 11),
                        SoDeTai = c.Int(),
                        NgayTao = c.DateTime(precision: 7, storeType: "datetime2"),
                        NgayCapNhat = c.DateTime(precision: 7, storeType: "datetime2"),
                        IsDelete = c.Boolean(),
                        IsActive = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.KetQuaHocTap",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaSinhVien = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaLop = c.String(nullable: false, maxLength: 50, unicode: false),
                        TinChiTichLuy = c.Int(nullable: false),
                        TinChiThieu = c.Int(nullable: false),
                        DiemTBTichLuy = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Khoas",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaKhoa = c.String(maxLength: 50, unicode: false),
                        TenKhoa = c.String(nullable: false, maxLength: 300),
                        IsDelete = c.Boolean(),
                        IsActive = c.Boolean(),
                        NgayTao = c.String(),
                        NgayCapNhat = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LopHocs",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaLop = c.String(nullable: false, maxLength: 50, unicode: false),
                        TenLop = c.String(nullable: false, maxLength: 500),
                        MaChuyenNganh = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaChuongTrinhDaoTao = c.String(nullable: false, maxLength: 50, unicode: false),
                        NienKhoa = c.String(maxLength: 50),
                        NgayTao = c.DateTime(precision: 7, storeType: "datetime2"),
                        NgayCapNhat = c.DateTime(precision: 7, storeType: "datetime2"),
                        IsDelete = c.Boolean(),
                        IsActive = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Nganhs",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaNganh = c.String(maxLength: 50, unicode: false),
                        TenNganh = c.String(nullable: false, maxLength: 500),
                        MaBoMon = c.String(nullable: false, maxLength: 50, unicode: false),
                        NgayTao = c.DateTime(precision: 7, storeType: "datetime2"),
                        IsDelete = c.Boolean(),
                        IsActive = c.Boolean(),
                        NgayCapNhat = c.DateTime(precision: 7, storeType: "datetime2"),
                        Deletetime = c.DateTime(precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SinhViens",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaSinhVien = c.String(nullable: false, maxLength: 50, unicode: false),
                        HoDem = c.String(maxLength: 50),
                        Ten = c.String(maxLength: 50),
                        HoTen = c.String(nullable: false, maxLength: 50),
                        HomThu = c.String(nullable: false),
                        MaLop = c.String(nullable: false, maxLength: 50, unicode: false),
                        DienThoai = c.String(maxLength: 11),
                        NgayTao = c.DateTime(precision: 7, storeType: "datetime2"),
                        IsDelete = c.Boolean(),
                        IsActive = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SinhViens");
            DropTable("dbo.Nganhs");
            DropTable("dbo.LopHocs");
            DropTable("dbo.Khoas");
            DropTable("dbo.KetQuaHocTap");
            DropTable("dbo.GiangViens");
            DropTable("dbo.ChuyenNganhs");
            DropTable("dbo.ChuongTrinhDaoTaos");
            DropTable("dbo.BoMons");
        }
    }
}
