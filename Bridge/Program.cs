using Bridge.Exporters;
using Bridge.Repository;

namespace Bridge
{
	internal class Program
	{
		static void Main(string[] args)
		{
			const string path = "testFile";

			List<string> users = new()
			{
				"Bob",
				"John",
				"Dilan",
				"Kyle"
			};

			DataRepository repository = new(users, new TxtExporter());
			repository.Save(path);

			repository.Exporter = new JsonExporter();
			repository.Save(path);

			repository.Exporter = new XMLExporter();
			repository.Save(path);
		}
	}
}