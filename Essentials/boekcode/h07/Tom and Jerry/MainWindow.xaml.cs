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

namespace Tom_and_Jerry
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Rectangle tomRectangle;
        private Rectangle jerryRectangle;

        public MainWindow()
        {
            InitializeComponent();

            CreateRectangles();

            tomSlider.ValueChanged += SliderCompare;
            jerrySlider.ValueChanged += SliderCompare;
        }

        private void SliderCompare(object sender,
                           RoutedPropertyChangedEventArgs<double> e)
        {
            tomRectangle.Width = tomSlider.Value;
            jerryRectangle.Width = jerrySlider.Value;

            if (tomSlider.Value > jerrySlider.Value)
            {
                messageLabel.Content = "Tom is bigger";
            }
            else
            {
                messageLabel.Content = "Jerry is bigger";
            }
        }

        private void CreateRectangles()
        {
            tomRectangle = new Rectangle();
            jerryRectangle = new Rectangle();

            SolidColorBrush tbrush = new SolidColorBrush(Colors.Blue);
            SolidColorBrush jbrush = new SolidColorBrush(Colors.Red);

            tomRectangle.Fill = tbrush;
            tomRectangle.Margin = new Thickness(10, 10, 0, 0);
            tomRectangle.Height = 30;

            jerryRectangle.Fill = jbrush;
            jerryRectangle.Margin = new Thickness(10, 90, 0, 0);
            jerryRectangle.Height = 30;

            paperCanvas.Children.Add(tomRectangle);
            paperCanvas.Children.Add(jerryRectangle);
        }
    }
}
