using System;
using System.Collections.Generic;
using System.Text;
using tinySun.Models;
using Xamarin.Forms;

namespace tinySun.ViewModels
{
	public class ForecastViewModel : ViewModel
	{
		public Command GetCurrentWeatherCommand { get; set; }

		public WeatherData CurrentWeather { get; set; }

		private DataProvider _provider = new DataProvider();

		public ForecastViewModel()
		{
			GetCurrentWeatherCommand = new Command(GetCurrentWeather);
		}

		public async void GetCurrentWeather()
		{
			CurrentWeather = await _provider.GetCurrentWeather();
			RaisePropertyChanged(() => CurrentWeather);
		}
	}
}
