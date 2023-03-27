using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using site.Models;

namespace site.Controllers
{
    public class CLIENT_SALLE1Controller : Controller
    {
        private ProjetFinFormationEntities1 db = new ProjetFinFormationEntities1();

        // GET: CLIENT_SALLE1
        public async Task<ActionResult> Index()
        {
            return View(await db.CLIENT_SALLE.ToListAsync());
        }

        // GET: CLIENT_SALLE1/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CLIENT_SALLE cLIENT_SALLE = await db.CLIENT_SALLE.FindAsync(id);
            if (cLIENT_SALLE == null)
            {
                return HttpNotFound();
            }
            return View(cLIENT_SALLE);
        }

        // GET: CLIENT_SALLE1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CLIENT_SALLE1/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID_CLIENT_SALLE,CIN_CLIENT,NOM_Client,PRENOM_CLIENT,DATE_NAISSANCE_CLIENT,ADRESSE_CLIENT,SEXE_CLIENT,TELEPHONE_CLIENT,type,dateDebut,dateFin")] CLIENT_SALLE cLIENT_SALLE)
        {
            if (ModelState.IsValid)
            {
                db.CLIENT_SALLE.Add(cLIENT_SALLE);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(cLIENT_SALLE);
        }

        // GET: CLIENT_SALLE1/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CLIENT_SALLE cLIENT_SALLE = await db.CLIENT_SALLE.FindAsync(id);
            if (cLIENT_SALLE == null)
            {
                return HttpNotFound();
            }
            return View(cLIENT_SALLE);
        }

        // POST: CLIENT_SALLE1/Edit/5
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID_CLIENT_SALLE,CIN_CLIENT,NOM_Client,PRENOM_CLIENT,DATE_NAISSANCE_CLIENT,ADRESSE_CLIENT,SEXE_CLIENT,TELEPHONE_CLIENT,type,dateDebut,dateFin")] CLIENT_SALLE cLIENT_SALLE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cLIENT_SALLE).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(cLIENT_SALLE);
        }

        // GET: CLIENT_SALLE1/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CLIENT_SALLE cLIENT_SALLE = await db.CLIENT_SALLE.FindAsync(id);
            if (cLIENT_SALLE == null)
            {
                return HttpNotFound();
            }
            return View(cLIENT_SALLE);
        }

        // POST: CLIENT_SALLE1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            CLIENT_SALLE cLIENT_SALLE = await db.CLIENT_SALLE.FindAsync(id);
            db.CLIENT_SALLE.Remove(cLIENT_SALLE);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
