

namespace Facade.Models
{
	enum TripType
	{
		Bus,
		Car,
		Plane
	}

	internal class TripBooking
	{
		public double BookTrip(TripType type, double distance, string from, string to)
		{
			switch (type)
			{
				case TripType.Bus:
					return distance * 0.5;
				case TripType.Car:
					return distance * 1.5;
				case TripType.Plane:
					return distance * 2.5;
				default:
					return 0.0;
			}
		} 
	}
}
