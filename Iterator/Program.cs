using Iterator.Models;

namespace Iterator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			NodeList<User> list = new NodeList<User>(new User() { Login="Nick", Password ="Ros",Age =30});
			list.AddLast(new User() { Login = "John", Password = "Doe", Age = 19 });
		
			foreach (var item in list)
			{
				Console.WriteLine(item);
			}
		}

	}
}