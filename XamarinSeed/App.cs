using System;

using Xamarin.Forms;

namespace XamarinSeed
{
	public class App : Application
	{
		#region singleton

        /// <summary>
        /// static member for singleton
        /// </summary>
		private static App instance;
		
        /// <summary>
        /// singleton prevents any other class from instantiating
        /// </summary>
		private App() 
		{
		}
		
        /// <summary>
        /// Gets the unique instance
        /// </summary>
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

        /// <summary>
        /// NavigationPage manages the navigation and user-experience of a stack of other pages
        /// </summary>
		public NavigationPage Navigation { get; private set; }

        /// <summary>
        /// WelcomeView datas and commands
        /// </summary>
		public WelcomeViewModel WelcomeViewModel { get; private set; }

		#endregion

		#region methods to initialize

        /// <summary>
        /// Initializes the app.
        /// </summary>
		public void InitializeApp ()
		{	
			try {
				Logger.Info("App.GetMainPage");
				WelcomeViewModel = new WelcomeViewModel();
				Navigation = new NavigationPage(new WelcomePage());				
                var mainPage = new MenuPage();
                mainPage.Initialize();
                MainPage = mainPage;
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

