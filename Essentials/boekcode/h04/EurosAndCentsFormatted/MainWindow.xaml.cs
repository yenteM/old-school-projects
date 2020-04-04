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

namespace EurosAndCentsFormatted
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
            int cents;
            cents = Convert.ToInt32(amountTextBox.Text);

            int euros = cents / 100;
            cents = cents % 100;

            resultsLabel.Content = String.Format("{0} euros and {1} cents",
                                                 euros, cents); 
            //resultsLabel.Content = String.Format("{0,15} euros and {1,-15} cents",
            //                                     euros, cents);

            double eurosCurrency = (double)cents / 100;
            //resultsLabel.Content = String.Format("{0:c}", eurosCurrency);
            //resultsLabel.Content = String.Format("{0:d}", eurosCurrency);
            //resultsLabel.Content = String.Format("{0:0.00}", 12.345);
        }
    }
}
