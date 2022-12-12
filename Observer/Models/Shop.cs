

namespace Observer.Models
{
	//Publisher
	internal class Shop
	{
		public Phone? NewPhone { get; set; }
		public decimal Money { get; set; } = 100_000;
		public List<IPhoneBuyer> Buyers { get; set; } = new();

		public void AddSubcsriber(IPhoneBuyer buyer)=>Buyers.Add(buyer);
		public void RemoveSubscriber(IPhoneBuyer buyer)=>Buyers.Remove(buyer);

		public void OnNewPhoneArrived(Phone phone)
		{
			NewPhone = phone;
			foreach (var item in Buyers)
			{
				item.Buy(this);
			}
		}
	}
}
