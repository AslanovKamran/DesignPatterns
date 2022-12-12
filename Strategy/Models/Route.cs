using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Models
{
	internal interface IRouteBuilder
	{
		void BuildRoute(Location startPoint, Location endPoint);
	}

	internal class CarRouteBuilder : IRouteBuilder
	{
		private readonly Transport _transport;
		public CarRouteBuilder() => _transport = Transport.Car;

		public void BuildRoute(Location startPoint, Location endPoint)
		{
			Console.WriteLine("Using " +this._transport);
			Console.WriteLine($"Startin' from:\n{startPoint}");
			Console.WriteLine($"Goint to :\n{endPoint}");
			Console.WriteLine("Approximate time: 10 minutes");
		}
	}

	internal class BusRouteBuilder : IRouteBuilder
	{
		private readonly Transport _transport;
		public BusRouteBuilder() => _transport = Transport.Bus;

		public void BuildRoute(Location startPoint, Location endPoint)
		{
			
			Console.WriteLine("Using " + this._transport);
			Console.WriteLine($"Startin' from:\n{startPoint}");
			Console.WriteLine($"Goint to :\n{endPoint}");
			Console.WriteLine("Approximate time: 20 minutes");
		}
	}

	internal class FeetRouteBuilder : IRouteBuilder
	{
		private readonly Transport _transport;
		public FeetRouteBuilder() => _transport = Transport.Feet;

		public void BuildRoute(Location startPoint, Location endPoint)
		{
			Console.WriteLine("Using " + this._transport);
			Console.WriteLine($"Startin' from:\n{startPoint}");
			Console.WriteLine($"Goint to :\n{endPoint}");
			Console.WriteLine("Approximate time: 30 minutes");
		}
	}
}
