using Builder.Items;

namespace Builder.Models
{
	class Player
	{
		public string Name { get; set; } = string.Empty;

		public Armor? Helmet { get; set; } 
		public Armor? Apparel { get; set; }
		public Armor? Legs { get; set; } 

		public Weapon? RightHand { get; set; } 
		public Weapon? LeftHand { get; set; }	

		public void GetInfo()
		{
			Console.WriteLine($"\nHero name: {Name}");
			Console.WriteLine($"Helmet: {Helmet?.ToString() ?? "None"}");
			Console.WriteLine($"Apparel: {Apparel?.ToString() ?? "None"}");
			Console.WriteLine($"Right hand: {RightHand?.ToString() ?? "None"}");
			Console.WriteLine($"Left hand: {LeftHand?.ToString() ?? "None"}");
			Console.WriteLine($"Leg armory: {Legs?.ToString() ?? "None"}");
			Console.WriteLine($"\nTotal defence: {(Helmet?.Defence ?? 0) + (Apparel?.Defence ?? 0) + (Legs?.Defence ?? 0) + (RightHand?.Defence ?? 0) + (LeftHand?.Defence ?? 0)}");
			Console.WriteLine($"Total damage: {(LeftHand?.Damage ?? 0) + (RightHand?.Damage ?? 0)}");
			Console.WriteLine("\n---------------------");
		}

		private string GetTotalDamage()
		{
			return (LeftHand?.Damage + RightHand?.Damage).ToString() ?? "0";
		}
		private string GetTotalDefence()
		{
			return (Helmet?.Defence + Apparel?.Defence + Legs?.Defence + RightHand?.Defence + LeftHand?.Defence).ToString() ?? "0";
		}
	}
}
