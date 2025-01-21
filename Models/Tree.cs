namespace Complimentree.Models
{
	public class Tree
	{
		public int Id { get; set; }

		public string Name { get; set; }	

		public string Latitude { get; set; }

		public string Longitude { get; set; }

		public int Size { get; set; }

		public string Species { get; set; }

		public List<Compliment> Compliments { get; set; }

		
	}
}
