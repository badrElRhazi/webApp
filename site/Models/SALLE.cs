//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace site.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class SALLE
    {
        public int ID_SALLE { get; set; }
        public Nullable<int> CAPACITE { get; set; }
        public string DISPONIBILITE { get; set; }
        public Nullable<int> PRIX { get; set; }
        public string TypeSalle { get; set; }
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> DateDisponibilite { get; set; }
    }
}
