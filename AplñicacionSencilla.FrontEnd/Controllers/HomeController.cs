using AplñicacionSencilla.FrontEnd.AplicacionSencillaServicio;
using AplñicacionSencilla.FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplñicacionSencilla.FrontEnd.Controllers
{
    public class HomeController : Controller
    {
        AplicacionSencillaServicio.AplicacionSencillaServicioClient aplicacionSencillaServicio = new AplicacionSencillaServicio.AplicacionSencillaServicioClient();
        public ActionResult Index()
        {
            List<UsuariosModel> Model = new List<UsuariosModel>();
            DTOUusarioRespuesta Respuesta = new DTOUusarioRespuesta();
            UsuariosModel usuariosModel;

            Respuesta = aplicacionSencillaServicio.ObtenerUusuarios();
            if (Respuesta.Resultado.Codigo == EnumsCodigoRespuesta.OK)
            {
                foreach (DTOUsuarioCuerpo res in Respuesta.Cuerpo)
                {
                    usuariosModel = new UsuariosModel();
                    usuariosModel.Id = res.Id;
                    usuariosModel.Nombre = res.Nombre;
                    usuariosModel.Apellido = res.Apellido;
                    usuariosModel.Telefono = res.Telefono;
                    usuariosModel.Direccion = res.Direccion;
                    usuariosModel.NumeroIdentificacion = res.NumeroIdentificacion;
                    usuariosModel.Email = res.Email;
                    usuariosModel.TipoIdentificacion = res.TipoIdentificacion;
                    usuariosModel.Usuario = res.Usuario;
                    Model.Add(usuariosModel);
                }

                return View(Model);
            }
            else
            {
                return Content("<script language='javascript' type='text/javascript'>alert('Error.'); window.location = '/Home/Index';</script>");
            }
        }


        public ActionResult AgregarUsuarios(UsuariosModel model)
        {
            List<UsuariosModel> Model = new List<UsuariosModel>();
            DTOResultado Respuesta = new DTOResultado();
            DTOUsuarioCuerpo usuario = new DTOUsuarioCuerpo();
            DTOLoginCuerpo login = new DTOLoginCuerpo();
            usuario.Nombre = model.Nombre;
            usuario.Apellido = model.Apellido;
            usuario.Direccion = model.Direccion;
            usuario.Telefono = model.Telefono;
            usuario.NumeroIdentificacion = model.NumeroIdentificacion;
            usuario.Email = model.Email;
            usuario.TipoIdentificacion = model.TipoIdentificacion;
            login.Usuario = model.Usuario;
            login.Pass = model.Pass;
            usuario.Login = login;

            Respuesta = aplicacionSencillaServicio.AgregarUusuarios(usuario);
            if (Respuesta.Codigo == EnumsCodigoRespuesta.OK)
            {

                return Content("<script language='javascript' type='text/javascript'>alert('Saved'); window.location = '/Home/Index';</script>");
            }
            else
            {
                return Content("<script language='javascript' type='text/javascript'>alert('Error.'); window.location = '/Home/Index';</script>");
            }
        }

        public ActionResult Login(UsuariosModel model)
        {
            List<UsuariosModel> Model = new List<UsuariosModel>();
            DTOResultado Respuesta = new DTOResultado();
            DTOUsuarioCuerpo usuario = new DTOUsuarioCuerpo();
            DTOLoginCuerpo login = new DTOLoginCuerpo();
            login.Usuario = model.Usuario;
            login.Pass = model.Pass;
            usuario.Login = login;

            Respuesta = aplicacionSencillaServicio.Login(usuario);
            if (!(Respuesta.Codigo == EnumsCodigoRespuesta.OK))
            {

                return Content("<script language='javascript' type='text/javascript'>alert('Error.'); window.location = '/Home/Index';</script>");
            }
            else
            {
                return View("/Home/Login");
            }
        }




        public ActionResult BorrarUsuarios(UsuariosModel model)
        {
            List<UsuariosModel> Model = new List<UsuariosModel>();
            DTOResultado Respuesta = new DTOResultado();
            DTOUsuarioSolicitud usuario = new DTOUsuarioSolicitud();

            usuario.Id = model.Id;

            Respuesta = aplicacionSencillaServicio.BorrarUusuarios(usuario);
            if (Respuesta.Codigo == EnumsCodigoRespuesta.OK)
            {

                return Content("<script language='javascript' type='text/javascript'>alert('Eliminado'); window.location = '/Home/Index';</script>");
            }
            else
            {
                return Content("<script language='javascript' type='text/javascript'>alert('Error.'); window.location = '/Home/Index'</script>");
            }


        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CrearUsuarios()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}