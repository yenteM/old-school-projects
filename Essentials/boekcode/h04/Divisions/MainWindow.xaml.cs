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

namespace Divisions
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

        private void convertButton_Click(object sender, RoutedEventArgs e)
        {
            // double divisions
            double d;
            //output("d = " + d); // geeft compilerfout omdat d unassigned is
            d = 7.61 / 2.1;
            output("d = " + d);
            d = 10.6 / 2;
            output("d = " + d);

            // integer divisions
            int i;
            i = 10 / 5;
            output("i = " + i);
            i = 13 / 5;
            output("i = " + i);
            i = 33 / 44;
            output("i = " + i);

            d = 14.9 % 3.9;
            output("d = " + d);
        }

        private void output(string message)
        {
            MessageBox.Show(message);
        }
    }
}
