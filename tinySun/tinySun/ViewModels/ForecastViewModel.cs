using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tinySun.Models;
using tinySun.Services;
using Xamarin.Forms;

namespace tinySun.ViewModels
{
	public class ForecastViewModel : ViewModel
	{
		public Command GetCurrentWeatherCommand { get; set; }
		public Command GetForecastCommand { get; set; }

		private string _cityName;
		public string CityName
		{
			get { return _cityName; }
			set
			{
				_cityName = value;
				RaisePropertyChanged(() => CityName);

				SearchCities = ServiceProvider.Get<CityProvider>().GetPossibleCities(CityName).ToList();
				RaisePropertyChanged(() => SearchCities);
			}
		}
		public WeatherData CurrentWeather { get; set; }

		public IEnumerable<City> SearchCities { get; set; }

		private DataProvider _provider = new DataProvider(null);

		public ForecastViewModel()
		{
			GetCurrentWeatherCommand = new Command(GetCurrentWeather);
			GetForecastCommand = new Command(GetForecast);
		}

		public async void GetCurrentWeather()
		{
			CurrentWeather = await _provider.GetCurrentWeather();
			RaisePropertyChanged(() => CurrentWeather);
		}

		public async void GetForecast()
		{
			_provider.GetForecast();
		}
	}
}
