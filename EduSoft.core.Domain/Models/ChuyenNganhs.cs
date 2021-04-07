using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CreateDBEduSoft.Models
{
    public partial class ChuyenNganhs
    {
        public string Id { get; set; }
        public string MaChuyenNganh { get; set; }
        public string TenChuyenNganh { get; set; }
        public string VanPhong { get; set; }
        public string HopThu { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }
        public string GhiChu { get; set; }
        public string MaNganh { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public DateTime? NgayTao { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsActive { get; set; }

      
    }
}
