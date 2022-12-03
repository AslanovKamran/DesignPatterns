
namespace Facade.Models
{
	enum HotelType
	{
		ThreeStars,
		FourStars,
		FiveStars
	}

	internal class HotelBooking
	{
		public string Name { get; set; } = string.Empty;
		public int BookHotel(HotelType type, int days)
		{
			switch (type)
			{
				case HotelType.ThreeStars: { return 100 * days; }
				case HotelType.FourStars: { return 200 * days; }
				case HotelType.FiveStars: { return 300 * days; }
				default: return 0;
			}
		}
	}
}
