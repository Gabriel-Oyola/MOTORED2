using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Motored.BD.Data.Entidades
{
    public class Opinion
    {
        [Key]
        public int IdOpinion { get; set; }
        public int IdTaller { get; set; }
        public Taller taller { get; set; }

        public int IdUsuario { get; set; } 
        public Usuario usuario { get; set; } 


        public string Comentario { get; set; }


        public DateTime Fecha { get; set; }

        public int Estrellas { get; set; } 
    }
}
