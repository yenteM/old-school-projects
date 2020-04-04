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

namespace Oef_7._8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        int height = 102;
        Rectangle rect = new Rectangle();
        string button;

        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromMilliseconds(5);
            timer.Tick += timer_Tick;

            
            rect.Width = 50;
            rect.Height = 100;
            rect.Margin = new Thickness(101, height, 0, 0);
            rect.Stroke = new SolidColorBrush(Colors.White);
            elevatorCanvas.Children.Add(rect);
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            if (height < 2)
            {
                height = 2;
                timer.Stop();
            }
            else if (height > 200)
            {
                height = 200;
                timer.Stop();
            }
            else if (height >= 2 && height <= 200)
            {
                switch (button)
                {
                case "upButton":
                    height--;
                    rect.Margin = new Thickness(101, height, 0, 0);
                    break;
                case "downButton":
                    height++;
                    rect.Margin = new Thickness(101, height, 0, 0);
                    break;
                }
            }
        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
            button = ((Button)sender).Name;
        }
    }
}
