using State.States;

namespace State.Models
{
	class TrafficLight
	{
		private LightState? state;
		public TrafficLight(LightState state) => SetState(state);

		public void SetState(LightState st)
		{
			this.state = st;
			state.TrafficLight = this;
		}

		public void MoveNext() => this.state?.NextState();
		public void MoveBack() => this.state?.PrevState();
	}
}
