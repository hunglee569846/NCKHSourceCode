namespace CreateDataBase.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Don_Vi
    {
        [Key]
        public int Ma_Don_Vi { get; set; }

        public string Ten_Don_Vi { get; set; }

        public string Dia_Chi { get; set; }

        public bool Is_Active { get; set; }

        public bool Is_Delete { get; set; }
        public int So_Dien_Thoai { get; set; }
        public bool Loai_Don_Vi { get; set; }
        public int? Ma_Bo_Mon { get; set; }
        [ForeignKey("Ma_Bo_Mon")]
        public virtual Bo_Mon Bo_Mon { get; set; }
    }
}
