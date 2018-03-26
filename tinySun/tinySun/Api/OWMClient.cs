using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace tinySun.Api
{
	// Open Weather Map client
	public class OWMClient
	{
		private const string BASE_URI = "http://api.openweathermap.org/data/2.5/";
		private const string APP_ID = "&APPID=a5f99fb3c430c84a4ff4e637291a81af";

		public async Task<T> SendRequest<T>(string request)
		{
			try
			{
				using (var httpClient = new HttpClient())
				{
					var response = await httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get, $"{BASE_URI}{request}{APP_ID}"));
					if (response.IsSuccessStatusCode)
					{
						string content = await response.Content.ReadAsStringAsync();
						T obj = JsonConvert.DeserializeObject<T>(content);
						return obj;
					}
				}
			}
			catch (System.Exception e)
			{

			}

			return default(T);
		}
	}
}
