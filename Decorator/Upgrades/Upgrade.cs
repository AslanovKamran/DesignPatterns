using Decorator.Models;

namespace Decorator.Upgrades
{
	public abstract class Upgrade:Weapon
	{
		public Weapon Weapon { get; set; }
	
		private int accuracy;
		public override int Accuracy
		{
			get => (Weapon.Accuracy) + accuracy;
			set =>accuracy = value;
		}

		private int damage;
		public override int Damage
		{
			get => Weapon.Damage + damage;
			set => damage = value;
		}

		private int ammo;
		public override int Ammo
		{
			get => Weapon.Ammo + ammo;
			set => ammo = value;
		}

		public Weapon SetUprgrade(Weapon weapon)
		{
			this.Weapon = weapon;
			return this;
		}

		public Weapon RemoveUpgrade(Weapon weapon)
		{
			var temp = weapon;
			weapon = null;
			return temp;
		}
	}

	public class Supressor : Upgrade
	{
		public Supressor()
		{
			this.Accuracy = 5;
			this.Damage = -1;
		}
	}

	public class Scope : Upgrade
	{
		public Scope()
		{
			this.Accuracy = 15;
		}
	}

	public class Belt : Upgrade
	{
		public Belt()
		{
			this.Ammo = 15;
		}
	}
}
