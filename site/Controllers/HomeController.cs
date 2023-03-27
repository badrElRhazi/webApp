using System.Web.Helpers;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;
using site.Models;
using System.Collections.Generic;

using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data;
using System.Net.Mime;
using System.Threading;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace site.Controllers
{
    public class HomeController : Controller
    {
        private ProjetFinFormationEntities1 db = new ProjetFinFormationEntities1();

        // GET: Home

        public ActionResult Index()
        {
            //SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            //smtpClient.Credentials = new System.Net.NetworkCredential("ayoubbellahcen6@gmail.com", "ayoubzine");
            //smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            //smtpClient.EnableSsl = true;
            //MailMessage mail = new MailMessage();
            //mail.From = new MailAddress("ayoubbellahcen6@gmail.com", "CHU");
            //mail.To.Add(new MailAddress("masadki2@gmail.com"));
            //mail.Subject = "Code Login";
            //mail.Body = "bonjour CCSE";
            //smtpClient.Send(mail);
            return View();
        }

        [HttpPost,ActionName("Index")]
        public ActionResult Index1(string name,string email,string message)
        {
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new System.Net.NetworkCredential("ayoubbellahcen6@gmail.com", "ayoubzine");
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("ayoubbellahcen6@gmail.com", "CCSE");
            mail.To.Add(new MailAddress("masadki2@gmail.com"));
            mail.Subject = "demande information";
            mail.Body = name + email + message;
            smtpClient.Send(mail);
            return View();
        }


        public ActionResult element()
        {
            return View();
        }

    

      
        public ActionResult Formation_groupe()
        {
       
           
            return View();
        }
        [HttpPost]
        public ActionResult Formation_groupe(FORMATION_GROUPE model)
        {

            FORMATION_GROUPE frmG = new FORMATION_GROUPE();
            frmG.NOM_FR = model.NOM_FR;
            frmG.Nom_Entrprise = model.Nom_Entrprise;
            frmG.SECTEUR_ACTIVITE = model.SECTEUR_ACTIVITE;
            frmG.MISSION = model.MISSION;
            frmG.OBJECTIF = model.OBJECTIF;
            frmG.EFFECTIF = model.EFFECTIF;
            frmG.BESOIN_INDIVIDUELE = model.BESOIN_INDIVIDUELE;
            frmG.BESOIN = model.BESOIN;

            db.FORMATION_GROUPE.Add(frmG);
            db.SaveChanges();
            return View();
        }

        public ActionResult Formation_individuel()
        {
            return View();
        }

 
        [HttpPost]
        public ActionResult Formation_individuel(FORMATION_INDIVIDUAL model)
        {
            FORMATION_INDIVIDUAL frmi = new FORMATION_INDIVIDUAL();
            frmi.NOM_FR = model.NOM_FR;
            frmi.SECTEUR_ACTIVITE = model.SECTEUR_ACTIVITE;
            frmi.MODE_REGLEMENT = model.MODE_REGLEMENT;
            frmi.Etat = model.Etat;
            db.FORMATION_INDIVIDUAL.Add(frmi);
            db.SaveChanges();


           
         
            return View();
        }


        public ActionResult Choix_Evenement()
        {
            return View();
        }

        public ActionResult Evenement()
        {
            return View();
        }
    [HttpPost]
        public ActionResult Evenement(CLIENT_EVENEMENT model)
        {
            CLIENT_EVENEMENT ev = new CLIENT_EVENEMENT();
            ev.ID_CLIENT = model.ID_CLIENT;
            ev.CIN_CLIENT = model.CIN_CLIENT;
            ev.NOM_Client = model.NOM_Client;
            ev.PRENOM_CLIENT = model.PRENOM_CLIENT;
            ev.DATE_NAISSANCE_CLIENT = model.DATE_NAISSANCE_CLIENT;
            ev.ADRESSE_CLIENT = model.ADRESSE_CLIENT;
            ev.SEXE_CLIENT = model.SEXE_CLIENT;
            ev.TELEPHONE_CLIENT = model.TELEPHONE_CLIENT;
            ev.TYPE_EVENEMENT = model.TYPE_EVENEMENT;
            ev.NOM_EVENEMENT = model.NOM_EVENEMENT;
            ev.DATE_EVENEMENT = model.DATE_EVENEMENT;
            ev.DURE = model.DURE;
            db.CLIENT_EVENEMENT.Add(ev);
            db.SaveChanges();



            return View();
        }

        public ActionResult Choix_Formation()
        {
            return View();
        }


        [HttpGet]
        public ActionResult salle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult salle(CLIENT_SALLE model)
        {
            CLIENT_SALLE clsalle = new CLIENT_SALLE();

            clsalle.ID_CLIENT_SALLE = model.ID_CLIENT_SALLE;
            clsalle.CIN_CLIENT = model.CIN_CLIENT;
            clsalle.NOM_Client = model.NOM_Client;
            clsalle.PRENOM_CLIENT = model.PRENOM_CLIENT;
            clsalle.DATE_NAISSANCE_CLIENT = model.DATE_NAISSANCE_CLIENT;
            clsalle.ADRESSE_CLIENT = model.ADRESSE_CLIENT;
            clsalle.SEXE_CLIENT = model.SEXE_CLIENT;
            clsalle.TELEPHONE_CLIENT = model.TELEPHONE_CLIENT;
            clsalle.type = model.type;
            clsalle.dateDebut = model.dateDebut;
            clsalle.dateFin = model.dateFin;
            db.CLIENT_SALLE.Add(clsalle);
            db.SaveChanges();


            return View();
        }





        [HttpGet]
        public ActionResult Adherent()
        {
            ViewBag.iD_FORMATIONINDIVIDUAL = new SelectList(db.FORMATION_INDIVIDUAL, "ID_FORMATIONINDIVIDUAL", "NOM_FR");

            return View();
        }

        [HttpPost]
        public ActionResult Adherent(ADHERENT modelItem)
        {

            ADHERENT adr = new ADHERENT();
            adr.CIN = modelItem.CIN;
            adr.NOM = modelItem.NOM;
            adr.PRENOM = modelItem.PRENOM;
            adr.DATE_NAISSANCE = modelItem.DATE_NAISSANCE;
            adr.ADRESSE = modelItem.ADRESSE;
            adr.TELEPHONE = modelItem.TELEPHONE;
            adr.SEXE = modelItem.SEXE;
            adr.ID_FORMATIONINDIVIDUAL = modelItem.ID_FORMATIONINDIVIDUAL;
    
            
            db.ADHERENT.Add(adr);
            db.SaveChanges();

            ViewBag.iD_FORMATIONINDIVIDUAL = new SelectList(db.FORMATION_INDIVIDUAL, "ID_FORMATIONINDIVIDUAL", "NOM_FR", adr.ID_FORMATIONINDIVIDUAL);

            return View();
        }


        public List<FORMATION_INDIVIDUAL> GetFormation()
        {


            List<FORMATION_INDIVIDUAL> formation = db.FORMATION_INDIVIDUAL.ToList();
            return formation;
        }





    }
}