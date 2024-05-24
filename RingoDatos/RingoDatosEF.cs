using Microsoft.EntityFrameworkCore;
using RingoEF;
using RingoEntidades;
using System.Linq;

namespace RingoDatos
{
    public class RingoDatosEF // en esta clase es donde nos conectamos a la base de datos
    {
        public static RingoDbContext? ringoContext;

        public static Usuarios? Usuario(Usuarios e) // este método debe devolver una lista de Usuario
        {
            ringoContext = new RingoDbContext();
            Usuarios? user = new();

            if (ringoContext.Usuarios == null) //verificamos si existe la tabla usuario (por las dudas)
            {
                return user;
            }

            user = (from usuario in ringoContext.Usuarios
                    where usuario != null && usuario.NombreUsuario == e.NombreUsuario && usuario.ClaveUsuario == e.ClaveUsuario
                    select usuario).FirstOrDefault();
            return user;
        }

        public static List<string?> Accesos(Usuarios e)
        {
            ringoContext = new RingoDbContext();

            List<string?> accesos = new();
            accesos = ringoContext.UsuariosCredenciales
            .Where(uc => uc.IdUsuario == e.IdUsuario)
            .Select(uc => uc.CodigoCredencial)
            .ToList();

            return accesos;
        }

        public static List<Personas> ListaPersonas(Personas c, bool estado)
        {
            string e;
            if (estado)
                e = "Todos";
            else
                e = "Baja";

            ringoContext = new RingoDbContext();
            List<Personas> personas = new();
            personas = ringoContext.Personas.Include("Estados").Where(p =>
            (p.Dni != null ? p.Dni.Contains(c.Dni ?? "") : true)
            ||
            (p.Nombre != null ? p.Nombre.Contains(c.Nombre ?? "") : true)
            ||
            (p.Apellidos != null ? p.Apellidos.Contains(c.Apellidos ?? "") : true)
            ||
            (p.FechaNacimiento != null && c.FechaNacimiento != null && p.FechaNacimiento == c.FechaNacimiento)
            ).Where(p => p.EstadoPersona != null && (p.EstadoPersona != e)).ToList();
            return personas;
        }

        public static Clientes? Cliente(Personas p)
        {
            ringoContext = new RingoDbContext();
            Clientes? cliente = new();
            cliente = ringoContext.Clientes.Include("Personas").Where(c =>  c.IdPersona == p.IdPersona).FirstOrDefault();
            return cliente;
        }


    }
}