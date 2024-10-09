using Backend04.Models;
using Microsoft.AspNetCore.Mvc;

namespace Backend04.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        static List<Movie> Movies = new List<Movie>()
        {
            new Movie() { Id = "1", Title = "The Shawshank Redemption", Rating = 9.3, IsReleased = true },
            new Movie() { Id = "2", Title = "The Godfather", Rating = 9.2, IsReleased = true },
            new Movie() { Id = "3", Title = "The Dark Knight", Rating = 9.0, IsReleased = true },
        };

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return Movies;
        }

        [HttpPost]
        public void Post([FromBody] Movie movie)
        {
            Movies.Add(movie);
        }



    }
}
