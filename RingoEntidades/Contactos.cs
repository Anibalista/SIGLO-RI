using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RingoEntidades
{
    public class Contactos
    {
        [Key]
        public int IdContacto { get; set; }

        public int? IdPersona { get; set; }

        public int? IdEmpresa { get; set; }

        public int? IdSucursal { get; set; }

        public int? IdUserRedSocial { get; set; }

        [MaxLength(20)]
        public string? Telefono { get; set; }

        [MaxLength(100)]
        public string? Email { get; set; }

        [ForeignKey("IdPersona")]
        public Personas? Personas { get; set; }

        [ForeignKey("IdEmpresa")]
        public Empresas? Empresas { get; set; }

        [ForeignKey("IdSucursal")]
        public Sucursales? Sucursales { get; set; }

        [ForeignKey("IdUserRedSocial")]
        public UsersRedesSociales? UsersRedesSociales { get; set; }

        [NotMapped]
        public string? UsuarioRedSocial
        {
            get
            {
                if (UsersRedesSociales != null)
                    return UsersRedesSociales.UsuarioRedSocial;
                else
                    return null;
            }
        }

        [NotMapped]
        public string? NombreRedSocial
        {
            get
            {
                if (UsersRedesSociales != null)
                    return UsersRedesSociales.NombreRedSocial;
                else
                    return null;
            }
        }
    }
}
