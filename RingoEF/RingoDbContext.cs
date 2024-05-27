using Microsoft.EntityFrameworkCore;
using RingoEntidades;
using System.Configuration;

namespace RingoEF
{
    public class RingoDbContext : DbContext
    {
        /*En esta clase RingoDBContext lo que digo es que tenemos todas estas claae en mi contexto(usuario,cliente,etc.)
          estas clases se crearán como tablas de la Db.*/
        // public DbSet<Usuarios1> usuarios { get; set; }   // DbSet es otra clase de Entity Framework

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
        public DbSet<Puestos> Puestos { get; set; }
        public DbSet<Empleados> Empleados { get; set; }
        public DbSet<Empresas> Empresas { get; set; }
        public DbSet<Sucursales> Sucursales { get; set; }
        public DbSet<Proveedores> Proveedores { get; set; }
        public DbSet<Contactos> Contactos { get; set; }
        public DbSet<EstadosHistorias> EstadosHistorias { get; set; }
        public DbSet<Telas> Telas { get; set; }
        public DbSet<Talles> Talles { get; set; }
        public DbSet<CategoriasPrendas> CategoriasPrendas { get; set; }
        public DbSet<SubCategoriasPrendas> SubCategoriasPrendas { get; set; }
        public DbSet<Prendas> Prendas { get; set; }
        public DbSet<DetallesPrendas> DetallesPrendas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            optionsBuilder.UseSqlServer(connString);
        }
    }
}