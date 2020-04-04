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

namespace InterestCalculation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int year = 1;
        private double oldAmount;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void yearButton_Click(object sender, RoutedEventArgs e)
        {
            double rate, newAmount;
            int euros, cents;

            if (year == 1)
            {
                oldAmount = Convert.ToDouble(initialAmountTextBox.Text);
            }

            rate = Convert.ToDouble(rateTextBox.Text);

            newAmount = oldAmount + (oldAmount * rate / 100);

            euros = (int)newAmount;
            cents = (int)Math.Round(100 * (newAmount - euros));
            String line = String.Format("After {0} years the money has become " +
                                        "{1} euros and {2} eurocents.",
                                        year, euros, cents);
            resultTextBox.AppendText(line);
            resultTextBox.AppendText(Environment.NewLine);
            resultTextBox.AppendText(Environment.NewLine);

            oldAmount = newAmount;
            year += 1;
        }
    }
}
