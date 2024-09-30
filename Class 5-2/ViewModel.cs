// ViewModel.cs
using Microsoft.VisualBasic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Data;

namespace Class_5_2
{
    public class ViewModel : INotifyPropertyChanged
    {
        private string _filterText;


        public string FilterText
        {
            get
            {
                return _filterText;
            }
            set
            {
                if (_filterText != value)
                {
                    _filterText = value;
                    UpdateFilteredItems();
                }
            }
        }

        private ObservableCollection<string> _items;
        private ObservableCollection<string> _filteredItems;
        public ObservableCollection<string> FilteredItems
        {
            get { return _filteredItems; }
            set
            {
                _filteredItems = value;
                OnPropertyChanged(nameof(FilteredItems));
            }
        }

        private void UpdateFilteredItems()
        {
            if (_items == null || String.IsNullOrEmpty(_filterText))
            {
                FilteredItems = new ObservableCollection<string>(_items);
            }
            else
            {
                FilteredItems = new ObservableCollection<string>(_items.Where(i => i.ToUpper().Contains(_filterText.ToUpper())));
            }
        }

        public ViewModel()
        {
            _items = new ObservableCollection<string>
            {
                "Apple",
                "Banana",
                "Cherry"
            };
            FilteredItems = new ObservableCollection<string>(_items);

        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
