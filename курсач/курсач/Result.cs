namespace курсач
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Result")]
    public partial class Result
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Result()
        {
            Student_profile = new HashSet<Student_profile>();
        }

        public int ID { get; set; }

        [Column("PU name")]
        [StringLength(50)]
        public string PU_name { get; set; }

        [Column("Test name")]
        [StringLength(50)]
        public string Test_name { get; set; }

        public string Answers { get; set; }

        public virtual Professional_unit Professional_units { get; set; }

        public virtual Test Test { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_profile> Student_profile { get; set; }
    }
}
