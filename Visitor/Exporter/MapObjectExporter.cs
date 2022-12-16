

using Visitor.Models;

namespace Visitor.Exporter
{
	internal class MapObjectExporter
	{
		public void ExportHotel(Hotel obj)
		{
			if (!Directory.Exists("hotels"))
			{
				Directory.CreateDirectory("hotels");
			}
			var path = $"hotels\\{obj.Name}.txt";
			using (var sw = new StreamWriter(path))
			{
				sw.WriteLine(obj.ToString());
			}
		}

		public void ExportRestaurant(Restaurant obj)
		{
			if (!Directory.Exists("restaurants"))
			{
				Directory.CreateDirectory("restaurants");
			}
			var path = $"restaurants\\{obj.Name}.txt";
			using (var sw = new StreamWriter(path))
			{
				sw.WriteLine(obj.ToString());
			}
		}

		public void ExportBusStations(BusStation obj)
		{
			if (!Directory.Exists("busstations"))
			{
				Directory.CreateDirectory("busstations");
			}
			var path = $"busstations\\{obj.Name}.txt";
			using (var sw = new StreamWriter(path))
			{
				sw.WriteLine(obj.ToString());
			}
		}


	}
}
