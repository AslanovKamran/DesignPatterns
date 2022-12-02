using Builder.Items;

namespace Builder.Models
{
	class Car
	{
		public string Name { get; set; } = string.Empty;
		public Corpus? Corpus{ get; set; }
		public Engine? Engine { get; set; }
		public Wheels? Wheels{ get; set; }
		public Transmission? Transmission{ get; set; }

		public void GetInfo()
		{
			Console.WriteLine($"\nCar : {Name}");
			Console.WriteLine($"Corpus: {Corpus?.ToString()}");
			Console.WriteLine($"Engine: {Engine?.ToString()}");
			Console.WriteLine($"Wheels: {Wheels?.ToString()}");
			Console.WriteLine($"Transmission: {Transmission?.ToString()}");
			Console.WriteLine($"\nTotal Price: {(Corpus?.Price?? 0) + (Engine?.Price?? 0) + (Wheels?.Price?? 0) + (Transmission?.Price?? 0)}$");
			Console.WriteLine("---------------------\n");
		}
	}
}
