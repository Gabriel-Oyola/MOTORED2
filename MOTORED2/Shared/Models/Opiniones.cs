using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOTORED2.Shared.Models
{
    public class Opiniones
    {
        public int IdOpinion { get; set; }
        public int IdTaller { get; set; }

        public int IdUsuario { get; set; }

        public string Comentario { get; set; }


        public DateTime Fecha { get; set; }

        public int Estrellas { get; set; }
    }
}
