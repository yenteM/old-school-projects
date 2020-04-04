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

namespace Oef_8._4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int xpos = -60;
        private int ypos = 10;
        private SolidColorBrush color = new SolidColorBrush(Colors.Black);

        public MainWindow()
        {
            InitializeComponent();

            for (int i = 1; i < 8; i++)
            {
                ypos = 10;
                xpos += 35;
                for (int j = 1; j < i; j++)
                {
                    DrawRectangle(25, 25, xpos, ypos, color, trapCanvas);
                    ypos += 35;
                }
            }
        }

        private void DrawRectangle(int heigt, int width, int xPos, int yPos, SolidColorBrush color, Canvas drawingArea)
        {
            Rectangle rechthoek = new Rectangle();
            rechthoek.Height = heigt;
            rechthoek.Width = width;
            rechthoek.Margin = new Thickness(yPos, xPos, 0, 0);
            rechthoek.Stroke = color;
            drawingArea.Children.Add(rechthoek);
        }
    }
}
