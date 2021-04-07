namespace CreateDBEduSoft.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChuongTrinhDaoTaos")]
    public partial class ChuongTrinhDaoTaos
    {
        
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(50)]
        public string MaChuongTrinhDaoTao { get; set; }

        [StringLength(300)]
        public string TenChuongTrinhDaoTao { get; set; }

        [Required]
        [StringLength(50)]
        public string HeDaoTao { get; set; }

        [Required]
        public int ThoiGianDaoTao { get; set; }

        [Required]
        public int SoTinChi { get; set; }

        public bool? IsDelete { get; set; }

        public bool? IsActive { get; set; }

    }
}
