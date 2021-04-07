namespace CreateDataBase.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sinh_Vien
    {
        [Key]
        public int Ma_Sinh_Vien { get; set; }

        public string Ten_Sinh_Vien { get; set; }

        public int So_Dien_Thoai { get; set; }

        public string Email { get; set; }

        public bool Is_Active { get; set; }

        public bool Is_Delete { get; set; }
        public int Ma_Lop { get; set; }
        [ForeignKey("Ma_Lop")]
        public virtual Lop Lop { get; set; }
        public int Ma_Tai_Khoan { get; set; }
        [ForeignKey("Ma_Tai_Khoan")]
        public virtual Tai_Khoan Tai_Khoan { get; set; }
    }
}
