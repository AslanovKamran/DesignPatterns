using ChainOfResponsibility.Operations;

namespace ChainOfResponsibility
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IMoneyOperationHandler verifyHandler = new VerifyAccountHandler();
			IMoneyOperationHandler checkHandler = new CheckMoneyHandler();
			IMoneyOperationHandler loggerHandler = new MoneyOperationLoggerHandler();
			IMoneyOperationHandler recieveHandler = new RecieveMoneyHandler();

			verifyHandler?.SetNextHandler(checkHandler)
						 ?.SetNextHandler(loggerHandler)
						 ?.SetNextHandler(recieveHandler);

			string cardNumber;
			int pin;
			decimal money;


			//John Doe, 5874-8587-2578-8955, 1111, 1_000

			Console.WriteLine("Enter card number: ");
			cardNumber = Console.ReadLine()!;
			Console.WriteLine("Enter pin: ");
			pin = int.Parse(Console.ReadLine()!);
			Console.WriteLine("Enter amount: ");
			money = decimal.Parse(Console.ReadLine()!);
			verifyHandler?.Handle(cardNumber, pin, money);

			

		}
	}
}