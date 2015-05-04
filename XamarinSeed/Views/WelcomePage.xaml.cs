using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinSeed
{
	public partial class WelcomePage : ContentPage
	{
		public WelcomePage ()
		{
			BindingContext = App.Instance.WelcomeVM;
			InitializeComponent ();
		}
	}
}

