using Flyweight.Cache;

namespace Flyweight
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var search = new MovieSearchAPI();

			var menuItems = new List<string>
			{
				 "Terminator",
				 "Spiderman",
				 "Dunkirk"
			};

			while (true)
			{
				Console.Clear();
				Console.WriteLine("Choose the movie: ");
				int index = 1;
				foreach (var item in menuItems)
				{
					Console.WriteLine($"{index++}) {item}");
				}

				Int32.TryParse(Console.ReadLine(), out int number);
				try
				{
					var movie = search.Search(menuItems[number - 1]);
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