using Visitor.Exporter;
using Visitor.Models;

namespace Visitor
{
	internal class Program
	{
		static void Main(string[] args)
		{
            var list = new List<MapObject>
            {
                new Hotel { Name = "Hilton", Latitude = 34.4, Longitude = 27.8, Stars = 5 },
                new Restaurant { Name = "Italia", Latitude = 36.7, Longitude = 30.1, Cuisine = Cuisine.Italian },
                new BusStation { Name = "28 May", Latitude = 15.1, Longitude = 27.5, BusNumbers = { 17, 77, 14, 39 } }
            };

            foreach (var item in list)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }

			var exporter = new MapObjectExporter();
			foreach (var item in list)
			{
				item.Export(exporter);
			}
			Console.WriteLine("Done");
		}
	}
}