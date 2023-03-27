namespace site.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FORMATEUR")]
    public partial class FORMATEUR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FORMATEUR()
        {
            PAIEMENT_FORMATEUR = new HashSet<PAIEMENT_FORMATEUR>();
            FORMATION_GROUPE = new HashSet<FORMATION_GROUPE>();
            FORMATION_INDIVIDUAL = new HashSet<FORMATION_INDIVIDUAL>();
        }

        [Key]
        public int ID_FORMATEUR { get; set; }

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
        public string CIN { get; set; }

        [StringLength(30)]
        public string DIPLOME { get; set; }

        [StringLength(30)]
        public string POSTE { get; set; }

        [StringLength(30)]
        public string FONCTION { get; set; }

        [StringLength(30)]
        public string SPECIALITE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAIEMENT_FORMATEUR> PAIEMENT_FORMATEUR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORMATION_GROUPE> FORMATION_GROUPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORMATION_INDIVIDUAL> FORMATION_INDIVIDUAL { get; set; }
    }
}
