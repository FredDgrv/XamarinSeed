using System;

using Xamarin.Forms;

namespace XamarinSeed
{
	public class App : Application
	{
		#region singleton

		private static App instance;
		
		private App() 
		{
			InitializeApp();
		}
		
		public static App Instance
		{
		  get 
		  {
		     if (instance == null)
		     {
		        instance = new App();
		     }
		     return instance;
		  }
		}
		
		#endregion

		#region properties

		public NavigationPage Navigation { get; private set; }

		public WelcomeViewModel WelcomeVM { get; private set; }

		#endregion

		#region methods to initialize

		public void InitializeApp ()
		{	
			try {
				Logger.Info("App.GetMainPage");
				WelcomeVM = new WelcomeViewModel();
				Navigation = new NavigationPage(new WelcomePage());
				MainPage = new MenuPage();				
			} catch (Exception e) {
				throw e;
			}
		}

		#endregion

		#region methods for application life on device

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

		#endregion
	}
}

