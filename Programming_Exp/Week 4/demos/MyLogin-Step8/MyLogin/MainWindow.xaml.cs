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
            try
            {
                LoginAsync();
            }
            catch (Exception)
            {
                // does not get hit!!
            }
            
        }

        private async void LoginAsync()
        {
            //throw new UnauthorizedAccessException();
            var result = await Task.Run(() =>
            {
                //throw new UnauthorizedAccessException();
                Thread.Sleep(5000);
                return "Login success";
            });
            LoginButton.Content = result;
        }
    }
}
