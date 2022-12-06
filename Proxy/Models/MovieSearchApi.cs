using Newtonsoft.Json;
using Proxy.Proxy;
using System.Net;

namespace Proxy.Models
{
    //Main 
    public class MovieSearchAPI : IMovieSearch
    {
        readonly string apiUrl = @"http://www.omdbapi.com/";
        readonly string apiKey = "2c9d65d5";


        public Movie Search(string title)
        {
			Console.WriteLine("Searching via Main search api class");
            Thread.Sleep(1_000);
            var webClient = new WebClient();
            try
            {
                var result = webClient.DownloadString($"{apiUrl}?apikey={apiKey}&t={title}");
                dynamic data = JsonConvert.DeserializeObject(result);
                var movie = new Movie
                {
                    Title = data.Title,
                    Year = data.Year,
                    Plot = data.Plot
                };
                return movie;
            }
            catch (WebException)
            {
                throw;
            }
            catch (Exception)
            {
                throw new Exception("Not found!");
            }
        }
    }
}
