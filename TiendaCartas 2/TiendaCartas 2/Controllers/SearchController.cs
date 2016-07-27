using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TiendaCartas_2.Models;

namespace TiendaCartas_2.Controllers
{
    public class SearchController : Controller
    {
        private proyectoEntities2 db = new proyectoEntities2();
       
        public ActionResult SearchB()
        {
            return View();
        }
        public ActionResult SearchC(ModelQuery obj)
        {
            var productos = (from p in db.producto
                             where p.nombre_producto == obj.nombrePro
                             select new {nombre = p.nombre_producto, foto = p.foto_producto}).ToList();

            List<ModelQuery> mo = new List<ModelQuery>();
            foreach (var item in productos)
            {
                ModelQuery m = new ModelQuery();
                m.nombrePro = item.nombre;
                m.fotoPro = item.foto;
                mo.Add(m);
            }
            return View(mo);
        }
      
       
    }
}