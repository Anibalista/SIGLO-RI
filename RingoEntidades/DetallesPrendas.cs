using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RingoEntidades
{
    public class DetallesPrendas
    {
        [Key]
        public int IdDetallePrenda { get; set; }

        public string? CodigoDetalle { get; set; }
        
        [Column(TypeName ="decimal(10,2)")]
        public decimal? PrecioVenta { get; set; }

        [MaxLength(50)]
        public string? Color { get; set; }

        public int CantidadPrenda { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal? CostoPrenda { get; set; }

        [ForeignKey("Prenda")]
        public int IdPrenda { get; set; }

        [ForeignKey("Talle")]
        public int IdTalle { get; set; }

        public Prendas? Prenda { get; set; }
        public Talles? Talle { get; set; }

        [NotMapped]
        public string? NroTalle
        {
            get
            {
                if (Talle != null)
                    return Talle.NroTalle;
                else
                    return null;
            }
        }

        [NotMapped]
        public string? DescripcionTalle
        {
            get
            {
                if (Talle != null)
                    return Talle.DescripcionTalle;
                else
                    return null;
            }
        }

        [NotMapped]
        public int? CodigoPrenda
        {
            get
            {
                if (Prenda != null)
                    return Prenda.CodigoPrenda;
                else
                    return null;
            }
        }

        [NotMapped]
        public string? DescripcionPrenda
        {
            get
            {
                if (Prenda != null) 
                    return Prenda.DescripcionPrenda;
                else 
                    return null;
            }
        }

        [NotMapped]
        public string? CategoriaPrenda
        {
            get 
            {
                if (Prenda != null)
                    return Prenda.Categoria;
                else
                    return null;
            }
        }

        [NotMapped]
        public string? SubCategoriaPrenda
        {
            get
            {
                if (Prenda != null)
                    return Prenda.SubCategoria;
                else
                    return null;
            }
        }

        [NotMapped]
        public string? Tela
        {
            get
            {
                if (Prenda != null)
                    return Prenda.Tela;
                else
                    return null;
            }
        }
    }
}
