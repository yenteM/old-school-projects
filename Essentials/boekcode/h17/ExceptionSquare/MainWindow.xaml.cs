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

namespace ExceptionSquare
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
            double side;
            try
            {
                side = Double.Parse(sideTextBox.Text);
                statusLabel.Content = String.Format("Area is {0} square units.",
                                                    (side * side));
            }
            catch (FormatException exceptionObject)
            {
                MessageBox.Show(exceptionObject.ToString());
                statusLabel.Content = "Error in side, please re-enter.";
            }
        }

        //private void calculateButton_Click(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        DoCalc();
        //    }
        //    catch (FormatException exceptionObject)
        //    {
        //        statusLabel.Content = "Error in side, please re-enter.";
        //    }
        //}

        //private void DoCalc()
        //{
        //    double side = Double.Parse(sideTextBox.Text);
        //    statusLabel.Content = String.Format("Area is {0} square units.",
        //                                        (side * side));
        //}

    }
}
