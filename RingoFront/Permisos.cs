using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RingoFront
{
    public class Permisos
    {
        public List<string>? PermisosUsuario { get; set; }

        public Permisos(List<string>? permisosUsuario) => PermisosUsuario = permisosUsuario;

    }
}
