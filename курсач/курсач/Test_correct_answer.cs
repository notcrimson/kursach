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
        public int ID { get; set; }

        [Column("Name of PU")]
        [StringLength(50)]
        public string Name_of_PU { get; set; }

        [Column("Test name")]
        [Required]
        [StringLength(50)]
        public string Test_name { get; set; }

        [Column("Correct answers")]
        public string Correct_answers { get; set; }

        public virtual Professional_unit Professional_units { get; set; }
    }
}
