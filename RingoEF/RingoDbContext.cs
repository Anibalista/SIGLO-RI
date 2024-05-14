using Microsoft.EntityFrameworkCore;
using RingoEntidades;
using System.Configuration;

namespace RingoEF
{
    public class RingoDbContext : DbContext
    {
        /*En esta clase RingoDBContext lo que digo es que tenemos todas estas claae en mi contexto(usuario,cliente,etc.)
          estas clases se crearán como tablas de la Db.*/
        public DbSet<Usuarios> usuarios { get; set; }   // DbSet es otra clase de Entity Framework
        /*public DbSet<Credenciales> credenciales { get; set; }
        public DbSet<UsuariosCredenciales> usuariosCredenciales { get; set; }
        */
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            _ = optionsBuilder.UseSqlServer(connString);
        }
    }
}