using Observer.Models;

namespace Observer
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var shop = new Shop();

			var customer1 = new Customer("John", 5_000);
			var customer2 = new Customer("Drake", 200);
			var customer3 = new Customer("Bob", 1_000);

			shop.AddSubcsriber(customer1);
			shop.AddSubcsriber(customer2);
			shop.AddSubcsriber(customer3);

			//Event
			shop.OnNewPhoneArrived(new Phone("Iphone X", 2_000));
			shop.OnNewPhoneArrived(new Phone("Samsung Galaxy Pro Mega Ultra", 6_000));
		}
	}
}