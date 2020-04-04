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
            LoginButton.IsEnabled = false;
            var task = Task<string>.Run(() =>
            {              
                Thread.Sleep(5000);
                return "Login succeeded!";
            });

            task.ConfigureAwait(true)
                .GetAwaiter()
                .OnCompleted(() =>
                {
                    LoginButton.Content = task.Result;
                    LoginButton.IsEnabled = true;
                });
        }
    }
}
