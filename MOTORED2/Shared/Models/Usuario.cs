using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOTORED2.Shared.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; } 

        public double DNI { get; set; } 

        public string Email { get; set; }

        public string Contraseña { get; set; }

        public string ConfirmarContraseña { get; set; }

        public string Pais { get; set; }

        public string Provincia { get; set; } 
    }
}
