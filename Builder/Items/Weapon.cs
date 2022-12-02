namespace Builder.Items
{
	abstract class Weapon
	{
		public int Damage { get; set; } = default;
		public int Defence { get; set; } = default;
	}

	abstract class Armor
	{
		public int Defence { get; set; } = default;
	}


	class Sword : Weapon
	{
		public Sword()
		{
			this.Damage = 10;
			this.Defence = 2;
		}
		public override string ToString() => "Sword";
	}

	class Shield : Weapon
	{
		public Shield()
		{
			this.Damage = 1;
			this.Defence = 10;
		}

		public override string ToString() => "Shield";
	}

	class Bow : Weapon
	{
		public Bow()
		{
			this.Damage = 8;
			this.Defence = 0;
		}
		public override string ToString() => "Bow";
	}

	class Clothes : Armor
	{
		public Clothes()
		{
			this.Defence = 2;
		}
		public override string ToString() => "Poor clothes";

	}

	class LeatherArmor : Armor
	{
		public LeatherArmor()
		{
			this.Defence = 5;
		}
		public override string ToString() => "Light leather armor";
	}

	class PlateArmor : Armor
	{
		public PlateArmor()
		{
			this.Defence = 10;
		}
		public override string ToString() => "Stout plate armor";

	}

}


