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
            try
            {
                LoginButton.IsEnabled = false;
                BusyIndicator.Visibility = Visibility.Visible;
                
                string result = await LoginAsync();

                LoginButton.Content = result;
                LoginButton.IsEnabled = true;
                BusyIndicator.Visibility = Visibility.Hidden;
            }
            catch (Exception)
            {
                LoginButton.Content = "Login Failed!";
            }
            
        }

        private async Task<string> LoginAsync()
        {
            try
            { 
                var loginTask = Task.Run(() =>
                {
                    Thread.Sleep(5000);
                    return "Login success";
                });
                
                var logTask = Task.Delay(2000); // log login to DB
                var fetchTask =  Task.Delay(1000); // Fetch purchases

                await Task.WhenAll(loginTask, logTask, fetchTask);

                return loginTask.Result;
            }
            catch (Exception)
            {
                return "Login failed!";
            }
        }
    }
}
