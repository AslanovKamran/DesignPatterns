namespace Proxy.Models
{
	public class Movie
	{
		public string Title { get; set; } = string.Empty;
		public int Year { get; set; }
		public string Plot { get; set; } = string.Empty;

		public Movie() { }

		public Movie(string title, int year, string plot)
		{
			Title = title;
			Year = year;
			Plot = plot;
		}

		public override string ToString()
		{
			return $"Title: {Title}\nYear: {Year}\n\n{Plot}";
		}
	}
}
