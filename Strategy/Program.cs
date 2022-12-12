using Strategy.Models;

namespace Strategy
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Map map = new Map();

			var start = new Location(1, 2);
			var finish = new Location(2, 3);

			map.BuildARoute(start,finish);
			Console.WriteLine("\n");

			map.ChangeRouteType(new BusRouteBuilder());
			map.BuildARoute(start, finish);
			Console.WriteLine("\n");

			map.ChangeRouteType(new CarRouteBuilder());
			map.BuildARoute(start,finish);
		}
	}
}