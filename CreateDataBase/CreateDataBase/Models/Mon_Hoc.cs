using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CreateDataBase.Models
{
    public class Mon_Hoc
    {
        [Key]
        public int Ma_Mon_Hoc { get; set; }
        public string Ten_Mon_Hoc { get; set; }
        public DateTime Ngay_Bat_Dau { get; set; }
        public DateTime Ngay_Ket_Thuc { get; set; }

    }
}