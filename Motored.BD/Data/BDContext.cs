using Microsoft.EntityFrameworkCore;
using Motored.BD.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motored.BD.Data
{
    public class BDContext : DbContext
    {
        public BDContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Usuario> usuarios { get; set; }

        public DbSet<TallerTop> talleresTop { get; set; }

        public DbSet<Taller> talleres { get; set; }

        public DbSet<ReporteOpinion> reportes { get; set; } 

        public DbSet<Opinion> opiniones { get; set; }

        public DbSet<Motocicleta> motocicletas { get; set; }  
    }
}
