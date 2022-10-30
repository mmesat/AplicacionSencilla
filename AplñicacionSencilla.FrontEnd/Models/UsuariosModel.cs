using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AplñicacionSencilla.FrontEnd.Models
{
    public class UsuariosModel
    {
        public int Id { get; set; }
        [DisplayName("Nombre")]
        [Required(ErrorMessage = "Nombre no peude ser en blanco")]
        public string Nombre { get; set; }
        [DisplayName("Apellido")]
        [Required(ErrorMessage = "Apellido no peude ser en blanco")]
        public string Apellido { get; set; }
        [DisplayName("Telefono")]
        [Required(ErrorMessage = "Telefono no peude ser en blanco")]
        public string Telefono { get; set; }
        [DisplayName("Direccion")]
        [Required(ErrorMessage = "Direccion no peude ser en blanco")]
        public string Direccion { get; set; }
        [DisplayName("Identificación")]
        [Required(ErrorMessage = "Identificación no peude ser en blanco")]
        public string NumeroIdentificacion { get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage = "Email no peude ser en blanco")]
        public string Email { get; set; }
        [DisplayName("Tipo")]
        [Required(ErrorMessage = "Tipo ID no puede ser en blanco")]
        public string TipoIdentificacion { get; set; }
        [DisplayName("Usuario")]
        [Required(ErrorMessage = "Usuario no puede ser en blanco")]
        public string Usuario { get; set; }
        [DisplayName("Contraseña")]
        [Required(ErrorMessage = "Contraseña no puede ser en blanco")]
        public string Pass { get; set; }
    }
}