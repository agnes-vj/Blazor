namespace Complimentree.Models
{
	public class Compliment
	{
		public int Id { get; set; }

		public string Text { get; set; }
		public static List<string> complimentStrings = new List<string>()
		{
			"You may not be evergreen, but you are to me.",
			"I bet squirrels consider you prime real estate.",
			"You're so down to earth.",
			"You're very grounded.",
			"Your leaves are soothing.",
			"You sway nicely in the wind.",
			"You're blooming brilliant.,ill and doing nothing.",
			"Let's get to the root of your beauty.",
			"I will never leaf you.",
			"You've really branched out lately.",
			"You provide the perfect amount of shade on a hot day.",
			"I'm really pine-ing for you."
		};
		public static Compliment GetCompliment()
		{
			Random random = new Random();
			int newId = random.Next(0, 12);
			return new Compliment { Id = newId, Text = complimentStrings[newId] };
		}

	}
}
