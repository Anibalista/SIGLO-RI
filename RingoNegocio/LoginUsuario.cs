using Microsoft.IdentityModel.Tokens;
using RingoDatos;
using RingoEntidades;

namespace RingoNegocio
{
    public class LoginUsuario
    {
        public static bool login (Usuarios u)
        {
            Usuarios? user = RingoDatosEF.usuario(u);
            if (user == null)
            {
                return false;
            } else
            {
                return true;
            }
        }
    }
}