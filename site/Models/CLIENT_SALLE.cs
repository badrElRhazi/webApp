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

    public partial class CLIENT_SALLE
    {
        public int ID_CLIENT_SALLE { get; set; }
        public string CIN_CLIENT { get; set; }
        public string NOM_Client { get; set; }
        public string PRENOM_CLIENT { get; set; }
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> DATE_NAISSANCE_CLIENT { get; set; }
        public string ADRESSE_CLIENT { get; set; }
        public string SEXE_CLIENT { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string TELEPHONE_CLIENT { get; set; }
        public string type { get; set; }
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> dateDebut { get; set; }
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> dateFin { get; set; }
    }
}