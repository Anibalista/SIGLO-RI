using Microsoft.EntityFrameworkCore;
using RingoEF;
using RingoEntidades;

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

            user = ringoContext.Usuarios.Where(u => u.NombreUsuario == e.NombreUsuario && u.ClaveUsuario == e.ClaveUsuario).FirstOrDefault();
            return user;
        }

        public static List<string> Credenciales(Usuarios e)
        {
            ringoContext = new RingoDbContext();
            List<string> referencias = new();
            //List<Credenciales> credenciales = new();

            if(ringoContext.Usuarios == null || ringoContext.Credenciales == null || ringoContext.UsuariosCredenciales == null) 
            {
                return referencias;
            }


            
            referencias = ringoContext.Credenciales.Join(ringoContext.UsuariosCredenciales,
                          c => c.IdCredencial, uc => uc.IdCredencial,(c, uc) => new
                                                                     {
                                                                        Credencial = c,
                                                                        IdUsuario = uc.IdUsuario
                                                                     })
                                                .Where(joined => joined.IdUsuario == e.IdUsuario)
                                                .Select(joined => joined.Credencial.CodigoCredencial)
                                                .ToList();
           
            //permisos = ringoContext.credenciales
            //credenciales = ringoContext.Credenciales.Where(c => ringoContext.UsuariosCredenciales.Any(
            //  uc => uc.IdUsuario == e.IdUsuario && uc.IdCredencial == c.IdCredencial)).ToList();

            return referencias;
        }
        
    }
}