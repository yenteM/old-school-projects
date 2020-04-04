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

namespace oef_11._7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        KnipperWekker knipper;
        BeepWekker beep;

        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_tick;
            timer.Start();
            knipper = new KnipperWekker(timeLabel);
            beep = new BeepWekker();
        }

        private void timer_tick(object sender, EventArgs e)
        {
            timeLabel.Content = DateTime.Now.ToString("HH:mm:ss");
            knipper.isTimePassed();
            beep.isTimePassed();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (beepRadioButton.IsChecked == true)
            {
                beep.setTime(alarmTimeTextBox.Text);
                beep.beepTime(Convert.ToInt32(beepTimeTextBox.Text));
            }
            else
            {
                knipper.setTime(alarmTimeTextBox.Text);
                knipper.beepTime(Convert.ToInt32(beepTimeTextBox.Text));
            }

        }
    }
}
