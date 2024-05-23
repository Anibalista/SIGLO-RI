using Microsoft.EntityFrameworkCore;
using RingoEntidades;
using System.Configuration;

namespace RingoEF
{
    public class RingoDbContext : DbContext
    {
        /*En esta clase RingoDBContext lo que digo es que tenemos todas estas claae en mi contexto(usuario,cliente,etc.)
          estas clases se crearán como tablas de la Db.*/
        public DbSet<Provincias> Provincias { get; set; }  // DbSet es otra clase de Entity Framework
        public DbSet<Ciudades> Ciudades { get; set; }
        public DbSet<Barrios> Barrios { get; set; }
        public DbSet<RedesSociales> RedesSociales { get; set; }
        public DbSet<UsersRedesSociales> UsersRedesSociales { get; set; }
        public DbSet<CondicionesFiscales> CondicionesFiscales { get; set; }
        public DbSet<Estados> Estados { get; set; }
        public DbSet<Personas> Personas { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Credenciales> Credenciales { get; set; }
        public DbSet<UsuariosCredenciales> UsuariosCredenciales { get; set; }
        public DbSet<Domicilios> Domicilios { get; set; }
        public DbSet<Clientes> Clientes { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            _ = optionsBuilder.UseSqlServer(connString);
        }

    }
}