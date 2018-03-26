using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using tinySun.Api;
using tinySun.Models;

namespace tinySun
{
	public class DataProvider
	{
		private OWMClient _client = new OWMClient();
		
		public async Task<WeatherData> GetCurrentWeather()
		{
			var weather = await _client.SendRequest<WeatherData>("weather?q=London");
			return weather;
		}
	}
}
