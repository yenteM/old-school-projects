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

namespace Some_Shapes
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
            Rectangle rect1 = new Rectangle();
            rect1.Width = 100;
            rect1.Height = 50;
            rect1.Margin = new Thickness(10, 10, 0, 0);
            rect1.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(rect1);

            Line line1 = new Line();
            line1.X1 = 10; line1.Y1 = 10;
            line1.X2 = 110; line1.Y2 = 60;
            line1.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(line1);

            Rectangle rect2 = new Rectangle();
            rect2.Width = 100;
            rect2.Height = 50;
            rect2.Margin = new Thickness(10, 80, 0, 0);
            rect2.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(rect2);

            Ellipse ellipse1 = new Ellipse();
            ellipse1.Width = 100;
            ellipse1.Height = 50;
            ellipse1.Margin = new Thickness(10, 80, 0, 0);
            ellipse1.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(ellipse1);

            Ellipse ellipse2 = new Ellipse();
            ellipse2.Width = 100;
            ellipse2.Height = 50;
            ellipse2.Margin = new Thickness(10, 150, 0, 0);
            ellipse2.Fill = new SolidColorBrush(Colors.Gray);
            paperCanvas.Children.Add(ellipse2);

            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            //bi.UriSource = new Uri("imagedemo.jpg", UriKind.RelativeOrAbsolute);
            bi.UriSource = new Uri(@"C:\Users\Kris\Pictures\imagedemo.jpg",
                                   UriKind.RelativeOrAbsolute);
            bi.EndInit();
            Image picture = new Image();
            picture.Source = bi;
            picture.Margin = new Thickness(120, 10, 0, 0);
            picture.Width = 150;
            picture.Height = 150;
            paperCanvas.Children.Add(picture);

        }
    }
}
