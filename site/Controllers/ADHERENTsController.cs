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
    public class ADHERENTsController : Controller
    {
        private ProjetFinFormationSiteWebEntities4 db = new ProjetFinFormationSiteWebEntities4();

        // GET: ADHERENTs
        public async Task<ActionResult> Index()
        {
            var aDHERENT = db.ADHERENT.Include(a => a.FORMATION_INDIVIDUAL);
            return View(await aDHERENT.ToListAsync());
        }

        // GET: ADHERENTs/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ADHERENT aDHERENT = await db.ADHERENT.FindAsync(id);
            if (aDHERENT == null)
            {
                return HttpNotFound();
            }
            return View(aDHERENT);
        }

        // GET: ADHERENTs/Create
        public ActionResult Create()
        {
            ViewBag.ID_FORMATIONINDIVIDUAL = new SelectList(db.FORMATION_INDIVIDUAL, "ID_FORMATIONINDIVIDUAL", "NOM_FR");
            return View();
        }

        // POST: ADHERENTs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID_ADHERENT,CIN,NOM,PRENOM,DATE_NAISSANCE,ADRESSE,SEXE,TELEPHONE,ID_FORMATIONINDIVIDUAL")] ADHERENT aDHERENT)
        {
            if (ModelState.IsValid)
            {
                db.ADHERENT.Add(aDHERENT);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.ID_FORMATIONINDIVIDUAL = new SelectList(db.FORMATION_INDIVIDUAL, "ID_FORMATIONINDIVIDUAL", "NOM_FR", aDHERENT.ID_FORMATIONINDIVIDUAL);
            return View(aDHERENT);
        }

        // GET: ADHERENTs/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ADHERENT aDHERENT = await db.ADHERENT.FindAsync(id);
            if (aDHERENT == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_FORMATIONINDIVIDUAL = new SelectList(db.FORMATION_INDIVIDUAL, "ID_FORMATIONINDIVIDUAL", "NOM_FR", aDHERENT.ID_FORMATIONINDIVIDUAL);
            return View(aDHERENT);
        }

        // POST: ADHERENTs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID_ADHERENT,CIN,NOM,PRENOM,DATE_NAISSANCE,ADRESSE,SEXE,TELEPHONE,ID_FORMATIONINDIVIDUAL")] ADHERENT aDHERENT)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aDHERENT).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.ID_FORMATIONINDIVIDUAL = new SelectList(db.FORMATION_INDIVIDUAL, "ID_FORMATIONINDIVIDUAL", "NOM_FR", aDHERENT.ID_FORMATIONINDIVIDUAL);
            return View(aDHERENT);
        }

        // GET: ADHERENTs/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ADHERENT aDHERENT = await db.ADHERENT.FindAsync(id);
            if (aDHERENT == null)
            {
                return HttpNotFound();
            }
            return View(aDHERENT);
        }

        // POST: ADHERENTs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ADHERENT aDHERENT = await db.ADHERENT.FindAsync(id);
            db.ADHERENT.Remove(aDHERENT);
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
