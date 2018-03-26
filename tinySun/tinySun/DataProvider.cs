using System;
using System.Collections.Generic;
using System.Text;
using tinySun.Api;
using tinySun.Models;

namespace tinySun
{
	public class DataProvider
	{
		private OWMClient _client = new OWMClient();
		
		public async void GetCurrentWeather()
		{
			var weather = await _client.SendRequest<WeatherData>("weather?q=London");
		}
	}
}
