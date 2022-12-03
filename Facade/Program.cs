using Facade.Models;

namespace Facade
{
	internal class Program
	{
		static void Main(string[] args)
		{
		
			var travelAgency = new TravelAgency();

			var tripOne_byBus = travelAgency.BuildTrip("Baku", "London", 17, 4610.5, HotelType.FiveStars, TripType.Bus, GuideType.Person);
			var tripTwo_byPlane = travelAgency.BuildTrip("Baku", "London", 17, 4610.5, HotelType.FiveStars, TripType.Plane, GuideType.Person);
			Console.WriteLine($"Baku - Rome (by bus):\t{tripOne_byBus}$");
			Console.WriteLine($"Baku - Rome (by plane):\t{tripTwo_byPlane}$");
		}
	}
}