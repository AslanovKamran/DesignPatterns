using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	class Singleton
	{
		static private Singleton? instance;

		static public Singleton Instance
		{
			get
			{
				if (instance == null)
					instance = new Singleton();
				return instance;
			}
		}

		public List<int> Data { get; set; }

		private Singleton()
		{
			this.Data = new();
		}
	}
}
