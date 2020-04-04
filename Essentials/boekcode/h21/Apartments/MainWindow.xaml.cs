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

namespace Apartments
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

        private void DrawFlats(int floors, int flats)
        {
            double x, y;

            apartmentsCanvas.Children.Clear();
            SolidColorBrush brush = new SolidColorBrush(Colors.Black);

            y = 5;
            for (int floor = 0; floor < floors; floor++)
            {
                x = 5;
                for (int flat = 0; flat < flats; flat++)
                {
                    DrawRectangle(apartmentsCanvas, brush, x, y, 20, 10);
                    x = x + 25;
                }
                y = y + 20;
            }
        }

        private void DrawFlats2(int floors, int flats)
        {
            double y;

            apartmentsCanvas.Children.Clear();
            SolidColorBrush brush = new SolidColorBrush(Colors.Black);

            y = 5;
            for (int floor = 0; floor < floors; floor++)
            {
                DrawFloor(flats, y, brush);
                y = y + 20;
            }
        }

        private void DrawFloor(int flats, double y, SolidColorBrush brush)
        {
            double x = 5;
            for (int flat = 0; flat < flats; flat++)
            {
                DrawRectangle(apartmentsCanvas, brush, x, y, 20, 10);
                x = x + 25;
            }
        }

        

        private void DrawRectangle(Canvas paperCanvas, SolidColorBrush brush, double x, double y, double width, double height)
        {
            Rectangle rect = new Rectangle();
            rect.Width = width;
            rect.Height = height;
            rect.Margin = new Thickness(x, y, 0, 0);
            rect.Stroke = brush;
            paperCanvas.Children.Add(rect);
        }

        private void apartmentsCanvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            DrawFlats2(7, 8);
        }
    }
}
