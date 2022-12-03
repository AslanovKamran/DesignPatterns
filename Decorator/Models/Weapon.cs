namespace Decorator.Models
{
	public abstract class Weapon
	{
		public virtual int Accuracy { get; set; }
		public virtual int Damage { get; set; }
		public virtual int Ammo { get; set; }

		public void GetInfo()
		{
			Console.WriteLine($"Weapon class: {this.GetType().Name}");
			Console.WriteLine($"Accuracy: {this.Accuracy}");
			Console.WriteLine($"Damage: {this.Damage}");
			Console.WriteLine($"Ammunition: {this.Ammo} bullets\n");
		}
	}

	public class AssaultRifle: Weapon
	{
		public AssaultRifle()
		{
			this.Accuracy = 20;
			this.Damage = 10;
			this.Ammo = 25;
		}
	}

	public class SniperRifle : Weapon
	{
		public SniperRifle()
		{
			this.Accuracy = 50;
			this.Damage = 30;
			this.Ammo = 5;
		}
	}

	public class Shotgun : Weapon
	{
		public Shotgun()
		{
			this.Accuracy = 10;
			this.Damage = 45;
			this.Ammo = 8;
		}
	}
}
