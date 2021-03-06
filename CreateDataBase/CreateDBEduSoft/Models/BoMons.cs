namespace CreateDBEduSoft.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BoMons")]
    public partial class BoMons
    {

        [Key]
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(50)]
        public string MaBoMon { get; set; }

        [Required]
        [StringLength(300)]
        public string TenBoMon { get; set; }

        [StringLength(500)]
        public string VanPhong { get; set; }

        [StringLength(500)]
        public string DiaChi { get; set; }

        [EmailAddress]
        public string HomThu { get; set; }

        [StringLength(11)]
        public string DienThoai { get; set; }

        [Required]
        [StringLength(50)]
        public string MaKhoa { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? NgayTao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCapNhat { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? NgayXoa { get; set; }

        public bool? IsDelete { get; set; }

        public bool? IsActive { get; set; }

    }
}
