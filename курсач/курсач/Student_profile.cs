namespace курсач
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student_profile
    {
        [Key]
        [StringLength(50)]
        public string Student_login { get; set; }

        [Column("PU learned")]
        [StringLength(20)]
        public string PU_learned { get; set; }

        [Column("Correct tests")]
        [StringLength(20)]
        public string Correct_tests { get; set; }

        [Column("Time entered")]
        public TimeSpan? Time_entered { get; set; }

        [Column("Time exited")]
        public TimeSpan? Time_exited { get; set; }

        public virtual User User { get; set; }
    }
}
