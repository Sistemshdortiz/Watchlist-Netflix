using Microsoft.AspNetCore.Identity;

namespace WatchlistNetflix_V2.Data
{
    public class User: IdentityUser
    {
        public List<Watchlist>? Watchlists { get; set; }
    }
}
