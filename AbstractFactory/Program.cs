using AbstractFactory.Factory;
using AbstractFactory.Models;

namespace AbstractFactory
{
	internal class Program
	{
		static void Main(string[] args)
		{
			const int troopCount = 5;

			List<Unit> troopList = new();
			UnitCreator creator = new UnitCreator(new OrcFactory());

			//Adding 15 Orcs
			AddUnits(troopCount, troopList, creator);

			creator.UnitFactory = new HumanFactory();
			
			//Adding 15 Humans
			AddUnits(troopCount, troopList, creator);

			foreach (var item in troopList)
			{
				Console.WriteLine(item);
			}
			
		}

		static void AddUnits(int troopCount, List<Unit> container, UnitCreator creator)
		{
			for (int i = 0; i < troopCount; i++)
			{
				creator.AddWarrior(container);
				creator.AddRanger(container);
				creator.AddWizard(container);
			}
		}
	}
}