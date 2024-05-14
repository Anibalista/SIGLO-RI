using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RingoEntidades
{
    public class UsuariosCredenciales
    {
        [Key]
        public int IdUsuario { get; set; }

        [Key]
        public int IdCredencial { get; set; }
    }
}
