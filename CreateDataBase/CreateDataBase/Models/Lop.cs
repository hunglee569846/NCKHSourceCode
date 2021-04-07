namespace CreateDataBase.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lop
    {
        [Key]
        public int Ma_Lop { get; set; }

        public string Ten_Lop { get; set; }

        public int Nien_Khoa { get; set; }

        public string He_Dao_Tao { get; set; }

        public bool Is_Active { get; set; }

        public bool Is_Delete { get; set; }
        public int Ma_Chuyen_Nganh { get; set; }
        [ForeignKey("Ma_Chuyen_Nganh")]
        public virtual Chuyen_Nganh Chuyen_Nganh { get; set; }
    }
}
