
namespace Facade.Models
{
	enum GuideType
	{
		None,
		Audio,
		Person
	}

	internal class GuideBooking
	{
		public int BookGuide(GuideType type, int days)
		{
			switch (type)
			{
				case GuideType.None:
					return 0;
				case GuideType.Audio:
					return 25 * days;
				case GuideType.Person:
					return 50 * days;
				default:
					return 0;
			}
		}
	}
}
