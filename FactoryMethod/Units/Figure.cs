namespace FactoryMethod.Unit
{

	abstract class Figure
	{
		public char[,] Layout { get; set; } = new char[4, 4];
		public void GetInfo()
		{
			Random r = new Random();
			Console.ForegroundColor = (ConsoleColor)r.Next(1, 16);
			for (int i = 0; i < Layout.GetLength(0); i++)
			{
				for (int j = 0; j < Layout.GetLength(1); j++)
				{
					Console.Write(Layout[i, j] + " ");
				}
				Console.WriteLine();
			}
			Console.ResetColor();
		}
	}

	class FigureLine : Figure
	{
		public FigureLine()
		{
			this.Layout = new char[4, 4] 
			{ 
				{ '■', ' ', ' ', ' ' }, 
				{ '■', ' ', ' ', ' ' }, 
				{ '■', ' ', ' ', ' ' }, 
				{ '■', ' ', ' ', ' ' }
			};
		}
	}

	class FigureSquare : Figure
	{
		public FigureSquare()
		{
			this.Layout = new char[4, 4]
			{
				{ ' ', ' ', ' ', ' ' },
				{ ' ', '■', '■', ' ' },
				{ ' ', '■', '■', ' ' },
				{ ' ', ' ', ' ', ' ' }
			};
		}
	}

	class FigureZ : Figure
	{
		public FigureZ()
		{
			this.Layout = new char[4, 4]
			{
				{ ' ', ' ', ' ', ' ' },
				{ '■', '■', ' ', ' ' },
				{ ' ', '■', '■', ' ' },
				{ ' ', ' ', ' ', ' ' }
			};
		}
	}

	class FigureL : Figure
	{
		public FigureL()
		{
			this.Layout = new char[4, 4]
			{
				{ '■', ' ', ' ', ' ' },
				{ '■', ' ', ' ', ' ' },
				{ '■', ' ', ' ', ' ' },
				{ '■', '■', '■', ' ' }
			};
		}
	}

	class FigureT : Figure
	{
		public FigureT()
		{
			this.Layout = new char[4, 4]
			{
				{ '■', '■', '■', ' ' },
				{ ' ', '■', ' ', ' ' },
				{ ' ', '■', ' ', ' ' },
				{ ' ', '■', ' ', ' ' }
			};
		}
	}

}
