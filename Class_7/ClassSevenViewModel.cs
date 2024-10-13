using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Class_7
{
    public class ClassSevenViewModel
    {
        public ClassSevenViewModel()
        {
            ObservableCollection<string> items = new ObservableCollection<string> { "Apple", "Banana", "Cherry" };
            var firstItem = Helpers.GetFirst(items);
            MessageBox.Show($"First item: {firstItem}");
            Application.Current.Shutdown(1);

        }
    }
}
