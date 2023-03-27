namespace site.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EMPLOYE")]
    public partial class EMPLOYE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMPLOYE()
        {
            AGENDA_EMPLOYE = new HashSet<AGENDA_EMPLOYE>();
            CONGE = new HashSet<CONGE>();
            CONVENTION = new HashSet<CONVENTION>();
            EQUIPE = new HashSet<EQUIPE>();
            EVENEMENT = new HashSet<EVENEMENT>();
            PAIEMENT_EMPLOYE = new HashSet<PAIEMENT_EMPLOYE>();
        }

        [Key]
        public int ID_EMPLOYE { get; set; }

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
        public string POSTE { get; set; }

        [StringLength(30)]
        public string CIN { get; set; }

        [StringLength(30)]
        public string Mot_De_Passe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AGENDA_EMPLOYE> AGENDA_EMPLOYE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONGE> CONGE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONVENTION> CONVENTION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EQUIPE> EQUIPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EVENEMENT> EVENEMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAIEMENT_EMPLOYE> PAIEMENT_EMPLOYE { get; set; }
    }
}
