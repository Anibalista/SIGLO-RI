using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RingoEntidades
{
    public class Barrios
    {
        [Key]
        public int IdBarrio { get; set; }

        [MaxLength(100)]
        public string? NombreBarrio { get; set; }

        [ForeignKey("Ciudad")]
        public int? IdCiudad {  get; set; }

        public Ciudades? Ciudad { get; set; }

        [NotMapped]
        public string? NombreCiudad
        {
            get
            {
                if (IdCiudad != null)
                    return Ciudad.NombreCiudad;
                else
                    return null;
            }
        }
    }
}
