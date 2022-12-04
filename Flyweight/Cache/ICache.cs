using Flyweight.Models;
using Newtonsoft.Json;
using System.Net;

namespace Flyweight.Cache
{
	internal interface ICache<TKey, TValue>
	{
		TValue? GetValue(TKey key);
		void AddValue(TKey key, TValue value);
	}

	internal class MovieCache : ICache<string, Movie>
	{
		public Dictionary<string, Movie> Movies { get; set; } = new();
		public void AddValue(string key, Movie value)
		{
			Movies.Add(key, value);
		}

		public Movie GetValue(string key)
		{
			return Movies.ContainsKey(key) ? Movies[key] : null;
		}
	}

    class MovieSearchAPI
    {
        readonly string apiUrl = @"http://www.omdbapi.com/";
        readonly string apiKey = "2c9d65d5";

        ICache<string, Movie> cache = new MovieCache();

        public Movie Search(string title)
        {
            var movie = cache.GetValue(title);
            if (movie == null)
            {
                Console.WriteLine("Reading data from API...");

                var webClient = new WebClient();
                try
                {
                    var result = webClient.DownloadString($"{apiUrl}?apikey={apiKey}&t={title}");
                    dynamic data = JsonConvert.DeserializeObject(result);
                    movie = new Movie
                    {
                        Title = data.Title,
                        Year = data.Year,
                        Plot = data.Plot
                    };
                    cache.AddValue(movie.Title, movie);
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
            else
            {
                Console.WriteLine("Reading data from cache...");
            }
            return movie;
        }
    }
}
