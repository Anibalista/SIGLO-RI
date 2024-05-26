using RingoDatos;
using RingoEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RingoNegocio
{
    public class PersonasMetodos
    {
        public static List<Estados>? EstadosPorIndole (string indole)
        {
            if (indole == null)
                return null;
            List<Estados>? estados = new();
            estados = RingoDatosEF.EstadosPorIndole(indole);
            return estados;
        }
    }
}
