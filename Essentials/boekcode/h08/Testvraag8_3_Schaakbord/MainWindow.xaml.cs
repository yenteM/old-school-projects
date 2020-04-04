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

namespace Testvraag8_3_Schaakbord
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
            int x, y;
            SolidColorBrush brush = new SolidColorBrush(Colors.Black);

            chessCanvas.Children.Clear();

            x = 5;
            y = 5;

            for (int counter = 0; counter < 9; counter++)
            {
                DrawLine(chessCanvas, brush, x, 5, x, 165);
                DrawLine(chessCanvas, brush, 5, y, 165, y);
                x += 20;
                y += 20;
            }
        }

        private void DrawLine(Canvas paperCanvas, SolidColorBrush brush,
                              int x1, int y1, int x2, int y2)
        {
            Line line = new Line();
            line.X1 = x1; line.Y1 = y1;
            line.X2 = x2; line.Y2 = y2;
            line.Stroke = brush;
            line.StrokeThickness = 3;
            paperCanvas.Children.Add(line);
        }
    }
}
