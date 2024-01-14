namespace webapi.Datos
{
    public class Watchlist
    {
        public int WatchlistId { get; set; }
        public int UserId { get; set; }
        public int PeliculaId { get; set; }
        public DateTime FechaPeliculaAgregada { get; set; }
    }
}
