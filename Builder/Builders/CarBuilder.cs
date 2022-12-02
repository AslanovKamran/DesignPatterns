using Builder.Items;
using Builder.Models;


namespace Builder.Builders
{
	abstract class CarBuilder
	{
		public Car Car { get; protected set; }
		public CarBuilder() => this.Car = new Car();

		public abstract void AddCorpus();
		public abstract void AddEngine();
		public abstract void AddWheels();
		public abstract void AddTransmission();
	}

	class DaewooLanos : CarBuilder
	{
		public DaewooLanos()
		{
			this.Car.Name = "Daewoo Lanos";
		}
		public override void AddCorpus()
		{
			this.Car.Corpus = new Sedan();
		}

		public override void AddEngine()
		{
			this.Car.Engine = new LightEngine();
		}

		public override void AddTransmission()
		{
			this.Car.Transmission = new TransmissionOne();
		}

		public override void AddWheels()
		{
			this.Car.Wheels = new SmallWheels();
		}
	}

	class FordProbe : CarBuilder
	{

		public FordProbe()
		{
			this.Car.Name = "Ford Probe";
		}
		public override void AddCorpus()
		{
			this.Car.Corpus = new Coupe();
		}

		public override void AddEngine()
		{
			this.Car.Engine = new TurboEngine();
		}

		public override void AddTransmission()
		{
			this.Car.Transmission = new TransmissionTwo();
		}

		public override void AddWheels()
		{
			this.Car.Wheels = new MediumWheels();
		}
	}

	static class CarCreator
	{
		public static void CreateCar(CarBuilder builder)
		{
			builder.AddCorpus();
			builder.AddEngine();
			builder.AddWheels();
			builder.AddTransmission();
		}
	}
}
