using System;

using Xamarin.Forms;
using System.Collections.Generic;

namespace XamarinSeed
{
    /// <summary>
    /// Left panel sliding opening a menu
    /// </summary>
	public class MenuPage : MasterDetailPage
	{
        #region initialization

        public MenuPage ()
        {
        }

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

            systemListView.ItemSelected += this.ItemSelected;
        }

        #endregion

        #region customize the menu on left panel

		public const string MenuFirstItem = "FirstItem";
		public const string MenuSecondItem = "SecondItem";
		public const string MenuThirdItem = "ThirdItem";
		public const string MenuSettingsItem = "Settings";

        /// <summary>
        /// This method is called when an item is selected in the menu
        /// </summary>
        private void ItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            if (args.SelectedItem.ToString() == MenuFirstItem)
            {
                App.Instance.WelcomeViewModel.Item.MyText = "You clicked on first menu";
            }
            else if (args.SelectedItem.ToString() == MenuSecondItem)
            {
                App.Instance.WelcomeViewModel.Item.MyText = "You clicked on second menu";
            }
            else if (args.SelectedItem.ToString() == MenuThirdItem)
            {
                App.Instance.WelcomeViewModel.Item.MyText = "You clicked on third menu";
            }
            else if (args.SelectedItem.ToString() == MenuSettingsItem)
            {
                App.Instance.WelcomeViewModel.Item.MyText = "You clicked on settings menu";
            }
                
            this.IsPresented = false;
        }

        #endregion
	}
}


