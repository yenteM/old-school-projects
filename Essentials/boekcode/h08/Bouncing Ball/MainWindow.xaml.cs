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

namespace Bouncing_Ball
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ballCanvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            double x, y, diameter;
            int xChange = 10;
            int yChange = 4;

            x = 10;
            y = 10;
            diameter = 15;
            for (int count = 0; count < 200; count++)
            {
                MoveBall(ref x, ref y, ref xChange, ref yChange);
                DrawBall(x, y, diameter);
            }
        }

        private void MoveBall(ref double x, ref double y, ref int xChange, ref int yChange)
        {
            if ((x <= 0) || (x >= ballCanvas.Width))
            {
                xChange = -xChange;
            }
            if ((y <= 0) || (y >= ballCanvas.Height))
            {
                yChange = -yChange;
            }

            x = x + xChange;
            y = y + yChange;
        }

        private void DrawBall(double x, double y, double diameter)
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Stroke = new SolidColorBrush(Colors.Blue);
            ellipse.Width = diameter;
            ellipse.Height = diameter;
            ellipse.Margin = new Thickness(x, y, 0, 0);
            ballCanvas.Children.Add(ellipse);
        }
    }
}
