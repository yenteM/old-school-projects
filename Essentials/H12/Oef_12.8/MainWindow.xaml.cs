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

namespace Oef_12._8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double s, a, b, c, area;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void berekenButton_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(zijde1TextBox.Text);
            b = Convert.ToDouble(zijde2TextBox.Text);
            c = Convert.ToDouble(zijde3TextBox.Text);
            s = (a + b + c) / 2;
            area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            if (Controleergetallen(Convert.ToDouble(zijde1TextBox.Text), Convert.ToDouble(zijde2TextBox.Text), Convert.ToDouble(zijde3TextBox.Text)) == true)
            {
                resultLabel.Content = Math.Round(area, 2);
            } else
            {
                resultLabel.Content = "Foutieve ingave";
            }

        }

        public bool Controleergetallen(double a, double b, double c)
        {
            if ((a + b) > c && (a + c) > b && (b + c) > a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
