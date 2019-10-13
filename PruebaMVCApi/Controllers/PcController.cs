using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Datos;

namespace PruebaMVCApi.Controllers
{
    public class PcController : Controller
    {
        // GET: Pc
        public ActionResult Index()
        {
            string datapath = Path.Combine(HttpContext.Request.PhysicalApplicationPath, @"App_Data\PcInfoFile.xml");
            Repositorio rep = new Repositorio();
            var pcs = rep.ReadPcFile(datapath);
            var resultado = pcs.Where(s => s.Memoria > 8);
            return View(resultado);
        }

    }
}