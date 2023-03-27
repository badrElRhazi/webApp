using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace site.Models
{
    public class SALLEsController : Controller
    {
        private ProjetFinFormationEntities1 db = new ProjetFinFormationEntities1();

        // GET: SALLEs
        public async Task<ActionResult> Index()
        {
            return View(await db.SALLE.ToListAsync());
        }

        // GET: SALLEs/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SALLE sALLE = await db.SALLE.FindAsync(id);
            if (sALLE == null)
            {
                return HttpNotFound();
            }
            return View(sALLE);
        }

        // GET: SALLEs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SALLEs/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID_SALLE,CAPACITE,DISPONIBILITE,PRIX")] SALLE sALLE)
        {
            if (ModelState.IsValid)
            {
                db.SALLE.Add(sALLE);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(sALLE);
        }

        // GET: SALLEs/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SALLE sALLE = await db.SALLE.FindAsync(id);
            if (sALLE == null)
            {
                return HttpNotFound();
            }
            return View(sALLE);
        }

        // POST: SALLEs/Edit/5
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID_SALLE,CAPACITE,DISPONIBILITE,PRIX")] SALLE sALLE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sALLE).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(sALLE);
        }

        // GET: SALLEs/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SALLE sALLE = await db.SALLE.FindAsync(id);
            if (sALLE == null)
            {
                return HttpNotFound();
            }
            return View(sALLE);
        }

        // POST: SALLEs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            SALLE sALLE = await db.SALLE.FindAsync(id);
            db.SALLE.Remove(sALLE);
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
