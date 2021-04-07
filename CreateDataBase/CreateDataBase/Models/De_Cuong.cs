using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CreateDataBase.Models
{
    public class De_Cuong
    {
        [Key]
        public int Ma_De_Cuong { get; set; }
        public string Ten_De_Cuong { get; set; }
        public int Diem_So { get; set; }
        public string Danh_Gia { get; set; }
        public bool GVHD_Duyet { get; set; }
        public DateTime Ngay_Nop { get; set; }
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