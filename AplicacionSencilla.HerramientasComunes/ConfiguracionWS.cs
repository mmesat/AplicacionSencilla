using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AplicacionSencilla.HerramientasComunes
{
    public class ConfiguracionWS
    {
        public static string ObtewnerCadenaDeConexion()
        {
            var valor = ConfigurationManager.ConnectionStrings["Conexion"];

            if (valor == null)
            {
                throw new Exception("Conexion a Base de datos no configurada.");
            }

            return valor.ToString();
        }
    }
}
