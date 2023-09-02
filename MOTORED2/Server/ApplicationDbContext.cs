using Microsoft.EntityFrameworkCore;
using MOTORED2.Shared.Models;

namespace MOTORED2.Server
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Usuario> usuarios { get; set; } 

        public DbSet<TallerTop>talleresTop { get; set; } 

        public DbSet<Taller> talleres { get; set; } 

        public DbSet<ReportesOpinion> reportes { get; set; } 

        public DbSet<Opiniones> opiniones { get; set; } 

        public DbSet<Motocicletas> motocicletas { get; set;} 
    }
}
