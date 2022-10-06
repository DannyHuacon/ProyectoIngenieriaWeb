using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProyectoIngenieriaWeb;

namespace ProyectoIngenieriaWeb.Controllers
{
    public class EmpleadosWEBsController : Controller
    {
        private EmpresaWEBEntities db = new EmpresaWEBEntities();

        // GET: EmpleadosWEBs
        public ActionResult Index()
        {
            return View(db.EmpleadosWEB.ToList());
        }

        // GET: EmpleadosWEBs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpleadosWEB empleadosWEB = db.EmpleadosWEB.Find(id);
            if (empleadosWEB == null)
            {
                return HttpNotFound();
            }
            return View(empleadosWEB);
        }

        // GET: EmpleadosWEBs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpleadosWEBs/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nombres,Apellidos")] EmpleadosWEB empleadosWEB)
        {
            if (ModelState.IsValid)
            {
                db.EmpleadosWEB.Add(empleadosWEB);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(empleadosWEB);
        }

        // GET: EmpleadosWEBs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpleadosWEB empleadosWEB = db.EmpleadosWEB.Find(id);
            if (empleadosWEB == null)
            {
                return HttpNotFound();
            }
            return View(empleadosWEB);
        }

        // POST: EmpleadosWEBs/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nombres,Apellidos")] EmpleadosWEB empleadosWEB)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empleadosWEB).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empleadosWEB);
        }

        // GET: EmpleadosWEBs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpleadosWEB empleadosWEB = db.EmpleadosWEB.Find(id);
            if (empleadosWEB == null)
            {
                return HttpNotFound();
            }
            return View(empleadosWEB);
        }

        // POST: EmpleadosWEBs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmpleadosWEB empleadosWEB = db.EmpleadosWEB.Find(id);
            db.EmpleadosWEB.Remove(empleadosWEB);
            db.SaveChanges();
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
