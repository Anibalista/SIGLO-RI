using Microsoft.IdentityModel.Tokens;
using RingoDatos;
using RingoEntidades;

namespace RingoNegocio
{
    public class LoginUsuario
    {
        public static bool login (Usuarios u)
        {
            Usuarios? user = RingoDatosEF.Usuario(u);
            if (user == null)
            {
                return false;
            } else
            {
                return true;
            }
        }

        public static List<string>? Permisos(Usuarios u)
        {
            List<string> codigos = new();
            try
            {
                codigos = RingoDatosEF.Credenciales(u);
            } catch (Exception ex)
            {
                
            }
            


            return codigos;
        }
    }
}