using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RingoEntidades
{
    public class SubCategoriasPrendas
    {
        [Key]
        public int IdSubCategoriaPrenda { get; set; }

        [MaxLength(100)]
        public required string SubCategoria { get; set; }

        [ForeignKey("CategoriaPrenda")]
        public int IdCategoriaPrenda { get; set; }

        CategoriasPrendas? CategoriaPrenda { get; set; }

        [NotMapped] //EF
        //este campo es para la grilla porque no tiene la inteligencia de mostrar el nombre del dpto usando el objeto "Departamento"
        public string? Categoria
        {
            get
            {
                if (CategoriaPrenda != null)
                    return CategoriaPrenda.Categoria;
                else
                    return null;
            }
        }
    }
}
