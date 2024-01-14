namespace webapi.Datos
{
    public class Watchlist
    {
        public int WatchlistId { get; set; }
        public string NombreLista { get; set; }
        public User User { get; set; }
        public List<Pelicula> Peliculas { get; set; }
    }
}
