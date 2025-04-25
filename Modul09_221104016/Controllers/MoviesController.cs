using Microsoft.AspNetCore.Mvc;
using Modul09_221104016.Models;
using System.Collections.Generic;
using System.Linq;
namespace Modul09_221104016.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private static List<Movie> _movies = new List<Movie>
        {
            new Movie
            {

                Title = "The Shawshank Redemption",
                Director = "Frank Darabont",
                Stars = new List<string> { "Tim Robbins", "Morgan Freeman" },
                Description = "Two imprisoned men bond over a number of years."
            },
            new Movie
            {
                Title = "The Godfather",
                Director = "Francis Ford Coppola",
                Stars = new List<string> { "Marlon Brando", "Al Pacino" },
                Description = "The aging patriarch of an organized crime dynasty."
            },
            new Movie
            {
                Title = "The Dark Knight",
                Director = "Christopher Nolan",
                Stars = new List<string> { "Christian Bale", "Heath Ledger" },
                Description = "Batman faces the Joker in Gotham City."
            }
        };

        // GET: api/Movies
        [HttpGet]
        public ActionResult<IEnumerable<Movie>> GetMovies()
        {
            return Ok(_movies);
        }

        // GET: api/Movies/5
        [HttpGet("{id}")]
        public ActionResult<Movie> GetMovie(int id)
        {
            if (id < 0 || id >= _movies.Count)
                return NotFound();
            return Ok(_movies[id]);
        }

        // POST: api/Movies
        [HttpPost]
        public ActionResult<Movie> PostMovie(Movie movie)
        {
            _movies.Add(movie);
            return CreatedAtAction(nameof(GetMovie), new { id = _movies.Count - 1 }, movie);
        }

        // DELETE: api/Movies/5
        [HttpDelete("{id}")]
        public IActionResult DeleteMovie(int id)
        {
            if (id < 0 || id >= _movies.Count)
                return NotFound();
            _movies.RemoveAt(id);
            return NoContent();
        }
    }
}
