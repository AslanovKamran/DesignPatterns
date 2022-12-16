

using Visitor.Exporter;

namespace Visitor.Models
{
	internal class Hotel : MapObject
	{
		public int Stars { get; set; } = 1;
		public override void Export(MapObjectExporter exporter)
		{
			exporter.ExportHotel(this);
		}

		public override string ToString() => $"Hotel\n{base.ToString()}\nStars: {Stars}";
	}
}
