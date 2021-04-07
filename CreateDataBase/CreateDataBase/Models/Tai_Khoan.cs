namespace CreateDataBase.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tai_Khoan
    {
        [Key]
        public int Ma_Tai_Khoan { get; set; }

        public string Email { get; set; }

        public string Ten_Tai_Khoan { get; set; }

        public string Password { get; set; }
        public int Phan_Quyen { get; set; }
    }
}
