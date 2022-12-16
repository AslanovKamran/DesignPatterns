

namespace State.States
{
	class GreenState : LightState
	{
		public override void NextState()
		{
			Console.WriteLine("From Green to Yellow");
			trafficLight?.SetState(new YellowState());
		}

		public override void PrevState()
		{
			Console.WriteLine("Green light");
		}
	}
}
