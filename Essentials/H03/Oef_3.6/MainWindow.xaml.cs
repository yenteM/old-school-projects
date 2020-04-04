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

namespace Oef_3._6
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Ellipse faceEllipse = new Ellipse();
            Ellipse leftEyeBallEllipse = new Ellipse();
            Ellipse leftEyeEllipse = new Ellipse();
            Ellipse rightEyeBallEllipse = new Ellipse();
            Ellipse rightEyeEllipse = new Ellipse();
            Ellipse mouthEllipse = new Ellipse();
            Line noseLine = new Line();
            Line hair1 = new Line();
            Line hair2 = new Line();
            Line hair3 = new Line();



            hair2.X1 = 250;
            hair2.Y1 = 10;
            hair2.X2 = 250;
            hair2.Y2 = 60;
            hair2.Stroke = new SolidColorBrush(Colors.Black);
            faceCanvas.Children.Add(hair2);

            hair1.X1 = 215;
            hair1.Y1 = 10;
            hair1.X2 = 225;
            hair1.Y2 = 68;
            hair1.Stroke = new SolidColorBrush(Colors.Black);
            faceCanvas.Children.Add(hair1);

            hair3.X1 = 285;
            hair3.Y1 = 10;
            hair3.X2 = 275;
            hair3.Y2 = 68;
            hair3.Stroke = new SolidColorBrush(Colors.Black);
            faceCanvas.Children.Add(hair3);

            faceEllipse.Height = 100;
            faceEllipse.Width = 100;
            faceEllipse.Margin = new Thickness(200, 60, 0, 0);
            faceEllipse.Stroke = new SolidColorBrush(Colors.Black);
            faceEllipse.Fill = new SolidColorBrush(Colors.Blue);
            faceCanvas.Children.Add(faceEllipse);

            leftEyeBallEllipse.Height = 23;
            leftEyeBallEllipse.Width = 18;
            leftEyeBallEllipse.Margin = new Thickness(225, 80, 0, 0);
            leftEyeBallEllipse.Stroke = new SolidColorBrush(Colors.Black);
            leftEyeBallEllipse.Fill = new SolidColorBrush(Colors.Red);
            faceCanvas.Children.Add(leftEyeBallEllipse);

            leftEyeEllipse.Height = 15;
            leftEyeEllipse.Width = 9;
            leftEyeEllipse.Margin = new Thickness(226, 82, 0, 0);
            leftEyeEllipse.Stroke = new SolidColorBrush(Colors.Black);
            leftEyeEllipse.Fill = new SolidColorBrush(Colors.Black);
            faceCanvas.Children.Add(leftEyeEllipse);

            rightEyeBallEllipse.Height = 23;
            rightEyeBallEllipse.Width = 18;
            rightEyeBallEllipse.Margin = new Thickness(260, 80, 0, 0);
            rightEyeBallEllipse.Stroke = new SolidColorBrush(Colors.Black);
            rightEyeBallEllipse.Fill = new SolidColorBrush(Colors.Red);
            faceCanvas.Children.Add(rightEyeBallEllipse);

            rightEyeEllipse.Height = 15;
            rightEyeEllipse.Width = 9;
            rightEyeEllipse.Margin = new Thickness(261, 82, 0, 0);
            rightEyeEllipse.Stroke = new SolidColorBrush(Colors.Black);
            rightEyeEllipse.Fill = new SolidColorBrush(Colors.Black);
            faceCanvas.Children.Add(rightEyeEllipse);

            mouthEllipse.Height = 15;
            mouthEllipse.Width = 40;
            mouthEllipse.Margin = new Thickness(230, 120, 0, 0);
            mouthEllipse.Stroke = new SolidColorBrush(Colors.Black);
            mouthEllipse.Fill = new SolidColorBrush(Colors.Black);
            faceCanvas.Children.Add(mouthEllipse);

            noseLine.X1 = 250;
            noseLine.Y1 = 100;
            noseLine.X2 = 250;
            noseLine.Y2 = 110;
            noseLine.Stroke = new SolidColorBrush(Colors.Black);
            faceCanvas.Children.Add(noseLine);
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            cursorBox.Text = Convert.ToString(e.GetPosition(faceCanvas));
        }
    }
}
