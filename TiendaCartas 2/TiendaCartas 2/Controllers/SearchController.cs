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
        // GET: Search
        public ActionResult Index()
        {
            var productos = from p in db.producto
                            select new { p.nombre_producto, p.foto_producto };
            return View();
        }
       
    }
}