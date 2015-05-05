using System;
using Xamarin.Forms;
using System.Windows.Input;

namespace XamarinSeed
{
	public class WelcomeViewModel
	{
        #region ctor

		public WelcomeViewModel ()
		{
            Item = new Item
            {
                MyText = "I'm sleeping."
            };
		}

        #endregion

        #region data

        public Item Item { get; set; }

        #endregion

		#region commands

		private Command _buttonClickedCommand;
		public ICommand ButtonClickedCommand
		{
			get
			{
				if (_buttonClickedCommand == null)
				{
					_buttonClickedCommand = new Command(
						(parameter) => 
						{
                            Item.MyText = "I'm moving! Yeah!";
						}
					);
				}
				return _buttonClickedCommand;
			}
		}

		#endregion
	}
}

