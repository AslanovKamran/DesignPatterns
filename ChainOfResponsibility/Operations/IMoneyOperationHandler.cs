using ChainOfResponsibility.Accounts;

namespace ChainOfResponsibility.Operations
{
	internal interface IMoneyOperationHandler
	{
		IMoneyOperationHandler? SetNextHandler(IMoneyOperationHandler handler);
		void Handle(string cardNumber, int pin, decimal money);
	}

	class VerifyAccountHandler : IMoneyOperationHandler
	{
		private IMoneyOperationHandler? handler;
		public IMoneyOperationHandler SetNextHandler(IMoneyOperationHandler handler)
		{
			this.handler = handler;
			return handler;
		}

		public void Handle(string cardNumber, int pin, decimal money)
		{
			if (AccountDataBase.Accounts.Any(x => x.CardNumber == cardNumber && x.Pin == pin))
			{
				Console.WriteLine("Account verified");
				string fullname = AccountDataBase.Accounts.First(x => x.CardNumber == cardNumber).FullName;
				Console.WriteLine("Welcome " + fullname);
				handler?.Handle(cardNumber, pin, money);
			}
			else
			{
				Console.WriteLine("Verification Error!");
			}
		}
	}

	class CheckMoneyHandler : IMoneyOperationHandler
	{
		private IMoneyOperationHandler? handler;
		public IMoneyOperationHandler SetNextHandler(IMoneyOperationHandler handler)
		{
			this.handler = handler;
			return handler;
		}
		public void Handle(string cardNumber, int pin, decimal money)
		{
			var account = AccountDataBase.Accounts.First(x => x.CardNumber == cardNumber && x.Pin == pin);
			if (account.Money >= money)
			{
				Console.WriteLine("You can withdraw money");
				handler?.Handle(cardNumber, pin, money);
			}
			else
			{
				Console.WriteLine("Not enough money ");
			}
		}
	}

	class MoneyOperationLoggerHandler : IMoneyOperationHandler
	{
		private IMoneyOperationHandler? handler;
		public IMoneyOperationHandler SetNextHandler(IMoneyOperationHandler handler)
		{
			this.handler = handler;
			return handler;
		}

		public void Handle(string cardNumber, int pin, decimal money)
		{
			var account = AccountDataBase.Accounts.First(x => x.CardNumber == cardNumber && x.Pin == pin);
			Console.WriteLine($"Client: {account.FullName}; Card number: {account.CardNumber} - {money}$ ({DateTime.Now})");
			handler?.Handle(cardNumber, pin, money);
		}
	}

	class RecieveMoneyHandler : IMoneyOperationHandler
	{
		private IMoneyOperationHandler? handler;
		public IMoneyOperationHandler SetNextHandler(IMoneyOperationHandler handler)
		{
			this.handler = handler;
			return handler;
		}

		public void Handle(string cardNumber, int pin, decimal money)
		{
			var account = AccountDataBase.Accounts.First(x => x.CardNumber == cardNumber && x.Pin == pin);
			account.Money -= money;
			Console.WriteLine($"Withdrawn: {money}; Left: {account.Money}");

		}
	}
}
