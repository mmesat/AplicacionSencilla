using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionSencilla.Entidades.WCF.Usuarios
{
    public class DTOLoginRespuesta
    {
        [DataMember]
        public List<DTOLoginCuerpo> Cuerpo { get; set; }
        public DTOResultado Resultado { get; set; }
    }
}
