using System;

namespace XamarinSeed
{
    public class Item : ObservableData
    {
        public Item()
        {            
        }

        private string _myText;
        public string MyText
        {
            get { return _myText; } 
            set { SetField(ref _myText, value); }
        }
    }
}

