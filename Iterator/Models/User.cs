
namespace Iterator.Models
{
	internal class User
	{
		public string Login { get; set; } =string.Empty;
		public string Password { get; set; } = string.Empty;
		public int Age { get; set; } = default;

		public override string ToString() => $"User: {Login}; Password: {Password}; Age: {Age}";
	}
}
