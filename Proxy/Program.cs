using Proxy.Proxy;

namespace Proxy
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IMovieSearch movieSearch = new MovieSearchProxy();
            while (true)
            {
                Console.Clear();
                Console.Write("Enter the title: ");
                var title = Console.ReadLine();

                try
                {
                    var movie = movieSearch.Search(title);
                    Console.WriteLine(movie);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine("\nPress ESC to exit or any key to continue...");
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                    break;
            }
        }
	}
}