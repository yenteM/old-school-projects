using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Oef_10._9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();

        Wekker wekker = new Wekker();

        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_tick;
            timer.Start();
        }

        private void timer_tick(object sender, EventArgs e)
        {
            timeLabel.Content = DateTime.Now.ToString("HH:mm:ss");
            wekker.isTimePassed();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            wekker.setTime(alarmTimeTextBox.Text);
            wekker.beepTime(Convert.ToInt32(beepTimeTextBox.Text));
        }
    }
}
