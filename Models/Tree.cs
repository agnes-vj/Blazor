namespace Complimentree.Models
{
	public class Tree
	{
		public Tree(int id, string name, string latitude, string longitude, int size, string species)
		{
			Id = id;
			Name = name;
			Latitude = latitude;
			Longitude = longitude;
			Size = size;
			Species = species;
		}
		public int Id { get; set; }

		public string Name { get; set; }	

		public string Latitude { get; set; } 

		public string Longitude { get; set; }

		public int Size { get; set; }

		public string Species { get; set; }

		public List<Compliment> Compliments { get; set; } = new List<Compliment>();

		
	}
}
