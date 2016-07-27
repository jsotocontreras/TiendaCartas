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
       
        public ActionResult SearchB(ModelQuery obj)
        {
            var productos = (from p in db.producto
                             where p.nombre_producto == obj.nombrePro
                             select new { p.nombre_producto, p.foto_producto}).ToList();

         List<ModelQuery> modelos = new List<ModelQuery>();
            foreach (var viewPro in productos)
            {
                ModelQuery mq = new ModelQuery();
                mq.nombrePro = viewPro.nombre_producto;
                mq.fotoPro = viewPro.foto_producto;
                modelos.Add(mq);    
            }
            return View(modelos);
        }
      
       
    }
}