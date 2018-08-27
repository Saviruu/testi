using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Muistio
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MuistioSivu : ContentPage
	{
		public MuistioSivu ()
		{
			InitializeComponent ();
		}
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            entries.ItemsSource = await App.Muistiot.ReadAsync();
        }
	}
}