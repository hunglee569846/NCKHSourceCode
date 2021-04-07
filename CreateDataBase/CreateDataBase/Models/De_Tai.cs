using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CreateDataBase.Models
{
    public class De_Tai
    {
        [Key]
        public int Ma_De_Tai { get; set; }
        public string Ten_De_Tai { get; set; }
        public bool Duyet_De_Tai { get; set; }
        public DateTime Ngay_Dang_Ky { get; set; }
        public bool Is_Active { get; set; }
        public bool Is_Delete { get; set; }
        public int Ma_Sinh_Vien { get; set; }
        [ForeignKey("Ma_Sinh_Vien")]
        public virtual Sinh_Vien Sinh_Vien { get; set; }
        public int Ma_Giang_Vien { get; set; }
        [ForeignKey("Ma_Giang_Vien")]
        public virtual Giang_Vien Giang_Vien { get; set; }
        public int Ma_Mon_Hoc { get; set; }
        [ForeignKey("Ma_Mon_Hoc")]
        public virtual Mon_Hoc Mon_Hoc { get; set; }

    }
}