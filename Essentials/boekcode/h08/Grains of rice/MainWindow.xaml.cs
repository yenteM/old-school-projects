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

namespace Grains_of_rice
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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            int square = 1;
            int rice = 1;
            int total = 1;
            resultTextBox.Clear();
            DisplayCounts(square, rice);

            while (total < 100)
            {
                square = square + 1;
                rice = rice * 2;
                DisplayCounts(square, rice);
                total = total + rice;
            }

            resultTextBox.AppendText(Environment.NewLine +
                "Number of squares to make total of 100 is " + square);
        }

        private void DisplayCounts(int square, int rice)
        {
            string line = String.Format("On square {0} are {1} grains",
                                        square, rice) + Environment.NewLine;
            resultTextBox.AppendText(line);
        }
    }
}
