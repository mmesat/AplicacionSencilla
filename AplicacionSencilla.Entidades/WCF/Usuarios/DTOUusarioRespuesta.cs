using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace AplicacionSencilla.Entidades.WCF.Usuarios
{
    public class DTOUusarioRespuesta
    { 
        [DataMember]
        public List<DTOUsuarioCuerpo> Cuerpo { get; set; }
        public DTOResultado Resultado { get; set; }
    }
}
