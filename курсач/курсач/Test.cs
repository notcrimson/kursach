namespace курсач
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Test
    {
        [Key]
        [Column("Name of PU")]
        [StringLength(50)]
        public string Name_of_PU { get; set; }

        [Column("Test name")]
        [Required]
        [StringLength(50)]
        public string Test_name { get; set; }

        [Column("Number of questions")]
        public int? Number_of_questions { get; set; }

        public string Answers { get; set; }

        [StringLength(50)]
        public string Student_login { get; set; }

        public virtual Professional_unit Professional_units { get; set; }

        public virtual User User { get; set; }
    }
}
