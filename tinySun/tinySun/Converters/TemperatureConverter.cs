using System;
using System.Globalization;
using tinySun.Enums;
using Xamarin.Forms;

namespace tinySun.Converters
{
	// Convert from Kelvin to another unit.
	public class TemperatureConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value == null) return 0;

			TemperatureUnit targetUnit = (TemperatureUnit)parameter;
			float kelvin = (float)value;

			switch (targetUnit)
			{
				case TemperatureUnit.Celsius:
					return kelvin - 273.15f;
				case TemperatureUnit.Fahrenheit:
					return kelvin * 9 / 5 - 459.67f;
				default:
					return kelvin;
			}
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
