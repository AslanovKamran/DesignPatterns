

namespace Memento.Models
{
	internal class Player
	{
		public int HealthPoints { get; set; }
		public int Stamina { get; set; }
		public Location Location { get; set; }

		public Player()
		{
			HealthPoints = 100;
			Stamina = 100;
			Location = new Location { X = 0, Y = 0 };
		}

		public Player(int healthPoints, int stamina, Location location)
		{
			HealthPoints = healthPoints;
			Stamina = stamina;
			Location = location;
		}

		public void Move(Direction direction)
		{
			switch (direction)
			{
				case Direction.Up:
					Location.Y++;
					break;
				case Direction.Down:
					Location.Y--;
					break;
				case Direction.Left:
					Location.X--;
					break;
				case Direction.Right:
					Location.X++;
					break;
				default:
					break;
			}
		}

		public void Attack(Player player)
		{
			this.Stamina -= 5;
			player.HealthPoints -= 5;
		}

		public PlayerMemento Save() => new PlayerMemento(HealthPoints, Stamina, Location);
		public void Load(PlayerMemento memento)
		{
			this.HealthPoints = memento.HealthPoints;
			this.Stamina = memento.Stamina;
			this.Location = memento.Location;
		}

		public void Info()
		{
			Console.WriteLine($"HP: {HealthPoints}");
			Console.WriteLine($"Stamina: {Stamina}");
			Console.WriteLine($"Location: {Location.X} - {Location.Y}");
			Console.WriteLine();
		}
	}

	internal class PlayerMemento
	{
		public int HealthPoints { get; set; }
		public int Stamina { get; set; }
		public Location Location { get; set; }

		public PlayerMemento(int healthPoints, int stamina, Location location)
		{
			HealthPoints = healthPoints;
			Stamina = stamina;
			Location = location;
		}
	}

	internal class PlayerSaves
	{
		private Player player;
		private Stack<PlayerMemento> saves;

		public PlayerSaves(Player player)
		{
			this.player = player;
			saves = new();
		}

		public void SavePlayer() => saves.Push(player.Save());
		public void LoadPlayer()
		{
			try
			{
				player.Load(saves.Pop());
			}
			catch (Exception)
			{

				Console.WriteLine("Nothing to retrive");
			}
		}

	}
}
