namespace site.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AGENDA_DIRECTEUR
    {
        [Key]
        public int ID_AGENDADIRECTEUR { get; set; }

        public DateTime? DATE { get; set; }

        [StringLength(30)]
        public string TITRE { get; set; }

        public int ID_DIRECTEUR { get; set; }

        public virtual DIRECTEUR DIRECTEUR { get; set; }
    }
}
