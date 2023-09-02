using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motored.BD.Data.Entidades
{
    public class ReporteOpinion
    {
        public int IdUsuarioRC { get; set; } 
        public Usuario Usuario { get; set; }

        public int IdTaller { get; set; }
        public Taller Taller { get; set; }

        public int IdOpinion { get; set; } 
        public Opinion Opinion { get; set; }

        [Key]
        public int IdReporte { get; set; }


        public string Comentario { get; set; }

        public DateTime Fecha { get; set; }

        public int Estrellas { get; set; }

        public string Motivo { get; set; }

        public string sancion { get; set; }
    }
}
