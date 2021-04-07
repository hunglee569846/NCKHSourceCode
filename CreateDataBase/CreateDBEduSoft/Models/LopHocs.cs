namespace CreateDBEduSoft.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LopHocs")]
    public partial class LopHocs
    {
        

        [StringLength(50)]
        public string Id { get; set; }

        [Required]
        [StringLength(50)]
        public string MaLop { get; set; }

        [Required]
        [StringLength(500)]
        public string TenLop { get; set; }

        [Required]
        [StringLength(50)]
        public string MaChuyenNganh { get; set; }

        [Required]
        [StringLength(50)]
        public string MaChuongTrinhDaoTao { get; set; }

        [StringLength(50)]
        public string NienKhoa { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? NgayTao { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public bool? IsActive { get; set; }
    }
}
