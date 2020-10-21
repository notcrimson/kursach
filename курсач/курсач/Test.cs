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
        [Column("Test ID")]
        public int Test_ID { get; set; }

        [Column("Name of PU")]
        [Required]
        [StringLength(50)]
        public string Name_of_PU { get; set; }

        [Column("Test name")]
        [Required]
        [StringLength(50)]
        public string Test_name { get; set; }

        public string Question { get; set; }

        public string Answers { get; set; }

        public virtual Professional_unit Professional_units { get; set; }

        public virtual Test_correct_answer Test_correct_answers { get; set; }
    }
}
