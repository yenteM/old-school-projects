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

        private async void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var t = Task<string>.Run(() =>
            {
                Thread.Sleep(5000);
                return "Login success";
            });
            await t;
            LoginButton.Content = t.Result;

            var result = await Task.Run(() =>
            {
                Thread.Sleep(5000);
                return "Login success";
            });
            LoginButton.Content = result;
        }
    }
}
