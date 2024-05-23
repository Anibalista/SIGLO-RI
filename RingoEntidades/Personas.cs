using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RingoEntidades
{
    public class Personas
    {
        [Key]
        public int IdPersona { get; set; }

        [MaxLength(15)]
        public string? Dni { get; set; }

        [MaxLength(100)]
        public string? Nombre { get; set; }

        [MaxLength(100)]
        public string? Apellidos { get; set; }

        [MaxLength(20)]
        public string? Cuil { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        [MaxLength(200)]
        public string? Observaciones { get; set; }

        [ForeignKey("CondicionFiscal")]
        public int IdCondicionFiscal { get; set; }

        [ForeignKey("Estado")]
        public int IdEstado { get; set; }

        public CondicionesFiscales? CondicionFiscal { get; set; }
        public Estados? Estado { get; set; }

        [NotMapped]
        public string? DetalleFiscal
        {
            get
            {
                if (CondicionFiscal != null)
                    return CondicionFiscal.DetalleFiscal;
                else
                    return null;
            }
        }

        [NotMapped]
        public string? EstadoPersona
        {
            get
            {
                if (Estado != null)
                    return Estado.Estado;
                else
                    return null;
            }
        }
    }
}
