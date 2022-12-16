

using Visitor.Exporter;

namespace Visitor.Models
{
	internal class BusStation : MapObject
	{
		public List<int> BusNumbers { get; set; } = new();

		public override void Export(MapObjectExporter exporter)
		{
			exporter.ExportBusStations(this);
		}

		public override string ToString()
		{
			var result = "Bus station\n";
			result += base.ToString() + "\nBusNumbers:\n";
			foreach (var item in BusNumbers)
			{
				result += $"{item} ";
			}
			return result;
			
		}
	}
}
