using AplicacionSencilla.Entidades.WCF;
using AplicacionSencilla.Entidades.WCF.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AplicacionSencillaWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IAplicacionSencillaServicio" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IAplicacionSencillaServicio
    {
        [OperationContract]
        DTOUusarioRespuesta ObtenerUusuarios();
        [OperationContract]
        DTOResultado BorrarUusuarios(DTOUsuarioSolicitud usuario);
        [OperationContract]
        DTOResultado AgregarUusuarios(DTOUsuarioCuerpo usuario);
        [OperationContract]
        DTOResultado Login(DTOUsuarioCuerpo usuario);
    }
}
