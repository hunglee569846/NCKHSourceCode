namespace CreateDBEduSoft.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Nganhs")]
    public partial class Nganhs
    {
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(50)]
        public string MaNganh { get; set; }

        [Required]
        [StringLength(500)]
        public string TenNganh { get; set; }

        [Required]
        [StringLength(50)]
        public string MaBoMon { get; set; }


        [Column(TypeName = "datetime2")]
        public DateTime? NgayTao { get; set; }

        public bool? IsDelete { get; set; }

        public bool? IsActive { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? NgayCapNhat { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Deletetime { get; set; }

    }
}
