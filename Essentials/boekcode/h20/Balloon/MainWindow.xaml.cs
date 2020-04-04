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

namespace BalloonApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class GUIForm : Window
    {
        private Balloon balloon;
        
        public GUIForm()
        {
            InitializeComponent();

            balloon = new Balloon();
            radiusSlider.Value = balloon.Radius;
            radiusLabel.Content = Convert.ToString(balloon.Radius);
            balloon.DisplayOn(balloonCanvas);
        }

        private void upButton_Click(object sender, RoutedEventArgs e)
        {
            balloon.MoveUp(5);
        }

        private void downButton_Click(object sender, RoutedEventArgs e)
        {
            balloon.MoveDown(5);
        }

        private void radiusSlider_ValueChanged(object sender,
                              RoutedPropertyChangedEventArgs<double> e)
        {
            balloon.Radius = Convert.ToInt32(radiusSlider.Value);
            radiusLabel.Content = Convert.ToString(balloon.Radius);
        }
    }
}
