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

namespace Boxes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            countSlider.ValueChanged += countSlider_ValueChanged;
        }

        private void countSlider_ValueChanged(object sender,
                                 RoutedPropertyChangedEventArgs<double> e)
        {
            double x;
            int numberOfBoxes, counter;
            SolidColorBrush brush = new SolidColorBrush(Colors.Black);
            
            boxesCanvas.Children.Clear();
            numberOfBoxes = Convert.ToInt32(countSlider.Value);
            x = 5;
            for (counter = 1; counter <= numberOfBoxes; counter++)
            {
                DrawRectangle(boxesCanvas, brush, x, 15, 15, 15);
                x = x + 25;
            }
        }

        private void DrawRectangle(Canvas paperCanvas, SolidColorBrush brush,
                                   double x, double y, int width, int height)
        {
            Rectangle rect = new Rectangle();
            rect.Width = width;
            rect.Height = height;
            rect.Margin = new Thickness(x, y, 0, 0);
            rect.Stroke = brush;
            paperCanvas.Children.Add(rect);
        }
    }
}
