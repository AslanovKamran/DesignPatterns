using Proxy.Models;

namespace Proxy.Proxy
{
	public interface IMovieSearch
	{
		Movie Search(string title);
	}

	//Proxy
	public class MovieSearchProxy : IMovieSearch
	{
		MovieSearchAPI? searchApi = null;
		public Movie Search(string title)
		{
			Console.WriteLine("Searching via a proxy class");
			var movie = FakeMovieDatabase.Movies.FirstOrDefault(x => x.Title == title);
			if(movie == null)
			{
				Console.WriteLine("Couldn't find via a proxy class");
				if(searchApi == null)
				{
					searchApi = new MovieSearchAPI();
					movie = searchApi.Search(title);
				}
			}
			return movie;
		}

 	}
}
