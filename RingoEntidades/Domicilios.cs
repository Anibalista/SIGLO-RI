using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RingoEntidades
{
    public class Domicilios
    {
        [Key]
        public int IdDomicilio { get; set; }

        [MaxLength(100)]
        public string? Calle { get; set; }

        [MaxLength(10)]
        public string? Altura { get; set; }

        [MaxLength(10)]
        public string? Piso { get; set; }

        [MaxLength(10)]
        public string? Departamento { get; set;}

        [MaxLength(200)]
        public string? ObservacionesBarrio { get; set; }

        public int? IdCiudad { get; set; }

        public int? IdBarrio { get; set; }

        public int? IdPersona { get; set; }

        [ForeignKey("IdCiudad")]
        public Ciudades? Ciudades { get; set; }

        [ForeignKey("IdBarrio")]
        public Barrios? Barrios { get; set; }

        [ForeignKey("IdPersona")]
        public Personas? Personas { get; set; }

        [NotMapped]
        public string? NombreCiudad
        {
            get
            {
                if (Ciudades != null)
                    return Ciudades.NombreCiudad;
                else
                    return null;
            }
        }

        [NotMapped]
        public int? CodigoPostal
        {
            get
            {
                if (Ciudades != null)
                    return Ciudades.CodigoPostal;
                else
                    return null;
            }
        }

        [NotMapped]
        public string? NombreBarrio
        {
            get
            {
                if (Barrios != null)
                    return Barrios.NombreBarrio;
                else
                    return null;
            }
        }


        [NotMapped]
        public string? Nombres
        {
            get
            {
                if (Personas != null)
                    return Personas.Nombre;
                else
                    return null;
            }
        }

        [NotMapped]
        public string? Apellidos
        {
            get
            {
                if (Personas != null)
                    return Personas.Apellidos;
                else
                    return null;
            }
        }

        [NotMapped]
        public string? DNI
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
        public string? EstadoPersona
        {
            get
            {
                if (Personas != null)
                    return Personas.EstadoPersona;
                else
                    return null;
            }
        }

        [NotMapped]
        public string? CondFiscal
        {
            get
            {
                if (Personas != null)
                    return Personas.DetalleFiscal;
                else
                    return null;
            }
        }

        [NotMapped]
        public string? CUIL
        {
            get
            {
                if (Personas != null)
                    return Personas.Cuil;
                else
                    return null;
            }
        }

        [NotMapped]
        public string? Observaciones
        {
            get
            {
                if (Personas != null)
                    return Personas.Observaciones;
                else
                    return null;
            }
        }
    }
}
