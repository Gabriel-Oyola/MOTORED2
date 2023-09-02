using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOTORED2.Shared.Models
{
    public class ReportesOpinion
    {
        public int IdUsuarioRC { get; set; }

        public int IdTaller { get; set; }

        public int IdOpinion { get; set; }

        public int IdReporte { get; set; }

        public string Comentario { get; set; }

        public DateTime Fecha { get; set; }

        public int Estrellas { get; set; }

        public string Motivo { get; set; }

        public string sancion { get; set; }
    }
}
