using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motored.BD.Data.Entidades
{
    public class TallerTop
    {
        [Key]
        public int idRanking { get; set; }
        public int IdTaller { get; set; }
        public Taller Taller { get; set; }

        public int rating { get; set; }

        public string Nombre { get; set; }

        public string LinkTaller { get; set; }
    }
}
