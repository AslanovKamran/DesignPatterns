namespace ChainOfResponsibility.Accounts
{
	internal static class AccountDataBase
	{
		public static List<Account> Accounts;

		static AccountDataBase()
		{
			Accounts = new List<Account>()
			{
				new Account ("John Doe", "5874-8587-2578-8955", 1111, 1_000) ,
				new Account ( "Sara Parker", "5874-8587-1125-1736", 2222, 2_000),
			};
		}
	}
}
