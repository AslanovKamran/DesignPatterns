using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Models
{
	internal class Rectangle
	{
		public int X { get; set; } = default;
		public int Y { get; set; } = default;
		public int Height { get; set; } = default;
		public int Width { get; set; } = default;

		public Rectangle(){}

		public Rectangle(int x, int y, int h, int w)
		{
			this.X = x;
			this.Y = y;
			this.Height = h;
			this.Width = w;
		}

		public void Draw()
		{
			Console.WriteLine("Reactangle:");
			Console.WriteLine($"Coordinates: x: {X} y: {Y}");
			Console.WriteLine($"Size: height: {Height} width: {Width}");
		}
	}
}
