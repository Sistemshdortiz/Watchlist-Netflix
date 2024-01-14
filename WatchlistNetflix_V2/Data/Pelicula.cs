namespace WatchlistNetflix_V2.Data
{
    public class Pelicula
    {
        public int PeliculaId { get; set; }
        public string Titulo { get; set; }
        public string? Genero { get; set; }
        public string? Resumen { get; set; }
        public string? RutaImagen { get; set; }
    }
}
