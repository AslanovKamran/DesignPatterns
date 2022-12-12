using Command.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Models
{
	class Conveyor
	{
		public bool IsWorking { get; set; } = false;
		private int speed = 10;

		public int Speed
		{
			get { return speed; }
			set
			{
				if (value <= 0) speed = 1;
				else speed = value;
			}
		}


		public void ConveyorOn() => IsWorking = true;
		public void ConveyorOff() => IsWorking = false;

		public void SpeedIncrease(int value = 1) => Speed += value;
		public void SpeedDecrease(int value = 1) => Speed -= value;
	}

	class ConveyorRemoteCommand : ICommand
	{
		private readonly Conveyor _conveyor;
		public ConveyorRemoteCommand(Conveyor conveyor) => _conveyor = conveyor;

		public void NegativeCommnand()
		{
			_conveyor.ConveyorOff();
			Console.WriteLine("Conveyor turned OFF");
		}

		public void PositiveCommnand()
		{
			_conveyor.ConveyorOn();
			Console.WriteLine("Conveyor turned ON");
		}
	}

	class ConveyorAdjustCommand : ICommand
	{
		private readonly Conveyor _conveyor;
		public ConveyorAdjustCommand(Conveyor conveyor) => _conveyor = conveyor;

		public void NegativeCommnand()
		{
			if (_conveyor.IsWorking)
			{
				_conveyor.SpeedDecrease();
				Console.WriteLine($"Speed Decreased. Current Speed is {_conveyor.Speed}");
			}
			else
			{
				Console.WriteLine("Turn ON conveyor, first");
			}
		}

		public void PositiveCommnand()
		{
			if (_conveyor.IsWorking)
			{
				_conveyor.SpeedIncrease();
				Console.WriteLine($"Speed Increased. Current Speed is {_conveyor.Speed}");
			}
			else
			{
				Console.WriteLine("Turn ON conveyor, first");
			}
		}
	}

	class MultiPult
	{
		private List<ICommand> commands;
		private Stack<ICommand> history;

		public MultiPult(List<ICommand> commands)
		{
			this.commands = commands;
			this.history = new();
		}

		public void SetCommand(int buttonIndex, ICommand command) => commands[buttonIndex] = command;
		public void PressOn(int buttonIndex)
		{
			commands[buttonIndex].PositiveCommnand();
			history.Push(commands[buttonIndex]);
		}

		public void PressCancel()
		{
			if (history.Count != 0)
			{
				history.Pop().NegativeCommnand();
			}
			else
			{
				Console.WriteLine("Nothing to cancel");
			}
		}
	}
}
