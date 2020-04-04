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

namespace Oef_5._6
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
            DrawStreet(60,20);
        }

        private void DrawStreet(double xPlace, double yPlace)
        {
            DrawHouse(xPlace, yPlace);
            DrawHouse(xPlace + 120, yPlace);
            DrawHouse(xPlace + 240, yPlace);
            DrawHouse(xPlace + 360, yPlace);
            DrawLine(logoCanvas, new SolidColorBrush(Colors.White), 0, 140, 556, 140);
            DrawLine(logoCanvas, new SolidColorBrush(Colors.White), 0, 150, 556, 150);
            DrawLine(logoCanvas, new SolidColorBrush(Colors.White), 0, 155, 556, 155);
            DrawLine(logoCanvas, new SolidColorBrush(Colors.White), 0, 255, 556, 255);
            for (int i = 0; i < 550; i+=100)
            {
                DrawLine(logoCanvas, new SolidColorBrush(Colors.White), i, 205, i+50, 205);
            }
            Rectangle rectangle = new Rectangle();
            rectangle.Height = 8;
            rectangle.Width = 556;
            rectangle.Margin = new Thickness(0, 141, 0, 0);
            rectangle.Stroke = new SolidColorBrush(Colors.Red);
            rectangle.Fill = new SolidColorBrush(Colors.Red);
            logoCanvas.Children.Add(rectangle);
        }

        private void DrawHouse(double xPlace, Double yPlace)
        {
            DrawLogo(logoCanvas, new SolidColorBrush(Colors.Black), xPlace-30, yPlace+50);
            DrawTriangle2(logoCanvas, new SolidColorBrush(Colors.Black), xPlace, yPlace, 50, 50);
            DrawTriangle(logoCanvas, new SolidColorBrush(Colors.Black), xPlace, yPlace, 50, 50);
        }

        private void DrawLogo(Canvas DrawingArea, SolidColorBrush brushToUse, double xPlace, double yPlace)
        {
            DrawRectangle(DrawingArea, brushToUse, xPlace, yPlace, 60);
            DrawRectangle(DrawingArea, brushToUse, xPlace, yPlace, 40);
            DrawRectangle(DrawingArea, brushToUse, xPlace, yPlace, 20);
        }

        private void DrawRectangle(Canvas DrawingArea, SolidColorBrush brushToUse, double xPlace, double yPlace, double size)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Height = size;
            rectangle.Width = size;
            rectangle.Margin = new Thickness(xPlace, yPlace, 0, 0);
            rectangle.Stroke = brushToUse;
            DrawingArea.Children.Add(rectangle);
        }

        private void DrawTriangle(Canvas drawingArea, SolidColorBrush brushToUse, double xPlace, double yPlace, double width, double height)
        {
            double rightCornerX, rightCornerY;
            rightCornerX = xPlace - width;
            rightCornerY = yPlace + height;
            DrawLine(drawingArea, brushToUse, xPlace, yPlace, xPlace, rightCornerY);
            DrawLine(drawingArea, brushToUse, xPlace, rightCornerY, rightCornerX, rightCornerY);
            DrawLine(drawingArea, brushToUse, xPlace, yPlace, rightCornerX, rightCornerY);
        }

        private void DrawTriangle2(Canvas drawingArea, SolidColorBrush brushToUse, double xPlace, double yPlace, double width, double height)
        {
            double rightCornerX, rightCornerY;
            rightCornerX = xPlace + width;
            rightCornerY = yPlace + height;
            DrawLine(drawingArea, brushToUse, xPlace, yPlace, xPlace, rightCornerY);
            DrawLine(drawingArea, brushToUse, xPlace, rightCornerY, rightCornerX, rightCornerY);
            DrawLine(drawingArea, brushToUse, xPlace, yPlace, rightCornerX, rightCornerY);
        }

        private void DrawLine(Canvas drawingArea, SolidColorBrush brushToUse, double xPlace1, double yPlace, double xPlace2, double rightCornerY)
        {
            Line lijn = new Line();
            lijn.X1 = xPlace1;
            lijn.Y1 = yPlace;
            lijn.X2 = xPlace2;
            lijn.Y2 = rightCornerY;
            lijn.Stroke = brushToUse;
            drawingArea.Children.Add(lijn);
        }


    }
}
