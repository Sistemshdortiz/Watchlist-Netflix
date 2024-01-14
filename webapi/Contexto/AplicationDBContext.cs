

namespace webapi.Contexto
{
    public class AplicationDBContext:  IdentityDbContext
    {
        //constructor de la clase que hereda de IdentityDbContext y recibe como parametro un objeto de tipo DbContextOptions
        public AplicationDBContext(DbContextOptions<AplicationDBContext> options): base(options)
        {
        }

        public DbSet<PeliculaDto> Peliculas { get; set; }
        public DbSet<Watchlist> Watchlists { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
