using System;
using System.Collections.Generic;
using System.Text;

namespace tinySun.Services
{
	public static class ServiceProvider
	{
		private static readonly Dictionary<Type, object> _services = new Dictionary<Type, object>();

		public static void Register<T>(T obj)
		{
			_services.Add(typeof(T), obj);
		}

		public static T Get<T>()
		{
			return (T)_services[typeof(T)];
		}
	}
}
