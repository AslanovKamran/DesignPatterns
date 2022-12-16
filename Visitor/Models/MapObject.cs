
using Visitor.Exporter;

namespace Visitor.Models
{
	abstract class MapObject : IExport
	{
		public double Latitude { get; set; } = default;
		public double Longitude { get; set; } = default;
		public string Name { get; set; } = string.Empty;

		public abstract void Export(MapObjectExporter exporter);

		public override string ToString() => $"Name: {Name}\nCoordinates: {Latitude}, {Longitude}";
	}
}
