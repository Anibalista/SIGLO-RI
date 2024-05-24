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

        public static List<string?> Permisos(Usuarios u)
        {

            List<string?> credenciales = new();
            try
            {
                credenciales = RingoDatosEF.Accesos(u);
            } catch (Exception ex)
            {
                string nula = ex.Message;
                credenciales.Add(nula);
            }

            return credenciales;
        }
    }
}