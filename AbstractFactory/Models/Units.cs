namespace AbstractFactory.Models
{
	public abstract class Unit
	{
		public int HealtPoints { get; set; } = default;
		public int Damage { get; set; } = default;

		abstract public void AttackEnemy(Unit target);
	}

	public abstract class Warrior : Unit
	{
		public override void AttackEnemy(Unit target)
		{ 
			target.HealtPoints -= this.Damage;
			Console.WriteLine("Melee attack by warrior");
		}
	}

	public abstract class Ranger : Unit
	{
		public override void AttackEnemy(Unit target)
		{
			target.HealtPoints -= this.Damage;
			Console.WriteLine("Ranged attack by ranger");
		}
	}

	public abstract class Wizard : Unit
	{
		public override void AttackEnemy(Unit target)
		{
			target.HealtPoints -= this.Damage;
			Console.WriteLine("Magic attack by wizard");
		}
	}

	public class Grunt : Warrior
	{
		public Grunt()
		{
			this.HealtPoints = 150;
			this.Damage = 20;
		}
		public override string ToString() => $"Orc Grunt (Warrior) | Stats: HP: {HealtPoints}; DMG: {Damage}";
	}

	public class Spearman : Warrior
	{
		public Spearman()
		{
			this.HealtPoints = 80;
			this.Damage = 20;
		}
		public override string ToString() => $"Man spearman (Warrior) | Stats: HP: {HealtPoints}; DMG: {Damage}";
	}

	public class Axethrower : Ranger
	{
		public Axethrower()
		{
			this.HealtPoints = 120;
			this.Damage = 15;
		}
		public override string ToString() => $"Orc Axethrower (Ranged) | Stats: HP: {HealtPoints}; DMG: {Damage}";
	}

	public class Archer : Ranger
	{
		public Archer()
		{
			this.HealtPoints = 100;
			this.Damage = 25;
		}
		public override string ToString() => $"Man Archer (Ranged) | Stats: HP: {HealtPoints}; DMG: {Damage}";
	}

	public class Warlock : Wizard
	{
		public Warlock()
		{
			this.HealtPoints = 50;
			this.Damage = 50;
		}
		public override string ToString() => $"Orc Warlock (Wizard) | Stats: HP: {HealtPoints}; DMG: {Damage}";
	}

	public class Enchanter : Wizard
	{
		public Enchanter()
		{
			this.HealtPoints = 60;
			this.Damage = 40;
		}
		public override string ToString() => $"Human Enchanter (Wizard) | Stats: HP: {HealtPoints}; DMG: {Damage}";
	}


}
