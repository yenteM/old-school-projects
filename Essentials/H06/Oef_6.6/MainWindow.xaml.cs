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

namespace Oef_6._6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        int count = 0;
        SolidColorBrush zwart = new SolidColorBrush(Colors.Black);
        Rectangle secondenRechthoek;
        Rectangle minutenRechthoek;

        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromMilliseconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
            secondenRechthoek = DrawRectangle(75, (count % 60) * 10, 75, zwart, zwart, uurCanvas);
            minutenRechthoek = DrawRectangle(75, (count / 60) * 10, 225, zwart, zwart, uurCanvas);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            count++;

            secondenRechthoek.Width = (count % 60) * 10;
            minutenRechthoek.Width = (count % 3600 / 60) * 10;
        }

        private Rectangle DrawRectangle(int heigt, int width, int xPos, SolidColorBrush color, SolidColorBrush fillColor, Canvas drawingArea)
        {
            Rectangle rechthoek = new Rectangle();
            rechthoek.Height = heigt;
            rechthoek.Width = width;
            rechthoek.Margin = new Thickness(0, xPos, 0, 0);
            rechthoek.Stroke = color;
            rechthoek.Fill = fillColor;
            drawingArea.Children.Add(rechthoek);
            return rechthoek;
        }

    }
}
