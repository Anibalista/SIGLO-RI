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

        public static List<Credenciales>? Accesos (Usuarios e)
        {
            ringoContext = new RingoDbContext();
            List<int> ids = new List<int>();
            ids = (from uc in ringoContext.UsuariosCredenciales where uc != null && uc.IdUsuario == e.IdUsuario
                   select uc.IdCredencial).ToList();
            List<Credenciales> credenciales = new();
            credenciales = (from credencial in ringoContext.Credenciales
                            where credencial != null && ids.Contains(credencial.IdCredencial)
                            select credencial).ToList();
            return credenciales;
        }
        
    }
}