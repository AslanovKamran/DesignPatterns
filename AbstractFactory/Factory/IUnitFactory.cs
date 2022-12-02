using AbstractFactory.Models;

namespace AbstractFactory.Factory
{
	interface IUnitFactory
	{
		public Warrior CreateWarrior();
		public Ranger CreateRanger();
		public Wizard CreateWizard();
	}

	class OrcFactory : IUnitFactory
	{
		public Warrior CreateWarrior() => new Grunt();
		public Ranger CreateRanger() => new Axethrower();
		public Wizard CreateWizard() => new Warlock();
	}

	class HumanFactory : IUnitFactory
	{
		public Warrior CreateWarrior() => new Spearman();
		public Ranger CreateRanger() => new Archer();
		public Wizard CreateWizard() => new Enchanter();
	}
}
