using System;

using Xamarin.Forms;
using System.Collections.Generic;

namespace XamarinSeed
{
	public class MenuPage : MasterDetailPage
	{
		public MenuPage ()
		{
		}

		public const string MenuFirstItem = "FirstItem";
		public const string MenuSecondItem = "SecondItem";
		public const string MenuThirdItem = "ThirdItem";
		public const string MenuSettingsItem = "Settings";

		/// <summary>
		/// Initialize the menu
		/// </summary>
		public void Initialize()
		{
			// helpful links to go further : https://www.syntaxismyui.com/xamarin-forms-masterdetail-page-navigation-recipe/

			Label header = new Label
			{
				Text = "menu",
				BackgroundColor = Color.White,
				HorizontalOptions = LayoutOptions.Center
			};

			List<string> list = new List<string>() { MenuFirstItem, MenuSecondItem, MenuThirdItem, MenuSettingsItem };
			ListView systemListView = new ListView
			{
				BackgroundColor = Color.White,
				ItemsSource = list
			};

			NavigationPage.SetHasNavigationBar(this, false);
			this.Master = new ContentPage
			{
				BackgroundColor = Color.White,
				Title = "MyApp",
				Content = new StackLayout
				{
					Children = 
					{
						header,
						systemListView
					}
				}
			};

			this.Detail = App.Instance.Navigation;

			systemListView.ItemSelected += (sender, args) => {
				if (args.SelectedItem.ToString() == MenuFirstItem)
				{
					
				}
				else if (args.SelectedItem.ToString() == MenuSecondItem)
				{

				}
				else if (args.SelectedItem.ToString() == MenuThirdItem)
				{
					
				}
				else if (args.SelectedItem.ToString() == MenuSettingsItem)
				{
					
				}
					
				this.IsPresented = false;
			};
		}
	}
}


