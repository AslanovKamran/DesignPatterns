using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Models
{
	internal class Circle
	{
		public int X { get; set; } = default;
		public int Y { get; set; } = default;
		public int Radius { get; set; } = default;

		public Circle(){}

		public Circle(int x, int y, int radius)
		{
			X = x;
			Y = y;
			Radius = radius;
		}

		public void Draw()
		{
			Console.WriteLine("Circle:");
			Console.WriteLine($"Coordinates: x: {X} y: {Y}");
			Console.WriteLine($"Radius: {Radius}");
		}
	}
}
