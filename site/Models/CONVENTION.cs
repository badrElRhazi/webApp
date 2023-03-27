namespace site.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONVENTION")]
    public partial class CONVENTION
    {
        [Key]
        public int ID_CONVENTION { get; set; }

        public int ID_EMPLOYE { get; set; }

        [StringLength(30)]
        public string TYPE_CONVENTION { get; set; }

        [StringLength(30)]
        public string NOM_CONVENTION { get; set; }

        public DateTime? DATE_CONVENTION { get; set; }

        public virtual EMPLOYE EMPLOYE { get; set; }
    }
}
