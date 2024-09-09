// MainWindow.xaml.cs
using System.Windows;

namespace ProjectApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new ViewModel();
        }
    }
}
