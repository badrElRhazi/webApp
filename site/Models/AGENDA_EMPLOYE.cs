namespace site.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AGENDA_EMPLOYE
    {
        [Key]
        public int ID_AGENDAEMPLOYE { get; set; }

        public DateTime? DATE { get; set; }

        [StringLength(30)]
        public string TITRE { get; set; }

        public int? ID_EMPLOYE { get; set; }

        public virtual EMPLOYE EMPLOYE { get; set; }
    }
}
