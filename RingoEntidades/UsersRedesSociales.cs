using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RingoEntidades
{
    public class UsersRedesSociales
    {
        [Key]
        public int IdUserRedSocial { get; set; }

        [MaxLength(100)]
        public string? UsuarioRedSocial { get; set; }

        [ForeignKey("RedSocial")]
        public int IdRedSocial { get; set; }

        RedesSociales? RedSocial { get; set; }

        [NotMapped]
        public string? NombreRedSocial
        {
            get
            {
                if (RedSocial != null)
                    return RedSocial.NombreRedSocial;
                else
                    return null;
            }
        }
    }
}
