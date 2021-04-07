namespace CreateDataBase.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bo_Mon
    {
        [Key]
        public int Ma_Bo_Mon { get; set; }

        public string Ten_Bo_Mon { get; set; }

        public string Dia_Chi { get; set; }

        public bool Is_Active { get; set; }

        public bool Is_Delete { get; set; }
        public int Ma_Khoa { get; set; }
        [ForeignKey("Ma_Khoa")]
        public virtual Khoa Khoas { get; set; }
    }
}
