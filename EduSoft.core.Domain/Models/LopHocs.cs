using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CreateDBEduSoft.Models
{
    public partial class LopHocs
    {
        public string Id { get; set; }
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public string MaChuyenNganh { get; set; }
        public string MaChuongTrinhDaoTao { get; set; }
        public string NienKhoa { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsActive { get; set; }
    }
}
