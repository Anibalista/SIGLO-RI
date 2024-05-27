using Microsoft.IdentityModel.Tokens;
using RingoDatos;
using RingoEntidades;

namespace RingoNegocio
{
    public class LoginUsuario
    {
        public static bool login (Usuarios u) //el método login recibe como parámetro un objeto Usuario. login devuelve un bool.
        {
           // Usuarios user = RingoDatosEF.usuario(u);
            if (RingoDatosEF.usuario(u) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}