using FactoryMethod.Creators;

namespace FactoryMethod
{



	internal class Program
	{
		
		static void Main(string[] args)
		{

			IFigureCreator[] creators = new IFigureCreator[5];
			creators[0]= new LineCreator();
			creators[1]= new SquareCreator();
			creators[2]= new ZCreator();
			creators[3] = new LCreator();
			creators[4] = new TCreator();

			for (int i = 0; i < 10; i++)
			{
				var rand = new Random().Next(0, 5);
				var figure = creators[rand].CreateFigure();
				Console.WriteLine(figure.GetType().Name);
				figure.GetInfo();
				Console.WriteLine("\n");
			}
		}

	}
}