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
    public class CLIENT_EVENEMENTController : Controller
    {
        private ProjetFinFormationSiteWebEntities4 db = new ProjetFinFormationSiteWebEntities4();

        // GET: CLIENT_EVENEMENT
        public async Task<ActionResult> Index()
        {
            return View(await db.CLIENT_EVENEMENT.ToListAsync());
        }

        // GET: CLIENT_EVENEMENT/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CLIENT_EVENEMENT cLIENT_EVENEMENT = await db.CLIENT_EVENEMENT.FindAsync(id);
            if (cLIENT_EVENEMENT == null)
            {
                return HttpNotFound();
            }
            return View(cLIENT_EVENEMENT);
        }

        // GET: CLIENT_EVENEMENT/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CLIENT_EVENEMENT/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID_CLIENT,CIN_CLIENT,NOM_Client,PRENOM_CLIENT,DATE_NAISSANCE_CLIENT,ADRESSE_CLIENT,SEXE_CLIENT,TELEPHONE_CLIENT,TYPE_EVENEMENT,NOM_EVENEMENT,DATE_EVENEMENT,DURE")] CLIENT_EVENEMENT cLIENT_EVENEMENT)
        {
            if (ModelState.IsValid)
            {
                db.CLIENT_EVENEMENT.Add(cLIENT_EVENEMENT);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(cLIENT_EVENEMENT);
        }

        // GET: CLIENT_EVENEMENT/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CLIENT_EVENEMENT cLIENT_EVENEMENT = await db.CLIENT_EVENEMENT.FindAsync(id);
            if (cLIENT_EVENEMENT == null)
            {
                return HttpNotFound();
            }
            return View(cLIENT_EVENEMENT);
        }

        // POST: CLIENT_EVENEMENT/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID_CLIENT,CIN_CLIENT,NOM_Client,PRENOM_CLIENT,DATE_NAISSANCE_CLIENT,ADRESSE_CLIENT,SEXE_CLIENT,TELEPHONE_CLIENT,TYPE_EVENEMENT,NOM_EVENEMENT,DATE_EVENEMENT,DURE")] CLIENT_EVENEMENT cLIENT_EVENEMENT)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cLIENT_EVENEMENT).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(cLIENT_EVENEMENT);
        }

        // GET: CLIENT_EVENEMENT/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CLIENT_EVENEMENT cLIENT_EVENEMENT = await db.CLIENT_EVENEMENT.FindAsync(id);
            if (cLIENT_EVENEMENT == null)
            {
                return HttpNotFound();
            }
            return View(cLIENT_EVENEMENT);
        }

        // POST: CLIENT_EVENEMENT/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            CLIENT_EVENEMENT cLIENT_EVENEMENT = await db.CLIENT_EVENEMENT.FindAsync(id);
            db.CLIENT_EVENEMENT.Remove(cLIENT_EVENEMENT);
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
