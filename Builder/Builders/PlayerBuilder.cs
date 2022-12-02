using Builder.Items;
using Builder.Models;


namespace Builder.Builders
{
	abstract class PlayerBuilder
	{
		public Player Player{ get; protected set; }
		public PlayerBuilder() => Player = new ();

		public abstract void EquipHelmet();
		public abstract void EquipApparel();
		public abstract void EquipLegs();
		public abstract void EquipRightHand();
		public abstract void EquipLeftHand();
	}

	class WarriorBilder : PlayerBuilder
	{
		public WarriorBilder()
		{
			this.Player.Name = "Knight";
		}
		public override void EquipApparel()
		{
			this.Player.Apparel = new PlateArmor();
		}

		public override void EquipHelmet()
		{
			this.Player.Helmet = new PlateArmor();
		}

		public override void EquipRightHand()
		{
			this.Player.RightHand = new Sword();
		}

		public override void EquipLeftHand()
		{
			this.Player.LeftHand = new Shield();
		}

		public override void EquipLegs()
		{
			this.Player.Legs = new PlateArmor();
		}
	}

	class ArcherBuilder : PlayerBuilder
	{
		public ArcherBuilder()
		{
			this.Player.Name = "Ranger";
		}
		public override void EquipApparel()
		{
			this.Player.Apparel = new LeatherArmor();
		}

		public override void EquipHelmet()
		{
			this.Player.Helmet = new LeatherArmor();
		}

		public override void EquipRightHand()
		{
			this.Player.RightHand = new Bow();
		}

		public override void EquipLeftHand()
		{
			this.Player.LeftHand = null;
		}

		public override void EquipLegs()
		{
			this.Player.Legs = new LeatherArmor();
		}

	}

	class BerserqueBuilder : PlayerBuilder
	{
		public BerserqueBuilder()
		{
			this.Player.Name = "Berserque";
		}
		public override void EquipApparel()
		{
			this.Player.Apparel = new LeatherArmor();
		}

		public override void EquipHelmet()
		{
			this.Player.Helmet = new LeatherArmor();
		}

		public override void EquipRightHand()
		{
			this.Player.RightHand = new Sword();
		}

		public override void EquipLeftHand()
		{
			this.Player.LeftHand = new Sword();
		}

		public override void EquipLegs()
		{
			this.Player.Legs = new LeatherArmor();
		}

	}

	class BumBuilder : PlayerBuilder
	{
		public BumBuilder()
		{
			this.Player.Name = "Bum";
		}
		public override void EquipApparel()
		{
			this.Player.Apparel = new Clothes();
		}

		public override void EquipHelmet()
		{
			this.Player.Helmet = new Clothes();
		}

		public override void EquipRightHand()
		{
			this.Player.LeftHand = null;
		}

		public override void EquipLeftHand()
		{
			this.Player.LeftHand = null;
		}

		public override void EquipLegs()
		{
			this.Player.Legs = new Clothes();
		}

	}

	static class HeroCreator 
	{
		public static void CreateHero(PlayerBuilder playerBuilder)
		{
			playerBuilder.EquipHelmet();
			playerBuilder.EquipApparel();
			playerBuilder.EquipLegs();

			playerBuilder.EquipLeftHand();
			playerBuilder.EquipRightHand();
		}
	}

}
