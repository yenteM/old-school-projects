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
using System.Windows.Threading;

namespace CannonBall
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private DispatcherTimer timer = new DispatcherTimer();
        private DispatcherTimer shootTimer = new DispatcherTimer();
        private World world = new World();
        private DateTime start, now;
        private double totalseconds;
        private double radialen;
        private Ellipse circle;



        public MainWindow()
        {
            InitializeComponent();

            selectedSpeedLabel.Content = Convert.ToString(speedSlider.Value);
            selectedAngleLabel.Content = Convert.ToString(angleSlider.Value);

            for (int i = 10; i < canonCanvas.Width; i += 10)
            {
                DrawLine(canonCanvas, new SolidColorBrush(Colors.Black), i, canonCanvas.Height - 10, canonCanvas.Height);
            }

            shootTimer.Interval = TimeSpan.FromMilliseconds(1);
            shootTimer.Tick += shootTimer_Tick;

            world.Distance = canonCanvas.Width;
            world.Height = canonCanvas.Height;

            actualHeightLabel.Content = 8;
            actualDistanceLabel.Content = 0;
            circle = DrawCircle(new SolidColorBrush(Colors.Red), 0, 8);
            canonCanvas.Children.Add(circle);
        }


        private void shootTimer_Tick(object sender, EventArgs e)
        {
            string actualHeight = Convert.ToString(actualHeightLabel.Content);
            string actualDistance = Convert.ToString(actualDistanceLabel.Content);
            now = DateTime.Now;
            totalseconds = (now - start).TotalSeconds;
            actualDistanceLabel.Content = Math.Round(Convert.ToDouble(selectedSpeedLabel.Content) * Math.Cos(radialen) * totalseconds, 2);
            actualHeightLabel.Content = Math.Round(Convert.ToDouble(selectedSpeedLabel.Content) * Math.Sin(radialen) * totalseconds - (0.5 * 9.81) * Math.Pow(totalseconds, 2), 2);
            if (Convert.ToDouble(actualHeight) < 0)
            {
                actualHeightLabel.Content = 0;
                timer.Stop();
                shootTimer.Stop();
                angleSlider.IsEnabled = true;
                speedSlider.IsEnabled = true;
            } 
            else if (Convert.ToDouble(actualDistance) > 600)
            {
                actualDistanceLabel.Content = 600;
                timer.Stop();
                shootTimer.Stop();
                angleSlider.IsEnabled = true;
                speedSlider.IsEnabled = true;
            }
            UpdateCircle(circle);
            ClearCanonball();
            if (Convert.ToDouble(actualHeightLabel.Content) < 240)
            {
                canonCanvas.Children.Add(circle);                
            }

        }


        private Ellipse DrawCircle(SolidColorBrush brushToUse, double xPlace, double yPlace)
        {
            Ellipse circle = new Ellipse();
            circle.Height = 10;
            circle.Width = 10;
            circle.Margin = new Thickness(xPlace, world.ConvertyPos(yPlace), 0, 0);
            circle.Stroke = brushToUse;
            circle.Fill = brushToUse;

            return circle;
        }


        private void DrawLine(Canvas drawingArea, SolidColorBrush brushToUse, double xPlace, double yPlace, double yPlace2)
        {
            Line lijn = new Line();
            lijn.X1 = xPlace;
            lijn.Y1 = yPlace;
            lijn.X2 = xPlace;
            lijn.Y2 = yPlace2;
            lijn.Stroke = brushToUse;
            drawingArea.Children.Add(lijn);
        }


        private void speedSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int speed = Convert.ToInt32(speedSlider.Value);
            selectedSpeedLabel.Content = Convert.ToString(speed);
        }


        private void angleSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int angle = Convert.ToInt32(angleSlider.Value);
            selectedAngleLabel.Content = Convert.ToString(angle);
        }


        private void shootButton_Click(object sender, RoutedEventArgs e)
        {
            start = DateTime.Now;
            shootTimer.Start();
            angleSlider.IsEnabled = false;
            speedSlider.IsEnabled = false;
            radialen = Convert.ToDouble(selectedAngleLabel.Content) * Math.PI / 180;
        }


        private void UpdateCircle(Ellipse update)
        {
            if (Convert.ToDouble(actualHeightLabel.Content) < 240)
            {
                update.Margin = new Thickness(Convert.ToDouble(actualDistanceLabel.Content), world.ConvertyPos(Convert.ToDouble(actualHeightLabel.Content)), 0, 0);
            }
        }


        private void ClearCanonball()
        {
            var canonBall = canonCanvas.Children.OfType<Ellipse>().ToList();
            foreach (var circle in canonBall)
            {
                canonCanvas.Children.Remove(circle);
            }
        }

    }
}
