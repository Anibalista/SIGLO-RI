using RingoDatos;
using RingoEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RingoNegocio
{
    public class ContactosMetodos
    {
        public static List<Contactos>? ContactosPorPersona(Personas p)
        {
            List<Contactos>? contactos = new();
            contactos = RingoDatosEF.ContactosPorPersona(p);
            return contactos;
        }
    }
}
