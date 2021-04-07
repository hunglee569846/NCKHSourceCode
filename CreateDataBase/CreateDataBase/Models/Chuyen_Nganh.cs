namespace CreateDataBase.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Chuyen_Nganh
    {
        [Key]
        public int Ma_Chuyen_Nganh { get; set; }

        public string Ten_Chuyen_Nganh { get; set; }

        public string Dia_Chi { get; set; }

        public bool Is_Active { get; set; }

        public bool Is_Delete { get; set; }
        public int Ma_Nganh { get; set; }
        [ForeignKey("Ma_Nganh")]
        public virtual Nganh Nganhs { get; set; }
    }
}
