using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace tinySun.Models
{
	public class MainData
	{
		[JsonProperty("temp")]
		public float Temperature { get; set; }
	}

	public class WeatherData
	{
		[JsonProperty("main")]
		public MainData Main { get; set; }
	}
}
