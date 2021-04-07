using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CreateDBEduSoft.Models
{
    public partial class Nganhs
    {
        public string Id { get; set; }
        public string MaNganh { get; set; }
        public string TenNganh { get; set; }
        public string MaBoMon { get; set; }
        public DateTime? NgayTao { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public DateTime? Deletetime { get; set; }

    }
}
