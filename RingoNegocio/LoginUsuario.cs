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

        public static List<string>? Permisos(Usuarios u)
        {
            List<string>? credenciales = new();
            credenciales = RingoDatosEF.Accesos(u);
            return credenciales;
        }
    }
}