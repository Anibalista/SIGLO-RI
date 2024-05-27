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

        public static List<RedesSociales>? RedesSociales ()
        {
            List<RedesSociales>? redesSociales = new();
            redesSociales = RingoDatosEF.RedesSociales();
            return redesSociales;
        }

        public static List<Personas>? buscarPersonas(Clientes c,Personas p, Ciudades ci, bool baja)
        {
            List<Personas>? personas = new();
            personas = RingoDatosEF.BuscarPersonas(c, p, ci, baja);
            return personas;
        }


    }
}
