using RingoDatos;
using RingoEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RingoNegocio
{
    public class DomiciliosMetodos
    {

        public static List<Provincias>? ProvinciasTodas ()
        {
            List<Provincias>? provincias = new();
            provincias = RingoDatosEF.Provincias();
            return provincias;
        }
        public static List<Ciudades>? CiudadesTodas()
        {
            List<Ciudades>? ciudades = new();
            ciudades = RingoDatosEF.Ciudades();
            return ciudades;
        }
        public static List<Ciudades>? CiudadesPorProvincia (Provincias p)
        {
            if (p == null)
                return null;
            List<Ciudades>? ciudades = new();
            ciudades = RingoDatosEF.CiudadesPorProvincia(p);
            return ciudades;
        }

        public static List<Domicilios>? DomiciliosPersona (Personas p)
        {
            if (p == null)
                return null;
            List<Domicilios>? domicilios = new();
            domicilios = RingoDatosEF.DomiciliosPorPersona(p);
            return domicilios;
        }
    }
}
