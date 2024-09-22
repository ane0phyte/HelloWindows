// ViewModel.cs
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Class_5
{
    public class ViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<string> Items { get; set; }

        public ViewModel()
        {
            Items = new ObservableCollection<string>
            {
                "Item 1",
                "Item 2",
                "Item 3"
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
