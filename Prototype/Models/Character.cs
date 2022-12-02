using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
	internal class Character :ICloneable
	{
		public string Name { get; set; } = string.Empty;
		public int HP { get; set; }
		public int MP { get; set; }
		public int Strength { get; set; }
		public int Agility { get; set; }
		public int Intellect { get; set; }

		public void Info()
		{
			Console.WriteLine($"Name: {Name}");
			Console.WriteLine("\nStats: ");
			Console.WriteLine($"Health points: {HP}");
			Console.WriteLine($"Mana points: {MP}");
			Console.WriteLine($"Strength: {Strength}");
			Console.WriteLine($"Agility: {Agility}");
			Console.WriteLine($"Intellect: {Intellect}");
		}

		public object Clone() => MemberwiseClone();
	}
}
