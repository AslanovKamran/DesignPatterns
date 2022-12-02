using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Models
{
	internal class Line
	{
		public int X1 { get; set; }= default;
		public int X2 { get; set; }= default;
		public int Y1 { get; set; }= default;
		public int Y2 { get; set; } = default;

		public Line() { }

		public Line(int x1, int x2, int y1, int y2)
		{
			X1 = x1;
			X2 = x2;
			Y1 = y1;
			Y2 = y2;
		}

		public void Draw()
		{
			Console.WriteLine("Line:");
			Console.WriteLine($"X-axis: x1: {X1} x2: {X2}");
			Console.WriteLine($"Y-axis: y1: {Y1} y2: {Y2}");
		} 
	}
}
