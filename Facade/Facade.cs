using Facade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
	internal class TravelAgency
	{
		public HotelBooking HotelBookig { get; set; }
		public TripBooking TripBookig { get; set; }
		public GuideBooking GuideBooking { get; set; }

		public double TotalTravelPrice { get; set; } = default;

		public TravelAgency()
		{
			HotelBookig = new();
			TripBookig = new();
			GuideBooking = new();
		}

		public double BuildTrip(string fromCity, string toCity, int days, double distance,
								HotelType hotelType, TripType tripType, GuideType guideType)
		{
			TotalTravelPrice += HotelBookig.BookHotel(hotelType, days);
			TotalTravelPrice += TripBookig.BookTrip(tripType, distance, fromCity, toCity);
			TotalTravelPrice += GuideBooking.BookGuide(guideType, days);
			return TotalTravelPrice;
		}
	}
}
