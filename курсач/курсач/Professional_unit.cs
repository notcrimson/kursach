namespace курсач
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Professional units")]
    public partial class Professional_unit
    {
        [Key]
        [Column("Name of PU")]
        [StringLength(50)]
        public string Name_of_PU { get; set; }

        public byte[] ContentOfPU { get; set; }
    }
}
