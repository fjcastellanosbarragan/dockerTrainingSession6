using System.Threading.Tasks;
using dockertraining_compose_fernando_castellanos.Models;
using Microsoft.AspNetCore.Mvc;

namespace dockertraining_compose_fernando_castellanos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly VideoStoreContext  db;

        public MoviesController(VideoStoreContext  context)
        {
            db = context;
        }

        // GET: api/Movies
        [HttpGet]
        public IActionResult Get()
        {
            var movies = db.Movies;

            return Ok(movies);
        }

        // GET: api/Movies/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> Get(int id)
        {
            var movie = await db.Movies.FindAsync(id);
            if (movie == default(Movie))
            {
                return NotFound();
            }

            return Ok(movie);
        }

        // POST: api/Movies
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await db.AddAsync(movie);
            await db.SaveChangesAsync();
            return Ok(movie.Id);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Movie>> Delete(int id)
        {
            var movie = await db.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }

            db.Movies.Remove(movie);
            await db.SaveChangesAsync();

            return movie;
        }
    }
}