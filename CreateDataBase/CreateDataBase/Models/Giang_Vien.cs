namespace CreateDataBase.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Giang_Vien
    {
        [Key]
        public int Ma_Giang_Vien { get; set; }

        public string Ten_Giang_Vien { get; set; }

        public int So_Dien_Thoai { get; set; }

        public string Email { get; set; }
        public string Chuyen_Mon { get; set; }

        public int SL_SV_TT { get; set; }

        public int SL_SV_DK { get; set; }

        public bool Is_Full { get; set; }

        public bool Is_Active { get; set; }

        public bool Is_Delete { get; set; }
        public int Ma_Don_Vi { get; set; }
        [ForeignKey("Ma_Don_Vi")]
        public virtual Don_Vi Don_Vi { get; set; }
        public int Ma_Tai_Khoan { get; set; }
        [ForeignKey("Ma_Tai_Khoan")]
        public virtual Tai_Khoan Tai_Khoan { get; set; }
    }
}
