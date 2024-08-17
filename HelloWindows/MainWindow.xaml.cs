// MainWindow.xaml.cs
using System.Windows;

namespace ProjectApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button Clicked!");
        }
    }
}
