using Backend04.Data;
using Backend04.Models;
using Microsoft.AspNetCore.Mvc;

namespace Backend04.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        MovieDbContext ctx = new MovieDbContext();

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return ctx.Movies;
        }

        [HttpGet("{id}")]
        public Movie Get(string id)
        {
            return ctx.Movies.First(m => m.Id == id);
        }

        [HttpPost]
        public void Post([FromBody] Movie movie)
        {
            movie.Id = Guid.NewGuid().ToString();
            ctx.Movies.Add(movie);
            ctx.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            ctx.Movies.Remove(ctx.Movies.First(m => m.Id == id));
            ctx.SaveChanges();
        }

        [HttpPut]
        public void Put([FromBody] Movie movie)
        {
            var existingMovie = ctx.Movies.First(m => m.Id == movie.Id);
            existingMovie.Title = movie.Title;
            existingMovie.Rating = movie.Rating;
            existingMovie.IsReleased = movie.IsReleased;
            ctx.SaveChanges();
        }


    }
}
