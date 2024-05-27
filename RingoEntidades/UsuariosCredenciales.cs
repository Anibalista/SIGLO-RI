using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RingoEntidades
{
    public class UsuariosCredenciales
    {
        [Key]
        public int IdUsuarioCredencial { get; set; }

        public int IdUsuario { get; set; }

        public int IdCredencial { get; set; }

        [ForeignKey("IdUsuario")]
        public Usuarios? Usuarios { get; set; }

        [ForeignKey("IdCredencial")]
        public Credenciales? Credenciales { get; set; }

        [NotMapped] //EF
        //este campo es para la grilla porque no tiene la inteligencia de mostrar el nombre del dpto usando el objeto "Departamento"
        public string? CodigoCredencial
        {
            get
            {
                if (Credenciales != null)
                    return Credenciales.CodigoCredencial;
                else
                    return null;
            }
        }

        [NotMapped]
        public string? NombreYApellido
        {
            get
            {
                if (Usuarios != null)
                    return Usuarios.Nombre+" "+Usuarios.Apellidos;
                else
                    return null;
            }
        }
    }
}
