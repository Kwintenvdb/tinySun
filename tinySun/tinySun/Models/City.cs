using Newtonsoft.Json;

namespace tinySun.Models
{
	public class City
	{
		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("country")]
		public string Country { get; set; }
	}
}
