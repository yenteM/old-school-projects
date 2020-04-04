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

namespace GraphDrawer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double a, b, c, d;
        private SolidColorBrush brush = new SolidColorBrush(Colors.Black);

        public MainWindow()
        {
            InitializeComponent();
            
            aSlider.ValueChanged += Slider_ValueChanged;
            bSlider.ValueChanged += Slider_ValueChanged;
            cSlider.ValueChanged += Slider_ValueChanged;
            dSlider.ValueChanged += Slider_ValueChanged;
        }

        private void Slider_ValueChanged(object sender,
                    RoutedPropertyChangedEventArgs<double> e)
        {
 	        a = aSlider.Value;
            aTextBlock.Text = String.Format("a = {0:0}", a);
            b = bSlider.Value;
            bTextBlock.Text = String.Format("b = {0:0}", b);
            c = cSlider.Value;
            cTextBlock.Text = String.Format("c = {0:0}", c);
            d = dSlider.Value;
            dTextBlock.Text = String.Format("d = {0:0}", d);
            graphCanvas.Children.Clear();
            Draw();
        }

        private void Draw()
        {
            double x, y, nextX, nextY;
            double xPixel, yPixel, nextXPixel, nextYPixel;

            for (xPixel = 0; xPixel <= graphCanvas.Width; xPixel++)
            {
                x = ScaleX(xPixel);
                y = TheFunction(x);
                yPixel = ScaleY(y);
                nextXPixel = xPixel + 1;
                nextX = ScaleX(nextXPixel);
                nextY = TheFunction(nextX);
                nextYPixel = ScaleY(nextY);
                DrawLine(xPixel, yPixel, nextXPixel, nextYPixel);
            }
        }

        private double TheFunction(double x)
        {
            return a * x * x * x + b * x * x + c * x + d;
        }

        private double ScaleX(double xPixel)
        {
            double xStart = -5;
            double xEnd = 5;
            double xScale = graphCanvas.Width / (xEnd - xStart);
            return (xPixel - (graphCanvas.Width / 2)) / xScale;
        }

        private double ScaleY(double y)
        {
            double yStart = -5;
            double yEnd = 5;
            double yScale = graphCanvas.Height / (yEnd - yStart);
            double pixelCoord = (-y * yScale) +
                                (graphCanvas.Height / 2);
            return pixelCoord;
        }

        private void DrawLine(double x1, double y1,
                              double x2, double y2)
        {
            Line l = new Line();
            l.X1 = x1; l.Y1 = y1;
            l.X2 = x2; l.Y2 = y2;
            l.Stroke = brush;
            graphCanvas.Children.Add(l);
        }
    }
}
