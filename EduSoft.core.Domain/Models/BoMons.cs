namespace CreateDBEduSoft.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class BoMons
    {
        public string Id { get; set; }
        public string MaBoMon { get; set; }
        public string TenBoMon { get; set; }
        public string VanPhong { get; set; }
        public string DiaChi { get; set; }
        public string HomThu { get; set; }
        public string DienThoai { get; set; }
        public string MaKhoa { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public DateTime? NgayXoa { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsActive { get; set; }
        public BoMons()
        {
            IsDelete = false;
            IsActive = true;
            NgayTao = DateTime.Now;
            NgayXoa = null;
            NgayCapNhat = null;
        }

    }
}
