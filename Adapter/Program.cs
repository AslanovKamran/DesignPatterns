using Adapter.Adapters;
using Adapter.Models;

namespace Adapter
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<IDrawable> shapes = new List<IDrawable>
			{
				new ReactangleAdapter(new Rectangle()),
				new CircleAdapter(new Circle()),
				new LineAdpater(new Line()),
			};

			foreach (var item in shapes)
			{
				item.Draw(5, 15, 5, 15);
				Console.WriteLine("==========================");
			}
		}
	}
}