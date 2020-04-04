using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace MyLogin
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            LoginAsync();
        }

        private async Task LoginAsync()
        {
            var result = await Task.Run(() =>
            {
                Thread.Sleep(5000);
                return "Login succes";
            });
            LoginButton.Content = result;
        }
    }
}
