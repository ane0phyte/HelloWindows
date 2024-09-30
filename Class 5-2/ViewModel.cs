// ViewModel.cs
using Microsoft.VisualBasic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Controls;

namespace Class_5_2
{
    public class ViewModel : INotifyPropertyChanged
    {
        // Collection of items setup
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

        // User input setup
        private String _userInput;
        public String UserInput
        {
            get { return _userInput; }

            set
            {
                if (_userInput != value)
                {
                    _userInput = value;
                    OnPropertyChanged(nameof(UserInput));

                    FilterItems(); // filter items after user input is updated
                }
            }
        }

        // Case-sensitive checkbox setup
        private bool _isCaseSensitive;
        public bool IsCaseSensitive
        {
            get { return _isCaseSensitive;}
            set
            {
                if (_isCaseSensitive != value)
                {
                    _isCaseSensitive = value;
                    OnPropertyChanged(nameof(IsCaseSensitive));

                    FilterItems();
                }   
            }
        }
        public ViewModel()
        {
            _items = new ObservableCollection<string>
            {
                "Apple",
                "Banana",
                "Cherry",
                "Date",
                "Eggplant",
                "Fig",
                "Grape",
                "Honeydew",
                "Iceberg lettuce",
                "Jackfruit",
                "Kiwi",
                "Lemon",
                "Mango",
                "Nectarine",
                "Orange",
                "Papaya",
                "Quince",
                "Raspberry",
                "Strawberry",
                "Tomato",
                "Ugli fruit",
                "Vanilla bean",
                "Watermelon",
                "Xigua",
                "Yam",
                "Zucchini"
            };

            // Filter items at beginning of program; which isn't necessary, but a nice-to-have
            FilterItems();
        }

        public void FilterItems()
        {
            if (UserInput != null)
            {
                if (IsCaseSensitive)
                {
                    // Case-sensitive filtering
                    FilteredItems = new ObservableCollection<string>(_items.Where(i => i.Contains(UserInput)));
                }
                else
                {
                    // Case-insensitive filtering
                    FilteredItems = new ObservableCollection<string>(_items.Where(i => i.Contains(UserInput, StringComparison.OrdinalIgnoreCase)));
                }
            }
            else
            {
                FilteredItems = new ObservableCollection<string>(_items);
            }
            OnPropertyChanged(nameof(FilteredItems));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
