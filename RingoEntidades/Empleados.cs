using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RingoEntidades
{
    public class Empleados
    {
        [Key]
        public int IdEmpleado { get; set; }

        public int IdPersona { get; set; }

        public int IdEstado { get; set; }

        public int IdPuesto { get; set; }

        [MaxLength(50)]
        public string? Legajo { get; set; }

        public DateTime? FechaIngreso { get; set; }

        [ForeignKey("IdPersona")]
        public Personas? Personas { get; set; }

        [ForeignKey("IdEstado")]
        public Estados? Estados { get; set; }

        [ForeignKey("IdPuesto")]
        public Puestos? Puestos { get; set; }

        [NotMapped]
        public string? NombreYApellido
        {
            get
            {
                if (Personas != null)
                    return Personas.Nombre+" "+Personas.Apellidos;
                else
                    return null;
            }
        }

        [NotMapped]
        public string? Dni
        {
            get
            {
                if (Personas != null)
                    return Personas.Dni;
                else
                    return null;
            }
        }

        [NotMapped]
        public string? Estado
        {
            get
            {
                if (Estados != null)
                    return Estados.Estado;
                else
                    return null;
            }
        }

        [NotMapped]
        public string? Puesto
        {
            get
            {
                if (Puestos != null)
                    return Puestos.Puesto;
                else
                    return null;
            }
        }

        [NotMapped]
        public string? DescripcionPuesto
        {
            get
            {
                if (Puestos != null)
                    return Puestos.DescripcionPuesto;
                else
                    return null;
            }
        }
    }
}
