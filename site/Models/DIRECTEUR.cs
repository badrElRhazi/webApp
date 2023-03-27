namespace site.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DIRECTEUR")]
    public partial class DIRECTEUR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIRECTEUR()
        {
            AGENDA_DIRECTEUR = new HashSet<AGENDA_DIRECTEUR>();
            PAIEMENT_DIRECTEUR = new HashSet<PAIEMENT_DIRECTEUR>();
        }

        [Key]
        public int ID_DIRECTEUR { get; set; }

        [StringLength(30)]
        public string NOM { get; set; }

        [StringLength(30)]
        public string PRENOM { get; set; }

        public DateTime? DATE_NAISSANCE { get; set; }

        [StringLength(30)]
        public string LIEU_NAISSANCE { get; set; }

        [StringLength(30)]
        public string ADRESSE { get; set; }

        [StringLength(30)]
        public string TELEPHONE { get; set; }

        [StringLength(30)]
        public string EMAIL { get; set; }

        [StringLength(30)]
        public string DIPLOME { get; set; }

        [StringLength(30)]
        public string CIN { get; set; }

        [StringLength(30)]
        public string Mot_De_Passe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AGENDA_DIRECTEUR> AGENDA_DIRECTEUR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAIEMENT_DIRECTEUR> PAIEMENT_DIRECTEUR { get; set; }
    }
}
