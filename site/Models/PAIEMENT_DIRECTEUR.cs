namespace site.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PAIEMENT_DIRECTEUR
    {
        [Key]
        public int ID_PAIEMENTDIRECTEUR { get; set; }

        public int ID_DIRECTEUR { get; set; }

        public int? SALAIRE { get; set; }

        public int? PRIME { get; set; }

        public int? SALAIREPRIME { get; set; }

        [StringLength(30)]
        public string REGLEMENT { get; set; }

        public DateTime? DATE_P { get; set; }

        public virtual DIRECTEUR DIRECTEUR { get; set; }
    }
}
