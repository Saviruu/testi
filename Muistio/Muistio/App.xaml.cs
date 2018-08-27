using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace Muistio
{
    
	public partial class App : Application
	{
        public static IMuistio Muistiot { get; set; }
        public App ()
		{
			InitializeComponent();
            MainPage = new MuistioSivu();
			//MainPage = new MainPage();
            Muistiot = new MemoryEntryStore();
            Muistiot.LataaData();

		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
