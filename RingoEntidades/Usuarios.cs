using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace RingoEntidades
{
    public class Usuarios
    {
        [Key]
        public int IdUsuario {  get; set; }

        [MaxLength(100)]
        public string? NombreUsuario { get; set; }

        [MaxLength(100)]
        public string? ClaveUsuario { get; set; }


    }
}