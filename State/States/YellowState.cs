namespace State.States
{
	class YellowState : LightState
	{
		public override void NextState()
		{
			Console.WriteLine("From Yellow to Red");
			trafficLight?.SetState(new RedState());
		}

		public override void PrevState()
		{
			Console.WriteLine("From Yellow to Green");
			trafficLight?.SetState(new GreenState());
		}
	}
}
