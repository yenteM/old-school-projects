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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Oef_6._8
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


        private void progressbar_Initialized(object sender, EventArgs e)
        {
            progressbar.Minimum = 0;
            progressbar.Maximum = 100;
            Duration duration = new Duration(TimeSpan.FromSeconds(5));
            DoubleAnimation doubleanimation = new DoubleAnimation(100.0, duration);
            progressbar.BeginAnimation(ProgressBar.ValueProperty, doubleanimation);
        }

        private void progressbar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (progressbar.Value == 100)
            {
                MessageBox.Show("U heeft 5 sec om in te loggen.");
            }
        }
    }
}
