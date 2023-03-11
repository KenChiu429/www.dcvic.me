namespace ContaminationOfRecyclable.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contamination")]
    public partial class Contamination
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(7)]
        public string period { get; set; }

        public double? contamination_rate { get; set; }
    }
}
