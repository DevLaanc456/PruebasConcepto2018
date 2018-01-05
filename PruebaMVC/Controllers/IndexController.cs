using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PruebaMVC.Entidades;

namespace PruebaMVC.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }

        // GET: Index/Create
        public ActionResult Create(Persona _persona)
        {
            Persona _id = _persona;

            return View();
        }

     
    }
}
