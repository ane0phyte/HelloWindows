// ViewModel.cs
using System.ComponentModel;

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

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
