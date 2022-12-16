

using State.Models;

namespace State.States
{
	abstract class LightState
	{
		protected TrafficLight? trafficLight;
		public TrafficLight? TrafficLight { set => trafficLight = value; }

		public abstract void NextState();
		public abstract void PrevState();
	}

	
}
