using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliculasController : ControllerBase
    {
        private readonly AplicationDBContext _context;

        public PeliculasController(AplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PeliculaDto>>> GetPeliculas()
        {
            var peliculasDto = new List<PeliculaDto>();
            var peliculas = _context.Peliculas;

            foreach (var p in peliculas)
            {
                var peliculaDto = new PeliculaDto
                {
                   Titulo = p.Titulo,
                   Genero = p.Genero,
                   Resumen = p.Resumen,
                   RutaImagen = p.RutaImagen,

                };
                peliculasDto.Add(peliculaDto);
            }

            return Ok(peliculasDto);
        }

      

    }
}
