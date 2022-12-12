

namespace Observer.Models
{
	internal interface IPhoneBuyer
	{
		void Buy(Shop shop);
	}

	//Subsciber  
	class Customer : IPhoneBuyer
	{

		public string Name { get; set; } = string.Empty;
		public decimal Money { get; set; } = default;
		public Customer(){}
		public Customer(string name, decimal money)
		{
			Name = name;
			Money = money;
		}

		public void Buy(Shop shop)
		{
			
			Console.Write($"New phone arrived : {shop.NewPhone}\t");
			if (shop.NewPhone?.Price > this.Money) Console.Write($"But you can't buy it =( (Your money {this.Money})");
			else Console.Write("And you can buy it");
			Console.WriteLine("\n");

		}
	}
}
