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

    public partial class ADHERENT
    {
        public int ID_ADHERENT { get; set; }
        public string CIN { get; set; }
        public string NOM { get; set; }
        public string PRENOM { get; set; }
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> DATE_NAISSANCE { get; set; }
        public string ADRESSE { get; set; }
        public string SEXE { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string TELEPHONE { get; set; }
        public Nullable<int> ID_FORMATIONINDIVIDUAL { get; set; }
    
        public virtual FORMATION_INDIVIDUAL FORMATION_INDIVIDUAL { get; set; }
    }
}