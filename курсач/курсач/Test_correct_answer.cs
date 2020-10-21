namespace курсач
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Test correct answers")]
    public partial class Test_correct_answer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Test_correct_answer()
        {
            Results = new HashSet<Result>();
            Tests = new HashSet<Test>();
        }

        [Key]
        [Column("Test name")]
        [StringLength(50)]
        public string Test_name { get; set; }

        [Column("Name of PU")]
        [Required]
        [StringLength(50)]
        public string Name_of_PU { get; set; }

        [Column("Correct answers")]
        public string Correct_answers { get; set; }

        public virtual Professional_unit Professional_units { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Result> Results { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Test> Tests { get; set; }
    }
}
