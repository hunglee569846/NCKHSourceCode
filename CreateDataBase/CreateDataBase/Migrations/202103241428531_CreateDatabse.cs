namespace CreateDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatabse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bao_Cao",
                c => new
                    {
                        Ma_Bao_Cao = c.Int(nullable: false, identity: true),
                        Ten_Bao_Cao = c.String(),
                        Diem_So = c.Int(nullable: false),
                        Danh_Gia = c.String(),
                        GVHD_Duyet = c.Boolean(nullable: false),
                        Ngay_Nop = c.DateTime(nullable: false),
                        Is_Active = c.Boolean(nullable: false),
                        Is_Delete = c.Boolean(nullable: false),
                        Ma_Sinh_Vien = c.Int(nullable: false),
                        Ma_Giang_Vien = c.Int(nullable: false),
                        Ma_Mon_Hoc = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Ma_Bao_Cao)
                .ForeignKey("dbo.Giang_Vien", t => t.Ma_Giang_Vien, cascadeDelete: true)
                .ForeignKey("dbo.Mon_Hoc", t => t.Ma_Mon_Hoc, cascadeDelete: true)
                .ForeignKey("dbo.Sinh_Vien", t => t.Ma_Sinh_Vien, cascadeDelete: true)
                .Index(t => t.Ma_Sinh_Vien)
                .Index(t => t.Ma_Giang_Vien)
                .Index(t => t.Ma_Mon_Hoc);
            
            CreateTable(
                "dbo.Giang_Vien",
                c => new
                    {
                        Ma_Giang_Vien = c.Int(nullable: false, identity: true),
                        Ten_Giang_Vien = c.String(),
                        So_Dien_Thoai = c.Int(nullable: false),
                        Email = c.String(),
                        Chuyen_Mon = c.String(),
                        SL_SV_TT = c.Int(nullable: false),
                        SL_SV_DK = c.Int(nullable: false),
                        Is_Full = c.Boolean(nullable: false),
                        Is_Active = c.Boolean(nullable: false),
                        Is_Delete = c.Boolean(nullable: false),
                        Ma_Don_Vi = c.Int(nullable: false),
                        Ma_Tai_Khoan = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Ma_Giang_Vien)
                .ForeignKey("dbo.Don_Vi", t => t.Ma_Don_Vi, cascadeDelete: true)
                .ForeignKey("dbo.Tai_Khoan", t => t.Ma_Tai_Khoan, cascadeDelete: true)
                .Index(t => t.Ma_Don_Vi)
                .Index(t => t.Ma_Tai_Khoan);
            
            CreateTable(
                "dbo.Don_Vi",
                c => new
                    {
                        Ma_Don_Vi = c.Int(nullable: false, identity: true),
                        Ten_Don_Vi = c.String(),
                        Dia_Chi = c.String(),
                        Is_Active = c.Boolean(nullable: false),
                        Is_Delete = c.Boolean(nullable: false),
                        So_Dien_Thoai = c.Int(nullable: false),
                        Loai_Don_Vi = c.Boolean(nullable: false),
                        Ma_Bo_Mon = c.Int(),
                    })
                .PrimaryKey(t => t.Ma_Don_Vi)
                .ForeignKey("dbo.Bo_Mon", t => t.Ma_Bo_Mon)
                .Index(t => t.Ma_Bo_Mon);
            
            CreateTable(
                "dbo.Bo_Mon",
                c => new
                    {
                        Ma_Bo_Mon = c.Int(nullable: false, identity: true),
                        Ten_Bo_Mon = c.String(),
                        Dia_Chi = c.String(),
                        Is_Active = c.Boolean(nullable: false),
                        Is_Delete = c.Boolean(nullable: false),
                        Ma_Khoa = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Ma_Bo_Mon)
                .ForeignKey("dbo.Khoas", t => t.Ma_Khoa, cascadeDelete: true)
                .Index(t => t.Ma_Khoa);
            
            CreateTable(
                "dbo.Khoas",
                c => new
                    {
                        Ma_Khoa = c.Int(nullable: false, identity: true),
                        Ten_Khoa = c.String(unicode: false),
                        Dia_Chi = c.String(unicode: false),
                        Is_Active = c.Boolean(nullable: false),
                        Is_Delete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Ma_Khoa);
            
            CreateTable(
                "dbo.Tai_Khoan",
                c => new
                    {
                        Ma_Tai_Khoan = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Ten_Tai_Khoan = c.String(),
                        Password = c.String(),
                        Phan_Quyen = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Ma_Tai_Khoan);
            
            CreateTable(
                "dbo.Mon_Hoc",
                c => new
                    {
                        Ma_Mon_Hoc = c.Int(nullable: false, identity: true),
                        Ten_Mon_Hoc = c.String(),
                        Ngay_Bat_Dau = c.DateTime(nullable: false),
                        Ngay_Ket_Thuc = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ma_Mon_Hoc);

            CreateTable(
                "dbo.Sinh_Vien",
                c => new
                {
                    Ma_Sinh_Vien = c.Int(nullable: false, identity: true),
                    Ten_Sinh_Vien = c.String(),
                    So_Dien_Thoai = c.Int(nullable: false),
                    Email = c.String(),
                    Is_Active = c.Boolean(nullable: false),
                    Is_Delete = c.Boolean(nullable: false),
                    Ma_Lop = c.Int(nullable: false),
                    // Ma_Tai_Khoan = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Ma_Sinh_Vien)
                .ForeignKey("dbo.Lops", t => t.Ma_Lop, cascadeDelete: true)
                //.ForeignKey("dbo.Tai_Khoan", t => t.Ma_Tai_Khoan, cascadeDelete: true)
                .Index(t => t.Ma_Lop);
                //.Index(t => t.Ma_Tai_Khoan);
            
            CreateTable(
                "dbo.Lops",
                c => new
                    {
                        Ma_Lop = c.Int(nullable: false, identity: true),
                        Ten_Lop = c.String(),
                        Nien_Khoa = c.Int(nullable: false),
                        He_Dao_Tao = c.String(),
                        Is_Active = c.Boolean(nullable: false),
                        Is_Delete = c.Boolean(nullable: false),
                        Ma_Chuyen_Nganh = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Ma_Lop)
                .ForeignKey("dbo.Chuyen_Nganh", t => t.Ma_Chuyen_Nganh, cascadeDelete: true)
                .Index(t => t.Ma_Chuyen_Nganh);
            
            CreateTable(
                "dbo.Chuyen_Nganh",
                c => new
                    {
                        Ma_Chuyen_Nganh = c.Int(nullable: false, identity: true),
                        Ten_Chuyen_Nganh = c.String(),
                        Dia_Chi = c.String(),
                        Is_Active = c.Boolean(nullable: false),
                        Is_Delete = c.Boolean(nullable: false),
                        Ma_Nganh = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Ma_Chuyen_Nganh)
                .ForeignKey("dbo.Nganhs", t => t.Ma_Nganh, cascadeDelete: true)
                .Index(t => t.Ma_Nganh);
            
            CreateTable(
                "dbo.Nganhs",
                c => new
                    {
                        Ma_Nganh = c.Int(nullable: false, identity: true),
                        Ten_Nganh = c.String(),
                        Dia_Chi = c.String(),
                        Is_Active = c.Boolean(nullable: false),
                        Is_Delete = c.Boolean(nullable: false),
                        Ma_Bo_Mon = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Ma_Nganh)
                .ForeignKey("dbo.Bo_Mon", t => t.Ma_Bo_Mon, cascadeDelete: true)
                .Index(t => t.Ma_Bo_Mon);
            
            CreateTable(
                "dbo.De_Cuong",
                c => new
                    {
                        Ma_De_Cuong = c.Int(nullable: false, identity: true),
                        Ten_De_Cuong = c.String(),
                        Diem_So = c.Int(nullable: false),
                        Danh_Gia = c.String(),
                        GVHD_Duyet = c.Boolean(nullable: false),
                        Ngay_Nop = c.DateTime(nullable: false),
                        Is_Active = c.Boolean(nullable: false),
                        Is_Delete = c.Boolean(nullable: false),
                        Ma_Sinh_Vien = c.Int(nullable: false),
                        Ma_Giang_Vien = c.Int(nullable: false),
                        Ma_Mon_Hoc = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Ma_De_Cuong)
                .ForeignKey("dbo.Giang_Vien", t => t.Ma_Giang_Vien, cascadeDelete: true)
                .ForeignKey("dbo.Mon_Hoc", t => t.Ma_Mon_Hoc, cascadeDelete: true)
                .ForeignKey("dbo.Sinh_Vien", t => t.Ma_Sinh_Vien, cascadeDelete: true)
                .Index(t => t.Ma_Sinh_Vien)
                .Index(t => t.Ma_Giang_Vien)
                .Index(t => t.Ma_Mon_Hoc);
            
            CreateTable(
                "dbo.De_Tai",
                c => new
                    {
                        Ma_De_Tai = c.Int(nullable: false, identity: true),
                        Ten_De_Tai = c.String(),
                        Duyet_De_Tai = c.Boolean(nullable: false),
                        Ngay_Dang_Ky = c.DateTime(nullable: false),
                        Is_Active = c.Boolean(nullable: false),
                        Is_Delete = c.Boolean(nullable: false),
                        Ma_Sinh_Vien = c.Int(nullable: false),
                        Ma_Giang_Vien = c.Int(nullable: false),
                        Ma_Mon_Hoc = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Ma_De_Tai)
                .ForeignKey("dbo.Giang_Vien", t => t.Ma_Giang_Vien, cascadeDelete: true)
                .ForeignKey("dbo.Mon_Hoc", t => t.Ma_Mon_Hoc, cascadeDelete: true)
                .ForeignKey("dbo.Sinh_Vien", t => t.Ma_Sinh_Vien, cascadeDelete: true)
                .Index(t => t.Ma_Sinh_Vien)
                .Index(t => t.Ma_Giang_Vien)
                .Index(t => t.Ma_Mon_Hoc);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.De_Tai", "Ma_Sinh_Vien", "dbo.Sinh_Vien");
            DropForeignKey("dbo.De_Tai", "Ma_Mon_Hoc", "dbo.Mon_Hoc");
            DropForeignKey("dbo.De_Tai", "Ma_Giang_Vien", "dbo.Giang_Vien");
            DropForeignKey("dbo.De_Cuong", "Ma_Sinh_Vien", "dbo.Sinh_Vien");
            DropForeignKey("dbo.De_Cuong", "Ma_Mon_Hoc", "dbo.Mon_Hoc");
            DropForeignKey("dbo.De_Cuong", "Ma_Giang_Vien", "dbo.Giang_Vien");
            DropForeignKey("dbo.Bao_Cao", "Ma_Sinh_Vien", "dbo.Sinh_Vien");
            DropForeignKey("dbo.Sinh_Vien", "Ma_Tai_Khoan", "dbo.Tai_Khoan");
            DropForeignKey("dbo.Sinh_Vien", "Ma_Lop", "dbo.Lops");
            DropForeignKey("dbo.Lops", "Ma_Chuyen_Nganh", "dbo.Chuyen_Nganh");
            DropForeignKey("dbo.Chuyen_Nganh", "Ma_Nganh", "dbo.Nganhs");
            DropForeignKey("dbo.Nganhs", "Ma_Bo_Mon", "dbo.Bo_Mon");
            DropForeignKey("dbo.Bao_Cao", "Ma_Mon_Hoc", "dbo.Mon_Hoc");
            DropForeignKey("dbo.Bao_Cao", "Ma_Giang_Vien", "dbo.Giang_Vien");
            DropForeignKey("dbo.Giang_Vien", "Ma_Tai_Khoan", "dbo.Tai_Khoan");
            DropForeignKey("dbo.Giang_Vien", "Ma_Don_Vi", "dbo.Don_Vi");
            DropForeignKey("dbo.Don_Vi", "Ma_Bo_Mon", "dbo.Bo_Mon");
            DropForeignKey("dbo.Bo_Mon", "Ma_Khoa", "dbo.Khoas");
            DropIndex("dbo.De_Tai", new[] { "Ma_Mon_Hoc" });
            DropIndex("dbo.De_Tai", new[] { "Ma_Giang_Vien" });
            DropIndex("dbo.De_Tai", new[] { "Ma_Sinh_Vien" });
            DropIndex("dbo.De_Cuong", new[] { "Ma_Mon_Hoc" });
            DropIndex("dbo.De_Cuong", new[] { "Ma_Giang_Vien" });
            DropIndex("dbo.De_Cuong", new[] { "Ma_Sinh_Vien" });
            DropIndex("dbo.Nganhs", new[] { "Ma_Bo_Mon" });
            DropIndex("dbo.Chuyen_Nganh", new[] { "Ma_Nganh" });
            DropIndex("dbo.Lops", new[] { "Ma_Chuyen_Nganh" });
            DropIndex("dbo.Sinh_Vien", new[] { "Ma_Tai_Khoan" });
            DropIndex("dbo.Sinh_Vien", new[] { "Ma_Lop" });
            DropIndex("dbo.Bo_Mon", new[] { "Ma_Khoa" });
            DropIndex("dbo.Don_Vi", new[] { "Ma_Bo_Mon" });
            DropIndex("dbo.Giang_Vien", new[] { "Ma_Tai_Khoan" });
            DropIndex("dbo.Giang_Vien", new[] { "Ma_Don_Vi" });
            DropIndex("dbo.Bao_Cao", new[] { "Ma_Mon_Hoc" });
            DropIndex("dbo.Bao_Cao", new[] { "Ma_Giang_Vien" });
            DropIndex("dbo.Bao_Cao", new[] { "Ma_Sinh_Vien" });
            DropTable("dbo.De_Tai");
            DropTable("dbo.De_Cuong");
            DropTable("dbo.Nganhs");
            DropTable("dbo.Chuyen_Nganh");
            DropTable("dbo.Lops");
            DropTable("dbo.Sinh_Vien");
            DropTable("dbo.Mon_Hoc");
            DropTable("dbo.Tai_Khoan");
            DropTable("dbo.Khoas");
            DropTable("dbo.Bo_Mon");
            DropTable("dbo.Don_Vi");
            DropTable("dbo.Giang_Vien");
            DropTable("dbo.Bao_Cao");
        }
    }
}
