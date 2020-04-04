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

namespace Testvraag8_6_musicsheet
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

        private void drawButton_Click(object sender, RoutedEventArgs e)
        {
            int y = 5;
            SolidColorBrush brush = new SolidColorBrush(Colors.Black);

            barsCanvas.Children.Clear();

            for (int staves = 0; staves < 8; staves++)
            {
                for (int lines = 0; lines < 5; lines++)
                {
                    DrawLine(barsCanvas, brush, 10, y, 180, y);
                    y = y + 4;
                }
                y = y + 10;
            }
        }

        private void DrawLine(Canvas paperCanvas, SolidColorBrush brush,
                              int x1, int y1, int x2, int y2)
        {
            Line line = new Line();
            line.X1 = x1; line.Y1 = y1;
            line.X2 = x2; line.Y2 = y2;
            line.Stroke = brush;
            line.StrokeThickness = 1;
            paperCanvas.Children.Add(line);
        }
    }
}
