using System;
using System.Collections.Generic;
using System.Text;
using tinySun.Api;

namespace tinySun
{
	public class DataProvider
	{
		private OWMClient _client = new OWMClient();
		
		public async void GetCurrentWeather()
		{
			var weather = await _client.SendRequest<object>("weather?q=London");
		}
	}
}
