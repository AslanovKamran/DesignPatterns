using Memento.Models;

namespace Memento
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Player player = new Player();
			Player player2 = new Player();
			PlayerSaves playerSaves = new PlayerSaves(player);

			Console.WriteLine("Player created");
			player.Info();
			playerSaves.SavePlayer();

			Console.WriteLine("Player moves Down");
			player.Move(Direction.Down);
			player.Info();

			Console.WriteLine("Player attacks");
			player.Attack(player2);
			player.Info();

			Console.WriteLine("Player moves Left");
			player.Move(Direction.Left );
			player.Info();


			Console.WriteLine("Player takes damage");
			player2.Attack(player);
			player.Info();

			Console.WriteLine("Player takes damage");
			player2.Attack(player);
			player.Info();

			Thread.Sleep(3_000);
			Console.WriteLine("Loading a player...");
			playerSaves.LoadPlayer();
			player.Info();

		}
	}
}