using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TiendaCartas.Models;

namespace TiendaCartas.Controllers
{
    public class noticiasController : Controller
    {
        private tiendacartasEntities db = new tiendacartasEntities();

        // GET: noticias
        public ActionResult Index()
        {
            return View(db.noticias.ToList());
        }

        // GET: noticias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            noticias noticias = db.noticias.Find(id);
            if (noticias == null)
            {
                return HttpNotFound();
            }
            return View(noticias);
        }

        // GET: noticias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: noticias/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "codigo,nombre_noticia,descripcion_noticia,foto_noticia")] noticias noticias)
        {
            if (ModelState.IsValid)
            {
                db.noticias.Add(noticias);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(noticias);
        }

        // GET: noticias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            noticias noticias = db.noticias.Find(id);
            if (noticias == null)
            {
                return HttpNotFound();
            }
            return View(noticias);
        }

        // POST: noticias/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "codigo,nombre_noticia,descripcion_noticia,foto_noticia")] noticias noticias)
        {
            if (ModelState.IsValid)
            {
                db.Entry(noticias).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(noticias);
        }

        // GET: noticias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            noticias noticias = db.noticias.Find(id);
            if (noticias == null)
            {
                return HttpNotFound();
            }
            return View(noticias);
        }

        // POST: noticias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            noticias noticias = db.noticias.Find(id);
            db.noticias.Remove(noticias);
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
