using Microsoft.EntityFrameworkCore;
using RingoEF;
using RingoEntidades;
using System.Linq;

namespace RingoDatos
{
    public class RingoDatosEF // en esta clase es donde nos conectamos a la base de datos
    {
        public static RingoDbContext? ringoContext;

        /********************************************************************
         * **********  METODOS DE CONSULTA   ********************************
         * *****************************************************************/
        public static Usuarios? Usuario(Usuarios e) // este método debe devolver una lista de Usuario
        {
            Usuarios? user = new();
            try
            {
                ringoContext = new RingoDbContext();
                user = (from usuario in ringoContext.Usuarios
                        where usuario != null && usuario.NombreUsuario == e.NombreUsuario && usuario.ClaveUsuario == e.ClaveUsuario
                        select usuario).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
            
            return user;
        }

        public static List<string>? Accesos(Usuarios e)
        {
            List<string>? accesos = new();
            try
            {
                ringoContext = new RingoDbContext();
                accesos = (from U in ringoContext.Usuarios
                           join UC in ringoContext.UsuariosCredenciales on U.IdUsuario equals UC.IdUsuario
                           join C in ringoContext.Credenciales on UC.IdCredencial equals C.IdCredencial
                           where U.IdUsuario == e.IdUsuario
                           select C.CodigoCredencial).ToList();
                //Devuelve una lista de string con los códigos de credencial correspondientes a un usuario
            }
            catch (Exception ex)
            {
                accesos.Add(ex.Message);
            }

            return accesos;
        }

        public static List<Personas> ListaPersonas(Personas c, bool baja)
        {
            //el booleano me dice si la busqueda incluye a los estados Baja
            //Así que transformo para facilitar la búsqueda
            string e;
            if (baja)
                e = "Todos";
            else
                e = "Baja";

            List<Personas> personas = new();
            try
            {
                ringoContext = new RingoDbContext();

                /*La búsqueda consiste en buscar personas, incluyendo estados donde coincidan aunque parcialmente
                 * el dni, nombre o apellido. Como filtro de estados se fija si el estado coincide con e
                 * La regla de e significa que si baja es true Cualquier estado va a ser diferente a todos por lo que incluirá a Baja
                 * Si baja es false traera con todos los estados excepto Baja */

                personas = ringoContext.Personas.Include("Estados").Where(p =>
                (p.Dni != null ? p.Dni.Contains(c.Dni ?? "") : true)
                ||
                (p.Nombre != null ? p.Nombre.Contains(c.Nombre ?? "") : true)
                ||
                (p.Apellidos != null ? p.Apellidos.Contains(c.Apellidos ?? "") : true)
                ||
                (p.FechaNacimiento != null && c.FechaNacimiento != null && p.FechaNacimiento == c.FechaNacimiento)
                ).Where(p => p.EstadoPersona != null && (p.EstadoPersona != e)).ToList();
            }
            catch (Exception) { }
            
            return personas;
        }

        public static Clientes? BuscarCliente(Personas p)
        {
            if (p == null)
                return null;
            //trae a un cliente a partir de una persona
            Clientes? cliente = new();
            try
            {
                ringoContext = new RingoDbContext();
                cliente = ringoContext.Clientes.Include("Personas").Where(c => c.IdPersona == p.IdPersona).FirstOrDefault();
            }
            catch (Exception) { }
            
            return cliente;
        }

        public static List<Domicilios>? DomiciliosPorPersona(Personas p)
        {
            if (p == null)
                return null;

            List<Domicilios>? domicilios = new();
            try
            {
                ringoContext = new RingoDbContext();
                domicilios = ringoContext.Domicilios.Where(d => d.IdPersona != null && d.IdPersona == p.IdPersona).ToList();
            }
            catch (Exception) { }

            return domicilios;
        }

        public static Domicilios? DomicilioPorId(int? id)
        {
            if (id == null)
                return null;


            Domicilios? domicilio = new();
            try
            {
                ringoContext = new RingoDbContext();
                domicilio = ringoContext.Domicilios.Where(d => d.IdDomicilio == id).FirstOrDefault();
            }
            catch (Exception) { }

            return domicilio;
        }

        public static List<Barrios>? BarriosPorCiudad(Ciudades? c)
        {
            if (c == null)
                return null;

            List<Barrios>? barrios = new();
            try
            {
                ringoContext = new RingoDbContext();
                barrios = ringoContext.Barrios.Where(b => b.IdCiudad == c.IdCiudad).ToList();
            }
            catch (Exception) { }

            return barrios;
        }

        public static Barrios? BarrioPorDomicilio(Domicilios? d)
        {
            if (d == null || d.IdBarrio == null)
                return null;

            Barrios? barrio = new();
            try
            {
                ringoContext = new RingoDbContext();
                barrio = ringoContext.Barrios.Where(b => b.IdBarrio == d.IdBarrio).FirstOrDefault();
            }
            catch (Exception) { }

            return barrio;
        }

        public static List<Ciudades>? Ciudades()
        {
            List<Ciudades>? ciudades = new();
            try
            {
                ringoContext = new RingoDbContext();
                ciudades = ringoContext.Ciudades.ToList();
            }
            catch (Exception) { }
            
            return ciudades;
        }

        public static List<Provincias>? Provincias()
        {
            List<Provincias>? provincias = new();
            try
            {
                ringoContext = new RingoDbContext();
                provincias = ringoContext.Provincias.ToList();
            }
            catch (Exception) { }

            return provincias;
        }

        public static Ciudades? CiudadPorDomicilio (Domicilios? d)
        {
            if (d == null)
                return null;

            Ciudades? ciudad = new();
            try
            {
                ringoContext = new RingoDbContext();
                ciudad = ringoContext.Ciudades.Include("Provincias").Where(c => d.IdCiudad != null && c.IdCiudad == d.IdCiudad).FirstOrDefault();
            }
            catch (Exception) { }

            return ciudad;
        }

        public static List<Estados>? EstadosPorIndole (string? indole)
        {
            if (String.IsNullOrWhiteSpace(indole))
                return null;

            List<Estados>? estados = new();
            try
            {
                ringoContext = new RingoDbContext();
                estados = ringoContext.Estados.Where(e => String.Equals(e.Indole, indole, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            catch (Exception) { }

            return estados;
        }

        public List<Contactos>? ContactosPorPersona (Personas? p)
        {
            if (p == null)
                return null;

            List<Contactos>? contactos = new();
            try
            {
                ringoContext = new RingoDbContext();
                contactos = ringoContext.Contactos.Include("UsersRedesSociales").Where(c => c.IdPersona != null && c.IdPersona == p.IdPersona).ToList();
            }
            catch (Exception) { }

            return contactos;
        }

        public List<Contactos>? ContactosPorEmpresa(Empresas? e)
        {
            if (e == null)
                return null;

            List<Contactos>? contactos = new();
            try
            {
                ringoContext = new RingoDbContext();
                contactos = ringoContext.Contactos.Include("UsersRedesSociales").Where(c => c.IdEmpresa != null && c.IdEmpresa == e.IdEmpresa).ToList();
            }
            catch (Exception) { }

            return contactos;
        }

        public List<Contactos>? ContactosPorSucursal(Sucursales? s)
        {
            if (s == null)
                return null;

            List<Contactos>? contactos = new();
            try
            {
                ringoContext = new RingoDbContext();
                contactos = ringoContext.Contactos.Include("UsersRedesSociales").Where(c => c.IdSucursal != null && c.IdSucursal == s.IdSucursal).ToList();
            }
            catch (Exception) { }

            return contactos;
        }

        public List<RedesSociales>? RedesSociales()
        {
            List<RedesSociales>? redesSociales = new();
            try
            {
                ringoContext = new RingoDbContext();
                redesSociales = ringoContext.RedesSociales.ToList();
            }
            catch (Exception) { }

            return redesSociales;
        }


        /********************************************************************
         * **********  METODOS DE INSERCION   ********************************
         * *****************************************************************/

    }
}