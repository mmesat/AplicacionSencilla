using AplicacionSencilla.Datos;
using AplicacionSencilla.Entidades;
using AplicacionSencilla.Entidades.WCF;
using AplicacionSencilla.Entidades.WCF.Usuarios;
using AplicacionSencilla.HerramientasComunes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionSencilla.Negocio
{
    public class AplicacionSencillaCN
    {
        AplicacionSencillaCAD  AplicacionSencillaCAD;

        public AplicacionSencillaCN()
        {
            AplicacionSencillaCAD = new AplicacionSencillaCAD();
        }

        public DTOUusarioRespuesta ObtenerUsuarios()
        {
            DTOUusarioRespuesta res = new DTOUusarioRespuesta();
            DTOResultado resultado = new DTOResultado();
            res.Cuerpo = AplicacionSencillaCAD.ObtenerUsuarios();
            resultado.Codigo = Enums.CodigoRespuesta.OK;
            resultado.Mensaje = Herramientas.GetEnumDescription<Enums.CodigoRespuesta>(Enums.CodigoRespuesta.OK);
            res.Resultado = resultado;
            return res;
        }
        public DTOResultado AgregarUsuario(DTOUsuarioCuerpo usuario)
        {
            DTOResultado resultado = new DTOResultado();

            AplicacionSencillaCAD.AgregarUsuario(usuario);
            resultado.Codigo = Enums.CodigoRespuesta.OK;
            resultado.Mensaje = Herramientas.GetEnumDescription<Enums.CodigoRespuesta>(Enums.CodigoRespuesta.OK);
            return resultado;
        }
        public DTOResultado Borrarusuario(DTOUsuarioSolicitud usuario)
        {
            DTOResultado resultado = new DTOResultado();
            AplicacionSencillaCAD.Borrarusuario(usuario);
            resultado.Codigo = Enums.CodigoRespuesta.OK;
            resultado.Mensaje = Herramientas.GetEnumDescription<Enums.CodigoRespuesta>(Enums.CodigoRespuesta.OK);
            return resultado;
        }
        public DTOResultado Login(DTOUsuarioCuerpo usuario)
        {
            DTOResultado resultado = new DTOResultado();
            AplicacionSencillaCAD.Login(usuario);
            resultado.Codigo = Enums.CodigoRespuesta.OK;
            resultado.Mensaje = Herramientas.GetEnumDescription<Enums.CodigoRespuesta>(Enums.CodigoRespuesta.OK);
            return resultado;
        }

    }
}
