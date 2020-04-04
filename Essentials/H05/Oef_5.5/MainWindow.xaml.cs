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

namespace Oef_5._5
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

        private void drawPolygonButton_Click(object sender, RoutedEventArgs e)
        {
            DrawTriangle2(polygonCanvas, new SolidColorBrush(Colors.Black), 10, 10, 50, 50);
        }

        private void DrawTriangle2(Canvas drawingArea, SolidColorBrush brushToUse, double xPlace, double yPlace, double width, double height)
        {
            Polygon triangle = new Polygon();
            triangle.Stroke = brushToUse;
            triangle.Fill = new SolidColorBrush(Colors.SeaGreen);
            triangle.StrokeThickness = 2;
            System.Windows.Point Point1 = new System.Windows.Point(xPlace, yPlace);
            System.Windows.Point Point2 = new System.Windows.Point(xPlace+width, yPlace+height);
            System.Windows.Point Point3 = new System.Windows.Point(xPlace, yPlace+height);
            PointCollection myPointCollection = new PointCollection();
            myPointCollection.Add(Point1);
            myPointCollection.Add(Point2);
            myPointCollection.Add(Point3);
            triangle.Points = myPointCollection;
            drawingArea.Children.Add(triangle);



        }

    }
}
