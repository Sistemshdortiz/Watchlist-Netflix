namespace WatchlistNetflix_V2.Data
{
    public class Watchlist
    {
        public int WatchlistId { get; set; }
        public string NombreLista { get; set; }
        public User User { get; set; }
        public List<Pelicula> Peliculas { get; set; }
    }
}
