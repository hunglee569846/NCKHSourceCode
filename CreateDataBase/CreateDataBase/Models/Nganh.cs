namespace CreateDataBase.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Nganh
    {
        [Key]
        public int Ma_Nganh { get; set; }

        public string Ten_Nganh { get; set; }

        public string Dia_Chi { get; set; }

        public bool Is_Active { get; set; }

        public bool Is_Delete { get; set; }
        public int Ma_Bo_Mon { get; set; }
        [ForeignKey("Ma_Bo_Mon")]
        public virtual Bo_Mon Bo_Mon { get; set; }
    }
}
