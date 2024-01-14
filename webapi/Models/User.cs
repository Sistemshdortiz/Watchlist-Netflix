namespace webapi.Models
{
    public class User: IdentityUser
    {
        public List<Watchlist>? Watchlists { get; set; }
    }
}

