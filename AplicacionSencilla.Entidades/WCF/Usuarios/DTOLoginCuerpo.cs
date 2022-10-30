using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionSencilla.Entidades.WCF.Usuarios
{
    public class DTOLoginCuerpo
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Pass { get; set; }

    }
}
