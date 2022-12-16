

using Visitor.Exporter;

namespace Visitor.Models
{

	enum Cuisine { Italian = 1, Georgian, Russian }
	internal class Restaurant : MapObject
	{
		public Cuisine Cuisine { get; set; } 

		public override void Export(MapObjectExporter exporter)
		{
			exporter.ExportRestaurant(this);
		}

		public override string ToString() => $"Restaurant\n{base.ToString()}\nCuisine: {Cuisine}";


	}
}
