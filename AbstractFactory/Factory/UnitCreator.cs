using AbstractFactory.Models;

namespace AbstractFactory.Factory
{
	class UnitCreator
	{
		public IUnitFactory UnitFactory { get; set; }
		public UnitCreator(IUnitFactory unitFactory) => UnitFactory = unitFactory;

		public void AddRanger(List<Unit> units) => units.Add(UnitFactory.CreateRanger());
		public void AddWarrior(List<Unit> units) => units.Add(UnitFactory.CreateWarrior());
		public void AddWizard(List<Unit> units) => units.Add(UnitFactory.CreateWizard());
	}
}
