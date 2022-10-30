using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionSencilla.Entidades.WCF.Usuarios
{
    public class DTOUsuarioCuerpo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string Email { get; set; }
        public string TipoIdentificacion { get; set; }
        public string Usuario { get; set; }
        public DTOLoginCuerpo Login {get;set;}
    }
}
