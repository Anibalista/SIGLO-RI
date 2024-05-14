using Microsoft.EntityFrameworkCore;
using RingoEF;
using RingoEntidades;

namespace RingoDatos
{
    public class RingoDatosEF // en esta clase es donde nos conectamos a la base de datos
    {
        public static RingoDbContext? ringoContext;

        public static Usuarios usuario (Usuarios e) // este método debe devolver una lista de Usuario
        {
            ringoContext = new RingoDbContext();
            Usuarios? user = new();

            if (ringoContext.usuarios == null) //verificamos si existe la tabla usuario (por las dudas)
            {
                return user;
            }


            user = ringoContext.usuarios.Where(u => u.NombreUsuario == e.NombreUsuario && u.ClaveUsuario == e.ClaveUsuario).FirstOrDefault();

            return user;
        }
    }
}