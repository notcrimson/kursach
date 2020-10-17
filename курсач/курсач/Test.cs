namespace курсач
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Test
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Test()
        {
            Results = new HashSet<Result>();
            Test_correct_answers = new HashSet<Test_correct_answer>();
        }

        [Key]
        [Column("Test name")]
        [StringLength(50)]
        public string Test_name { get; set; }

        [Column("Name of PU")]
        [Required]
        [StringLength(50)]
        public string Name_of_PU { get; set; }

        [Column("Number of questions")]
        public int? Number_of_questions { get; set; }

        public string Answers { get; set; }

        [StringLength(50)]
        public string Student_login { get; set; }

        public virtual Professional_unit Professional_units { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Result> Results { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Test_correct_answer> Test_correct_answers { get; set; }

        public virtual User User { get; set; }
    }
}
