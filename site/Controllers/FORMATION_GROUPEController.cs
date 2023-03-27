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
    public class FORMATION_GROUPEController : Controller
    {
        private ProjetFinFormationEntities1 db = new ProjetFinFormationEntities1();

        // GET: FORMATION_GROUPE
        public async Task<ActionResult> Index()
        {
            return View(await db.FORMATION_GROUPE.ToListAsync());
        }

        // GET: FORMATION_GROUPE/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FORMATION_GROUPE fORMATION_GROUPE = await db.FORMATION_GROUPE.FindAsync(id);
            if (fORMATION_GROUPE == null)
            {
                return HttpNotFound();
            }
            return View(fORMATION_GROUPE);
        }

        // GET: FORMATION_GROUPE/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FORMATION_GROUPE/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID_FORMATIONGROUPE,NOM_FR,SECTEUR_ACTIVITE,MISSION,OBJECTIF,EFFECTIF,BESOIN_INDIVIDUELE,BESOIN")] FORMATION_GROUPE fORMATION_GROUPE)
        {
            if (ModelState.IsValid)
            {
                db.FORMATION_GROUPE.Add(fORMATION_GROUPE);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(fORMATION_GROUPE);
        }

        // GET: FORMATION_GROUPE/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FORMATION_GROUPE fORMATION_GROUPE = await db.FORMATION_GROUPE.FindAsync(id);
            if (fORMATION_GROUPE == null)
            {
                return HttpNotFound();
            }
            return View(fORMATION_GROUPE);
        }

        // POST: FORMATION_GROUPE/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID_FORMATIONGROUPE,NOM_FR,SECTEUR_ACTIVITE,MISSION,OBJECTIF,EFFECTIF,BESOIN_INDIVIDUELE,BESOIN")] FORMATION_GROUPE fORMATION_GROUPE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fORMATION_GROUPE).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(fORMATION_GROUPE);
        }

        // GET: FORMATION_GROUPE/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FORMATION_GROUPE fORMATION_GROUPE = await db.FORMATION_GROUPE.FindAsync(id);
            if (fORMATION_GROUPE == null)
            {
                return HttpNotFound();
            }
            return View(fORMATION_GROUPE);
        }

        // POST: FORMATION_GROUPE/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            FORMATION_GROUPE fORMATION_GROUPE = await db.FORMATION_GROUPE.FindAsync(id);
            db.FORMATION_GROUPE.Remove(fORMATION_GROUPE);
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
