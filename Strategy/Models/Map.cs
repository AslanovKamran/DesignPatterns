
namespace Strategy.Models
{

	enum Transport
	{
		Feet = 1,
		Car, 
		Bus,
	}

	internal class Location
	{
		public double Latitude { get; set; } = default;
		public double Longitude { get; set; } = default;

		public Location() { }
		public Location(double lat, double lon)
		{
			this.Latitude = lat;
			this.Longitude = lon;
		}

		public override string ToString()
		{
			return $"Lat: {Latitude}; Lon: {Longitude}";
		}

	}

	internal class Map
	{
		private IRouteBuilder _routeBuilder;

		public Map() => _routeBuilder = new FeetRouteBuilder();
		public Map(IRouteBuilder routeBuilder) => _routeBuilder = routeBuilder;

		public void ChangeRouteType(IRouteBuilder routeBuilder) => _routeBuilder = routeBuilder;
		public void BuildARoute(Location start, Location finish) => _routeBuilder.BuildRoute(start, finish);
	}
}
