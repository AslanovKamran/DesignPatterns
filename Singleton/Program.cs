namespace Singleton
{
	internal class Program
	{
		

		static void Main(string[] args)
		{

			Singleton obj1 = Singleton.Instance;
			Singleton obj2 = Singleton.Instance;
			Singleton obj3 = Singleton.Instance;


			obj1.Data.Add(1);
			obj2.Data.Add(2);
			obj3.Data.Add(3);


			foreach (var item in obj1.Data)
			{
				Console.WriteLine(item);
			}
		}

	}
}