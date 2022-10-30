using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplñicacionSencilla.FrontEnd.Controllers
{
    public class AplicacionSencillaController : Controller
    {

        AplicacionSencillaServicio.AplicacionSencillaServicioClient _servicioAplicacionSencilla = new AplicacionSencillaServicio.AplicacionSencillaServicioClient();
      
        // GET: AplicacionSencilla
        public ActionResult Index()
        {
            return View();
        }
        //public ActionResult ObtenerUsuario()
        //{

        //}
    }
}