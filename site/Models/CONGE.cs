namespace site.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONGE")]
    public partial class CONGE
    {
        [Key]
        public int ID_CONGE { get; set; }

        public int ID_EMPLOYE { get; set; }

        public DateTime? DATE_DEBUT { get; set; }

        public DateTime? DATE_FIN { get; set; }

        public int? DURE { get; set; }

        public virtual EMPLOYE EMPLOYE { get; set; }
    }
}
