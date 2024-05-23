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

        public int? CodigoPrenda { get; set; }

        [MaxLength(150)]
        public string? DescripcionPrenda { get; set; }

        [ForeignKey("CategoriaPrenda")]
        public int? IdCategoriaPrenda {  get; set; }

        [ForeignKey("SubCategoriaPrenda")]
        public int? IdSubCategoriaPrenda { get; set; }

        [ForeignKey("Tela")]
        public int? IdTela { get; set; }

        CategoriasPrendas? CategoriaPrenda { get; set; }
        SubCategoriasPrendas? SubCategoriaPrenda { get; set; }
        Telas? TelaPrenda { get; set; }

        

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
                if (SubCategoria != null)
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
