using AplicacionSencilla.Entidades;
using AplicacionSencilla.Entidades.WCF;
using AplicacionSencilla.Entidades.WCF.Usuarios;
using AplicacionSencilla.HerramientasComunes;
using AplicacionSencilla.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AplicacionSencillaWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "AplicacionSencillaServicio" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione AplicacionSencillaServicio.svc o AplicacionSencillaServicio.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class AplicacionSencillaServicio : IAplicacionSencillaServicio
    {
        /// <summary>
        /// Metodo de servicio para obtener usuarios
        /// </summary>
        /// <returns></returns>
        public DTOUusarioRespuesta ObtenerUusuarios()
        {
            DTOUusarioRespuesta resUsuario = new DTOUusarioRespuesta();
            TrazaServicio traza = new TrazaServicio();
            try
            {
                #region Trace
                traza.Operacion = MethodBase.GetCurrentMethod().Name;
                traza.FechaEjecucion = DateTime.Now;
                #endregion

                AplicacionSencillaCN aplicacionSencillaCN = new AplicacionSencillaCN();
                resUsuario = aplicacionSencillaCN.ObtenerUsuarios();

                #region Traza
                traza.Respuesta = Herramientas.Serialize(resUsuario);
                #endregion
            }
            catch (Exception ex)
            {
                DTOResultado res = new DTOResultado();
                res.Codigo = Enums.CodigoRespuesta.InternalServiceError;
                res.Mensaje = Herramientas.GetEnumDescription<Enums.CodigoRespuesta>(Enums.CodigoRespuesta.InternalServiceError);
                res.ErrorDePila = ex.Message + " - " + ex.StackTrace;
                traza.DetalleDeExcepcion = ex.Message + " - " + ex.StackTrace;
                resUsuario.Resultado = res;
                #region Trace
                traza.Respuesta = Herramientas.Serialize(res);
                #endregion

            }
            finally
            {
                GuardarLog(traza);
            }

            return resUsuario;
        }
        /// <summary>
        /// Mwetodo de servicio para borrar usuarios
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public DTOResultado BorrarUusuarios(DTOUsuarioSolicitud usuario)
        {
            DTOResultado res = new DTOResultado();
            TrazaServicio traza = new TrazaServicio();
            try
            {
                #region Trace
                traza.Operacion = MethodBase.GetCurrentMethod().Name;
                traza.FechaEjecucion = DateTime.Now;
                #endregion

                AplicacionSencillaCN aplicacionSencillaCN = new AplicacionSencillaCN();
                res = aplicacionSencillaCN.Borrarusuario(usuario);

                #region Traza
                traza.Respuesta = Herramientas.Serialize(res);
                #endregion
            }
            catch (Exception ex)
            {
                res.Codigo = Enums.CodigoRespuesta.InternalServiceError;
                res.Mensaje = Herramientas.GetEnumDescription<Enums.CodigoRespuesta>(Enums.CodigoRespuesta.InternalServiceError);
                res.ErrorDePila = ex.Message + " - " + ex.StackTrace;
                traza.DetalleDeExcepcion = ex.Message + " - " + ex.StackTrace;
                #region Trace
                traza.Respuesta = Herramientas.Serialize(res);
                #endregion

            }
            finally
            {
                GuardarLog(traza);
            }

            return res;
        }

        /// <summary>
        /// Metodo para agregar los usuarios.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public DTOResultado AgregarUusuarios(DTOUsuarioCuerpo usuario)
        {
            DTOResultado res = new DTOResultado();
            TrazaServicio traza = new TrazaServicio();
            try
            {
                #region Trace
                traza.Operacion = MethodBase.GetCurrentMethod().Name;
                traza.FechaEjecucion = DateTime.Now;
                #endregion

                AplicacionSencillaCN aplicacionSencillaCN = new AplicacionSencillaCN();
                res = aplicacionSencillaCN.AgregarUsuario(usuario);

                #region Traza
                traza.Respuesta = Herramientas.Serialize(res);
                #endregion
            }
            catch (Exception ex)
            {
                res.Codigo = Enums.CodigoRespuesta.InternalServiceError;
                res.Mensaje = Herramientas.GetEnumDescription<Enums.CodigoRespuesta>(Enums.CodigoRespuesta.InternalServiceError);
                res.ErrorDePila = ex.Message + " - " + ex.StackTrace;
                traza.DetalleDeExcepcion = ex.Message + " - " + ex.StackTrace;
                #region Trace
                traza.Respuesta = Herramientas.Serialize(res);
                #endregion

            }
            finally
            {
                GuardarLog(traza);
            }

            return res;
        }

        public DTOResultado Login(DTOUsuarioCuerpo usuario)
        {
            DTOResultado res = new DTOResultado();
            TrazaServicio traza = new TrazaServicio();
            try
            {
                #region Trace
                traza.Operacion = MethodBase.GetCurrentMethod().Name;
                traza.FechaEjecucion = DateTime.Now;
                #endregion

                AplicacionSencillaCN aplicacionSencillaCN = new AplicacionSencillaCN();
                res = aplicacionSencillaCN.Login(usuario);

                #region Traza
                traza.Respuesta = Herramientas.Serialize(res);
                #endregion
            }
            catch (Exception ex)
            {
                res.Codigo = Enums.CodigoRespuesta.InternalServiceError;
                res.Mensaje = Herramientas.GetEnumDescription<Enums.CodigoRespuesta>(Enums.CodigoRespuesta.InternalServiceError);
                res.ErrorDePila = ex.Message + " - " + ex.StackTrace;
                traza.DetalleDeExcepcion = ex.Message + " - " + ex.StackTrace;
                #region Trace
                traza.Respuesta = Herramientas.Serialize(res);
                #endregion

            }
            finally
            {
                GuardarLog(traza);
            }

            return res;
        }


        private void GuardarLog(TrazaServicio traza)
        {
            //Metodo utilziado para guardar traza en diferentes opciones dependiendo la implementacion, ya sea en un servicio web alterno o directsamente en base de datos, incluseve en archivos planos.
        }
    }
}
