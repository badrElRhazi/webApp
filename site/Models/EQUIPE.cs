namespace site.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EQUIPE")]
    public partial class EQUIPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EQUIPE()
        {
            ADHERENT = new HashSet<ADHERENT>();
            FORMATION_GROUPE = new HashSet<FORMATION_GROUPE>();
            FORMATION_INDIVIDUAL = new HashSet<FORMATION_INDIVIDUAL>();
        }

        [Key]
        public int ID_EQUIPE { get; set; }

        public int ID_EMPLOYE { get; set; }

        [StringLength(30)]
        public string NOM_EQUIPE { get; set; }

        public int? NOMBRE { get; set; }

        [StringLength(30)]
        public string TYPE_FORMATION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADHERENT> ADHERENT { get; set; }

        public virtual EMPLOYE EMPLOYE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORMATION_GROUPE> FORMATION_GROUPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORMATION_INDIVIDUAL> FORMATION_INDIVIDUAL { get; set; }
    }
}
