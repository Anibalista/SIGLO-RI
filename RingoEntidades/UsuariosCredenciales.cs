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

        [ForeignKey("Usuario")]
        public int IdUsuario { get; set; }

        [ForeignKey("Credenciales")]
        public int IdCredencial { get; set; }

        public Usuarios? Usuario { get; set; }
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
    }
}
