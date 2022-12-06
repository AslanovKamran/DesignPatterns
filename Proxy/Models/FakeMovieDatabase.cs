

namespace Proxy.Models
{
	public static class FakeMovieDatabase
	{
		static public List<Movie> Movies { get; }
		static FakeMovieDatabase()
		{
			Movies = new List<Movie>()
			{
				new Movie("Terminator", 1984, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse ullamcorper tincidunt metus, et convallis massa."),
				new Movie("Terminator 2", 1991, "Nam ut metus vel ligula tristique rutrum. Vivamus id arcu molestie, varius lectus in, tristique justo."),
				new Movie("Terminator 3", 2003, "Maecenas in porta mi. Phasellus malesuada pretium est, vitae vestibulum purus blandit sit amet. Proin vel dapibus ante, at euismod massa."),
			};
		}
	}
}
