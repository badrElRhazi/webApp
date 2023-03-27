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
    public class CLIENT_SALLEController : Controller
    {
        private ProjetFinFormationSiteWebEntities4 db = new ProjetFinFormationSiteWebEntities4();

        // GET: CLIENT_SALLE
        public async Task<ActionResult> Index()
        {
            return View(await db.CLIENT_SALLE.ToListAsync());
        }

        // GET: CLIENT_SALLE/Details/5
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

        // GET: CLIENT_SALLE/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CLIENT_SALLE/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
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

        // GET: CLIENT_SALLE/Edit/5
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

        // POST: CLIENT_SALLE/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
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

        // GET: CLIENT_SALLE/Delete/5
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

        // POST: CLIENT_SALLE/Delete/5
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
