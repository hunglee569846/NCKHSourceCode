using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CreateDBEduSoft.Models
{
    [Table("KetQuaHocTap")]
    public class KetQuaHocTaps
    {
        [StringLength(50)]
        public string Id { get; set; }

        [Required]
        [StringLength(50)]
        public string MaSinhVien { get; set; }
        [Required]
        [StringLength(50)]
        public string MaLop { get; set; }
        [Required]
        public int TinChiTichLuy { get; set; }
        public int TinChiThieu { get; set; }
        [Required]
        public double DiemTBTichLuy { get; set; }

    }
}