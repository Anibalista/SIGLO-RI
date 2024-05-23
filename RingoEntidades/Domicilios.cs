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

        [ForeignKey("Ciudad")]
        public int? IdCiudad {  get; set; }

        [ForeignKey("Barrio")]
        public int? IdBarrio { get; set; }

        [ForeignKey("Persona")]
        public int? IdPersona { get; set; }

        public Ciudades? Ciudad { get; set; }
        public Barrios? Barrio { get; set; }
        public Personas? Persona { get; set; }

        [NotMapped]
        public string? NombreCiudad
        {
            get
            {
                if (Ciudad != null)
                    return Ciudad.NombreCiudad;
                else
                    return null;
            }
        }

        [NotMapped]
        public int? CodigoPostal
        {
            get
            {
                if (Ciudad != null)
                    return Ciudad.CodigoPostal;
                else
                    return null;
            }
        }

        [NotMapped]
        public string? NombreBarrio
        {
            get
            {
                if (Barrio != null)
                    return Barrio.NombreBarrio;
                else
                    return null;
            }
        }


        [NotMapped]
        public string? Nombres
        {
            get
            {
                if (Persona != null)
                    return Persona.Nombre;
                else
                    return null;
            }
        }

        [NotMapped]
        public string? Apellidos
        {
            get
            {
                if (Persona != null)
                    return Persona.Apellidos;
                else
                    return null;
            }
        }

        [NotMapped]
        public string? DNI
        {
            get
            {
                if (Persona != null)
                    return Persona.Dni;
                else
                    return null;
            }
        }

        [NotMapped]
        public string? EstadoPersona
        {
            get
            {
                if (Persona != null)
                    return Persona.EstadoPersona;
                else
                    return null;
            }
        }

        [NotMapped]
        public string? CondFiscal
        {
            get
            {
                if (Persona != null)
                    return Persona.DetalleFiscal;
                else
                    return null;
            }
        }

        [NotMapped]
        public string? CUIL
        {
            get
            {
                if (Persona != null)
                    return Persona.Cuil;
                else
                    return null;
            }
        }

        [NotMapped]
        public string? Observaciones
        {
            get
            {
                if (Persona != null)
                    return Persona.Observaciones;
                else
                    return null;
            }
        }
    }
}
