using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOTORED2.Shared.Models
{
    public class Taller
    {
        public int Idtaller { get; set; }

        public int IdUsuario { get; set; }

        public string Nombre { get; set; }

        public string Pais { get; set; }

        public string Provincia { get; set; }

        public string Localidad { get; set; }

        public string Direccion { get; set; }

        public string Email { get; set; }

        public double Numero { get; set; }

        public DateTime Horarios { get; set; }

        public string LinksMaps { get; set; }

        public string Reseñas { get; set; }
    }
}
