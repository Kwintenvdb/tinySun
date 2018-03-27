using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using tinySun.Interfaces;
using tinySun.Models;
using tinySun.Services;
using Xamarin.Forms;

namespace tinySun
{
	public partial class App : Application
	{
		public App(IAssetLoader assetLoader)
		{
			var dataProvider = new DataProvider(assetLoader);
			var cityProvider = new CityProvider(assetLoader);

			ServiceProvider.Register<IAssetLoader>(assetLoader);
			ServiceProvider.Register<DataProvider>(dataProvider);
			ServiceProvider.Register<CityProvider>(cityProvider);

			InitializeComponent();

			MainPage = new MainPage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
