using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using tinySun.Api;
using tinySun.Interfaces;
using tinySun.Models;

namespace tinySun
{
	public class DataProvider
	{
		private readonly IAssetLoader _assetLoader;
		private readonly OWMClient _client = new OWMClient();
		
		public DataProvider(IAssetLoader assetLoader)
		{
			_assetLoader = assetLoader;
		}

		public async Task<WeatherData> GetCurrentWeather()
		{
			var weather = await _client.SendRequest<WeatherData>("weather?q=London");
			return weather;
		}

		public async void GetForecast()
		{
			await _client.SendRequest<object>("forecast?q=Linz");
		}
	}
}
