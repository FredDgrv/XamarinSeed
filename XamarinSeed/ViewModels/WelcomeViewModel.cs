using System;
using Xamarin.Forms;
using System.Windows.Input;

namespace XamarinSeed
{
	public class WelcomeViewModel
	{
		public WelcomeViewModel ()
		{
		}

		#region navigate welcome page

		private Command _navigateWelcomeToSignin;
		public ICommand NavigateWelcomeToSignin
		{
			get
			{
				if (_navigateWelcomeToSignin == null)
				{
					_navigateWelcomeToSignin = new Command(
						(parameter) => 
						{
							// implement Xamarin.Auth if needed
						}
					);
				}
				return _navigateWelcomeToSignin;
			}
		}

		#endregion
	}
}

