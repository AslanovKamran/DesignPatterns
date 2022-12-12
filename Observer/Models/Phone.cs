

namespace Observer.Models
{
	internal class Phone
	{
		public string Name { get; set; } = string.Empty;
		public decimal Price { get; set; } = default;
		public Phone() { }
		public Phone(string name, decimal price)
		{
			Name = name;
			Price = price;
		}

		public override string ToString() => $"{Name} {Price}$";
	}
}
