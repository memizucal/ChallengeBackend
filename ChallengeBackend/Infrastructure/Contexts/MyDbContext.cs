using Microsoft.EntityFrameworkCore;

namespace ChallengeBackend.Contexts
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
        public virtual DbSet<Personaje> Personaje { get; set; }
        public virtual DbSet<PelículaOSerie> PelículaOSerie { get; set; }
        public virtual DbSet<Género> Género { get; set; }
    }
}
