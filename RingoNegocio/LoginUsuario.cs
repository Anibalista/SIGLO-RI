using Microsoft.IdentityModel.Tokens;
using RingoDatos;
using RingoEntidades;

namespace RingoNegocio
{
    public class LoginUsuario
    {
        public static int login (Usuarios u)
        {
            Usuarios? user = RingoDatosEF.Usuario(u);
            if (user == null)
                return 0;
            return user.IdUsuario;
        }

        public static bool Permisos(Usuarios u)
        {
            bool tiene = false;
            List<string>? credenciales = RingoDatosEF.Accesos(u);
            if (credenciales != null)
            {
                Llaves.CodigosAcceso = credenciales;
                tiene = true;
            }
            return tiene;
        }
    }

}