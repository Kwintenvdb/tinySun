using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tinySun.ViewModels;
using Xamarin.Forms;

namespace tinySun
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			BindingContext = new ForecastViewModel();
		}
	}
}
