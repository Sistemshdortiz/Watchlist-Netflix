using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WatchlistNetflix_V2.Data;

namespace WatchlistNetflix_V2.Context
{
    public class AplicationDbContext : IdentityUserContext<IdentityUser>
    {
        //constructor de la clase que hereda de IdentityDbContext y recibe como parametro un objeto de tipo DbContextOptions
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<WatchlistNetflix_V2.Data.Watchlist>? Watchlists { get; set; }

    }
}
