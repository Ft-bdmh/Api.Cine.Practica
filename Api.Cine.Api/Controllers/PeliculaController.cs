using Api.Cine.BusinessLogic.Peliculas;
using Api.Cine.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Cine.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliculaController : ControllerBase
    {
        private readonly PeliculaBL peliculaBL;

        public PeliculaController()
        {
            peliculaBL = new PeliculaBL();
        }


        [HttpGet()]
        [Route("GetPeliculas")]

        public async Task<List<Pelicula>>GetPeliculas()
        {
            List<Pelicula> ls = new List<Pelicula>();
            try
            {
                ls = await peliculaBL.GetPeliculas();
            }
            catch(Exception e)
            {

            }

            return ls;
        }

    }
}
