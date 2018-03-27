using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using tinySun.Interfaces;
using tinySun.Models;

namespace tinySun.Services
{
	public class CityProvider
	{
		private Dictionary<int, City> _cities;

		public CityProvider(IAssetLoader assetLoader)
		{
			using (var reader = new StreamReader(assetLoader.OpenAsset("city.list.json")))
			{
				var contents = reader.ReadToEnd();
				var cities = JsonConvert.DeserializeObject<City[]>(contents);
				_cities = cities.ToDictionary(c => c.Id);
			}
		}

		public IEnumerable<City> GetPossibleCities(string searchName)
		{
			return _cities.Values.Take(10);
		}
	}
}
