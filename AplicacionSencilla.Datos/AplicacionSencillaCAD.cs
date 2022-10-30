using AplicacionSencilla.Entidades.WCF.Usuarios;
using AplicacionSencilla.HerramientasComunes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace AplicacionSencilla.Datos
{
    public class AplicacionSencillaCAD
    {
        public List<DTOUsuarioCuerpo> ObtenerUsuarios()
        {
            List<DTOUsuarioCuerpo> Cuerpo = null;
            using (SqlConnection conexion = new SqlConnection(ConfiguracionWS.ObtewnerCadenaDeConexion()))
            {
                Cuerpo = conexion.Query<DTOUsuarioCuerpo>("dbo.SP_ObtenerUsuarios", transaction: null, buffered: false, commandTimeout: null, commandType: CommandType.StoredProcedure).ToList();
            }
            return Cuerpo;
        }

        public void Borrarusuario(DTOUsuarioSolicitud solicitud)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", solicitud.Id);
            using (SqlConnection conexion = new SqlConnection(ConfiguracionWS.ObtewnerCadenaDeConexion()))
            {
                conexion.Execute("dbo.SP_BorrarUsuario", param: parameters, transaction: null, commandTimeout: null, commandType: CommandType.StoredProcedure);
            }
        }

        public void AgregarUsuario(DTOUsuarioCuerpo usuario)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Nombre", usuario.Nombre);
            parameters.Add("@Apellido", usuario.Apellido);
            parameters.Add("@Direccion", usuario.Direccion);
            parameters.Add("@Telefono", usuario.Telefono);
            parameters.Add("@NumeroIdentificacion", usuario.NumeroIdentificacion);
            parameters.Add("@Email", usuario.Email);
            parameters.Add("@TipoIdentificacion", usuario.TipoIdentificacion);
            parameters.Add("@Usuario", usuario.Login.Usuario);
            parameters.Add("@Pass", usuario.Login.Pass);
            using (SqlConnection conexion = new SqlConnection(ConfiguracionWS.ObtewnerCadenaDeConexion()))
            {
                conexion.Execute("dbo.AgregarUsuario", param: parameters, transaction: null, commandTimeout: null, commandType: CommandType.StoredProcedure);
            }
        }

        public void Login(DTOUsuarioCuerpo usuario)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Usuario", usuario.Login.Usuario);
            parameters.Add("@Pass", usuario.Login.Pass);
            using (SqlConnection conexion = new SqlConnection(ConfiguracionWS.ObtewnerCadenaDeConexion()))
            {
                conexion.Execute("dbo.SP_Login", param: parameters, transaction: null, commandTimeout: null, commandType: CommandType.StoredProcedure);
            }
        }

    }
}
