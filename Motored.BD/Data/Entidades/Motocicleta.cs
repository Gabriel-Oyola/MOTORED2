using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motored.BD.Data.Entidades
{
    public class Motocicleta
    {
        [Key]
        public int IdMotocicleta { get; set; }

        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; } 

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public int Anio { get; set; }

        public string Aseguradora { get; set; }
    }
}
