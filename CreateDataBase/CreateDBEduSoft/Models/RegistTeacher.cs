//namespace CreateDBEduSoft.Models
//{
//    using System;
//    using System.Collections.Generic;
//    using System.ComponentModel.DataAnnotations;
//    using System.ComponentModel.DataAnnotations.Schema;
//    using System.Data.Entity.Spatial;

//    [Table("RegistTeacher")]
//    public partial class RegistTeacher
//    {
//        [StringLength(50)]
//        public string id { get; set; }

//        [Required]
//        [StringLength(50)]
//        public string IdStudent { get; set; }

//        [Required]
//        [StringLength(50)]
//        public string IdTeacherMain { get; set; }

//        [StringLength(50)]
//        public string IdTeacher2 { get; set; }

//        [StringLength(50)]
//        public string IdTopic { get; set; }

//        [Column(TypeName = "datetime2")]
//        public DateTime? LastUpdate { get; set; }

//        [Column(TypeName = "datetime2")]
//        public DateTime? CreateDate { get; set; }

//        public bool? IsActive { get; set; }

//        public bool? IsDone { get; set; }

//        public virtual Student Student { get; set; }

//        public virtual Teacher Teacher { get; set; }

//        public virtual Teacher Teacher1 { get; set; }

//        public virtual Topic Topic { get; set; }
//    }
//}
