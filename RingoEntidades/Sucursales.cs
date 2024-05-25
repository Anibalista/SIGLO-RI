using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RingoEntidades
{
    public class Sucursales
    {
        [Key]
        public int IdSucursal { get; set; }

        public int IdEmpresa { get; set; }

        public int? IdDomicilio { get; set; }

        public int? NroSucursal { get; set; }

        [MaxLength(100)]
        public string? NroIngresosBrutos { get; set; }

        [MaxLength(50)]
        public string? NombreSucursal { get; set; }

        [ForeignKey("IdEmpresa")]
        public Empresas? Empresas { get; set; }

        [ForeignKey("IdDomicilio")]
        public Domicilios? Domicilios { get; set; }

        [NotMapped]
        public string? RazonSocial
        {
            get
            {
                if (Empresas != null)
                    return Empresas.RazonSocial;
                else
                    return null;
            }
        }

        [NotMapped]
        public string? Cuit
        {
            get
            {
                if (Empresas != null)
                    return Empresas.Cuit;
                else
                    return null;
            }
        }
    }
}
