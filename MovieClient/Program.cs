using MyNamespace;

namespace MovieClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.Sleep(5000);
            var client = new Client("https://localhost:7142/", new HttpClient());
            
            client.MoviePOSTAsync(new Movie 
            { Title = "Spider-man I.", Rating = 3.4, IsReleased = true })
                .GetAwaiter().GetResult();

            var movies = client.MovieAllAsync().GetAwaiter().GetResult();

            
        }
    }
}
