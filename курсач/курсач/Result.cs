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
        public int ID { get; set; }

        [StringLength(50)]
        public string Student_login { get; set; }

        [Column("PU name")]
        [StringLength(50)]
        public string PU_name { get; set; }

        [Column("Test name")]
        [StringLength(50)]
        public string Test_name { get; set; }

        public string Answers { get; set; }

        public virtual Professional_unit Professional_units { get; set; }

        public virtual User User { get; set; }
    }
}
