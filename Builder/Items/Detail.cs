namespace Builder.Items
{
	enum TransmissionType
	{
		Manual,
		Auto
	}

	abstract class Detail
	{
		public double Price { get; set; } = default;
	}


	abstract class Corpus : Detail { }
	abstract class Engine : Detail 
	{
		public double Volume { get; set; } = default;
	}
	abstract class Wheels : Detail 
	{
		public int Radius { get; set; } = default;
	}
	abstract class Transmission : Detail 
	{
		public TransmissionType Type { get; set; }
		public int Gears { get; set; } = default;
	}

	class Sedan : Corpus
	{
		public Sedan() => this.Price = 1_000.0;
		public override string ToString() => "Sedan Corpus";
	}

	class Coupe : Corpus
	{
		public Coupe() => this.Price = 1_200.0;
		public override string ToString() => "Coupe Corpus";
	}

	class Universal : Corpus
	{
		public Universal() => this.Price = 1_500.0;
		public override string ToString() => "Universal Corpus";
	}


	class LightEngine : Engine
	{
		public LightEngine()
		{
			this.Price = 80.50;
			this.Volume = 98.0;
		}

		public override string ToString() => $"Light Engine | V:{this.Volume}";
	}

	class StandartEngine : Engine
	{
		public StandartEngine()
		{
			this.Price = 100.0;
			this.Volume = 120.0;
		}

		public override string ToString() => $"Standart Engine | V:{this.Volume}";
	}

	class TurboEngine : Engine
	{
		public TurboEngine()
		{
			this.Price = 150.0;
			this.Volume = 160.0;
		}

		public override string ToString() => $"Turbo Engine | V:{this.Volume}";
	}


	class SmallWheels : Wheels
	{
		public SmallWheels()
		{
			this.Price = 40.0;
			this.Radius = 13;
		}

		public override string ToString() => $"Small Wheels | {this.Radius}";
	}

	class MediumWheels : Wheels
	{
		public MediumWheels()
		{
			this.Price = 60.0;
			this.Radius = 14;
		}

		public override string ToString() => $"Medium Wheels | {this.Radius}";
	}

	class LargeWheels : Wheels
	{
		public LargeWheels()
		{
			this.Price = 80.0;
			this.Radius = 16;
		}

		public override string ToString() => $"Large Wheels | {this.Radius}";
	}

	class TransmissionOne : Transmission
	{
		public TransmissionOne()
		{
			this.Price = 100.0;
			this.Type = TransmissionType.Manual;
			this.Gears = 5;
		}
		public override string ToString() => $"{Gears} {Type}";
	}
	class TransmissionTwo	: Transmission
	{
		public TransmissionTwo()
		{
			this.Price = 120.0;
			this.Type = TransmissionType.Auto;
			this.Gears = 5;
		}
		public override string ToString() => $"{Gears} {Type}";
	}
	class TransmissionThree	: Transmission
	{
		public TransmissionThree()
		{
			this.Price = 150.0;
			this.Type = TransmissionType.Manual;
			this.Gears = 6;
		}
		public override string ToString() => $"{Gears} {Type}";
	}
}
