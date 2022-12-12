

namespace Memento.Models
{
	internal class Location
	{
		public int X { get; set; } = 0;
		public int Y { get; set; } = 0;
	}

	enum Direction
	{
		Up=1,Down,Left,Right
	}
}
