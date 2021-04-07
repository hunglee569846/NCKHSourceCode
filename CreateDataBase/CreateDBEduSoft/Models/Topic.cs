//namespace CreateDBEduSoft.Models
//{
//    using System;
//    using System.Collections.Generic;
//    using System.ComponentModel.DataAnnotations;
//    using System.ComponentModel.DataAnnotations.Schema;
//    using System.Data.Entity.Spatial;

//    public partial class Topic
//    {
//        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
//        public Topic()
//        {
//            RegistTeachers = new HashSet<RegistTeacher>();
//        }

//        [StringLength(50)]
//        public string Id { get; set; }

//        [Required]
//        [StringLength(50)]
//        public string IdTopics { get; set; }

//        [Required]
//        [StringLength(500)]
//        public string NameTopics { get; set; }

//        [Required]
//        [StringLength(50)]
//        public string IdStudent { get; set; }

//        [StringLength(200)]
//        public string NameStudent { get; set; }

//        [Required]
//        [StringLength(50)]
//        public string IdTeacherMain { get; set; }

//        [StringLength(200)]
//        public string NameTeacherMain { get; set; }

//        [StringLength(50)]
//        public string IdTeacher2 { get; set; }

//        [StringLength(200)]
//        public string NameTeacher2 { get; set; }

//        public bool? IsApproval { get; set; }

//        [Column(TypeName = "datetime2")]
//        public DateTime? CreateDate { get; set; }

//        [Column(TypeName = "datetime2")]
//        public DateTime? LastUpdate { get; set; }

//        public bool? IsDelete { get; set; }

//        public bool? IsActive { get; set; }

//        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
//        public virtual ICollection<RegistTeacher> RegistTeachers { get; set; }
//    }
//}
