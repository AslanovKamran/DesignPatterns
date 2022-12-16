using State.Models;
using State.States;

namespace State
{
	internal class Program
	{
		static void Main(string[] args)
		{
			TrafficLight trafficLight = new TrafficLight(new GreenState());

			trafficLight.MoveNext();
			trafficLight.MoveNext();
			trafficLight.MoveNext();

			Console.WriteLine("\n");

			trafficLight.MoveBack();
			trafficLight.MoveBack();
			trafficLight.MoveBack();

		}
	}
}