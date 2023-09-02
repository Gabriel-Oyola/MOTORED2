using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOTORED2.Shared.Models
{
    public class Motocicletas
    {
        public int IdMoto { get; set; }

        public int IdUsuario { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public int Anio { get; set; }

        public string Aseguradora { get; set; }
    }
}
