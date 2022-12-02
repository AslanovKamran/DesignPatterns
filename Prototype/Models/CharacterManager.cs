using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
	enum Class
	{
		Warrior = 1,
		Thief,
		Mage

	}

	class CharacterManager
	{
		private Dictionary<Class, Character> presets;
		public CharacterManager()
		{
			presets = new();
			presets.Add(Class.Warrior, new Character()
			{
				HP = 200,
				MP = 0,
				Strength = 10,
				Agility = 5,
				Intellect = 2
			});
			presets.Add(Class.Thief, new Character()
			{
				HP = 100,
				MP = 0,
				Strength = 5,
				Agility = 15,
				Intellect = 2
			});

			presets.Add(Class.Mage, new Character()
			{
				HP = 85,
				MP = 200,
				Strength = 2,
				Agility = 5,
				Intellect = 20
			});
		}

		//Indexer
		public Character this[Class cls]
		{
			get { return presets[cls]; }
		}

	}
	
}
