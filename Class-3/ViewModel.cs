// ViewModel.cs
using System.ComponentModel;
using System.Windows.Input;

namespace ProjectApp
{
    public class ViewModel : INotifyPropertyChanged
    {
        private string _userInput;

        public string UserInput
        {
            get { return _userInput; }
            set
            {
                if (_userInput != value)
                {
                    _userInput = value;
                    OnPropertyChanged(nameof(UserInput));
                }
            }
        }

        private string _userInputReversed;

        public string UserInputReversed
        {
            get { return _userInputReversed; }
            set
            {
                if (_userInputReversed != value)
                {
                    _userInputReversed = value;
                    OnPropertyChanged(nameof(UserInputReversed));
                }
            }
        }

        public ViewModel()
        {
            ButtonClicked = new RelayCommand(buttonclicked, canclickbutton);
        }


        private bool canclickbutton(object value)
        {
            return !string.IsNullOrEmpty(_userInput);
        }

        private void buttonclicked(object value)
        {
            char[] charArray = UserInput.ToCharArray();
            Array.Reverse(charArray);

            UserInputReversed = new string(charArray);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ICommand ButtonClicked {  get; set; }




    }
}
