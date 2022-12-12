using Command.Commands;
using Command.Models;

namespace Command
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Conveyor conveyor = new Conveyor();

			List<ICommand> commands = new List<ICommand>()
			{
				 new ConveyorRemoteCommand(conveyor),
				 new ConveyorAdjustCommand(conveyor),

			};

			MultiPult multiPult = new MultiPult(commands);
			multiPult.SetCommand(0, commands[0]);
			multiPult.SetCommand(1, commands[1]);

			multiPult.PressOn(0);
			multiPult.PressCancel();

			multiPult.PressOn(0);
			multiPult.PressOn(1);
			multiPult.PressCancel();
			multiPult.PressCancel();

			multiPult.PressCancel();


		}
	}
}