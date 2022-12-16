namespace State.States
{
	class RedState : LightState
	{
		public override void NextState()
		{
			Console.WriteLine("Red Light");
		}

		public override void PrevState()
		{
			Console.WriteLine("From Red to Yelllow");
			trafficLight?.SetState(new YellowState());
		}
	}
}
