using Decorator.Models;
using Decorator.Upgrades;

namespace Decorator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Upgrade scope = new Scope();
			Upgrade silencer = new Supressor();
			Upgrade belt = new Belt();

			Weapon m16 = new AssaultRifle();
			m16.GetInfo();

			m16 = scope.SetUprgrade(m16);
			m16.GetInfo();

			m16 = belt.SetUprgrade(m16);
			m16.GetInfo();

		}
	}
}