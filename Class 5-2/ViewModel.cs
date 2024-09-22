// ViewModel.cs
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace Class_5_2
{
    public class ViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<string> _items;
        public ObservableCollection<string> FilteredItems { get; set; }

        public ViewModel()
        {
            _items = new ObservableCollection<string>
            {
                "Apple",
                "Banana",
                "Cherry"
            };
            FilteredItems = new ObservableCollection<string>(_items.Where(i => i.StartsWith("A")));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
