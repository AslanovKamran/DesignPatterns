using Prototype.Models;

namespace Prototype
{
	internal class Program
	{
		static void Main(string[] args)
		{
			CharacterManager characterManager = new();
			Character? character;

			while (true)
			{
				Console.Write("Choose your class:\nWarrior - 1 | Thief - 2 | Mage - 3 => ");
				Enum.TryParse(Console.ReadKey().KeyChar.ToString(), out Class classChoice);
				try
				{
					character = characterManager[classChoice].Clone() as Character;
					Console.Clear();
					break;
				}
				catch (KeyNotFoundException)
				{
					Console.Clear();
					Console.WriteLine("Pick valid option");
					Console.ReadKey();
				}
			}

			while (true)
			{
				Console.Write("Write your name: ");
				character.Name = Console.ReadLine();
				if (String.IsNullOrWhiteSpace(character.Name))
				{
					Console.Clear();
					Console.WriteLine("Name can't be empty!");
					Console.ReadKey();
				}
				else break;
			}


			int additionalPoints = 3;
			while (additionalPoints != 0)
			{
				Console.Clear();
				character.Info();
				Console.WriteLine($"\nYou have {additionalPoints} additional points!");
				Console.Write("Choose stat to improve (1 - STR, 2 - AGL, 3 - INT): ");
				Int32.TryParse(Console.ReadKey().KeyChar.ToString(), out int skillChoise);

				switch (skillChoise)
				{
					case 1:
						character.Strength+=5;
						additionalPoints--;
						break;
					case 2:
						character.Agility+=5;
						additionalPoints--;
						break;
					case 3:
						character.Intellect+=5;
						additionalPoints--;
						break;

					default: Console.WriteLine("Wrong Choice");  break;
				}
			}

			Console.Clear();
			Console.WriteLine("Your character has been created!\n");
			character.Info();
		}
	}
}