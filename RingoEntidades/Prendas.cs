using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RingoEntidades
{
    public class Prendas
    {
        [Key]
        public int IdPrenda { get; set; }

        [MaxLength(30)]
        public string? CodigoPrenda { get; set; }

        public int? IdSubCategoriaPrenda { get; set; }

        public int? IdTela { get; set; }

        [MaxLength(150)]
        public string? DescripcionPrenda { get; set; }

        [ForeignKey("IdSubCategoriaPrenda")]
        public SubCategoriasPrendas? SubCategoriaPrenda { get; set; }

        [ForeignKey("IdTela")]
        public Telas? TelaPrenda { get; set; }

        [NotMapped]
        public string? SubCategoria
        {
            get
            {
                if (SubCategoriaPrenda != null)
                    return SubCategoriaPrenda.SubCategoria;
                else
                    return null;
            }
        }

        [NotMapped]
        public string? Categoria
        {
            get
            {
                if (SubCategoriaPrenda != null)
                    return SubCategoriaPrenda.Categoria;
                else
                    return null;
            }
        }

        [NotMapped]
        public string? Tela
        {
            get
            {
                if (TelaPrenda != null)
                    return TelaPrenda.Tela;
                else
                    return null;
            }
        }
    }
}
