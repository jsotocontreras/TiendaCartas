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
    public class compraController : Controller
    {
        private tiendacartasEntities db = new tiendacartasEntities();

        // GET: compra
        public ActionResult Index()
        {
            var compra = db.compra.Include(c => c.tipo_pago).Include(c => c.producto).Include(c => c.usuario);
            return View(compra.ToList());
        }

        // GET: compra/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            compra compra = db.compra.Find(id);
            if (compra == null)
            {
                return HttpNotFound();
            }
            return View(compra);
        }

        // GET: compra/Create
        public ActionResult Create()
        {
            ViewBag.id_pago = new SelectList(db.tipo_pago, "id_pago", "pago");
            ViewBag.id_producto = new SelectList(db.producto, "id_producto", "nombre_producto");
            ViewBag.id_usuario = new SelectList(db.usuario, "id_usuario", "nombre_usuario");
            return View();
        }

        // POST: compra/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_compra,id_usuario,id_producto,valor_total,fecha,id_pago")] compra compra)
        {
            if (ModelState.IsValid)
            {
                db.compra.Add(compra);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_pago = new SelectList(db.tipo_pago, "id_pago", "pago", compra.id_pago);
            ViewBag.id_producto = new SelectList(db.producto, "id_producto", "nombre_producto", compra.id_producto);
            ViewBag.id_usuario = new SelectList(db.usuario, "id_usuario", "nombre_usuario", compra.id_usuario);
            return View(compra);
        }

        // GET: compra/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            compra compra = db.compra.Find(id);
            if (compra == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_pago = new SelectList(db.tipo_pago, "id_pago", "pago", compra.id_pago);
            ViewBag.id_producto = new SelectList(db.producto, "id_producto", "nombre_producto", compra.id_producto);
            ViewBag.id_usuario = new SelectList(db.usuario, "id_usuario", "nombre_usuario", compra.id_usuario);
            return View(compra);
        }

        // POST: compra/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_compra,id_usuario,id_producto,valor_total,fecha,id_pago")] compra compra)
        {
            if (ModelState.IsValid)
            {
                db.Entry(compra).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_pago = new SelectList(db.tipo_pago, "id_pago", "pago", compra.id_pago);
            ViewBag.id_producto = new SelectList(db.producto, "id_producto", "nombre_producto", compra.id_producto);
            ViewBag.id_usuario = new SelectList(db.usuario, "id_usuario", "nombre_usuario", compra.id_usuario);
            return View(compra);
        }

        // GET: compra/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            compra compra = db.compra.Find(id);
            if (compra == null)
            {
                return HttpNotFound();
            }
            return View(compra);
        }

        // POST: compra/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            compra compra = db.compra.Find(id);
            db.compra.Remove(compra);
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
