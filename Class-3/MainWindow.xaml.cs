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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button 1 Clicked!");
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button 2 Clicked!");
        }
    }
}
