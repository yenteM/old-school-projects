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

namespace TestVragen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int largest;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void largestButton_Click(object sender, RoutedEventArgs e)
        {
            int number = Convert.ToInt32(inputTextBox.Text);
            if (number > largest)
            {
                largest = number;
            }
            resultLabel.Content = "Largest so far is " + largest;
        }

        private double CalcPremium(double age, string gender)
        {
            double premium = 0;

            if (gender == "female")
            {
                if ((age >= 18) && (age <= 30))
                {
                    premium = 5.0;
                }
                else
                {
                    if (age >= 31)
                    {
                        premium = 3.5;
                    }
                    else
                    {
                        premium = 0;
                    }
                }
            }
            else if (gender == "male")
            {
                if ((age >= 18) && (age <= 35))
                {
                    premium = 6.0;
                }
                else
                {
                    if (age >= 36)
                    {
                        premium = 5.5;
                    }
                    else
                    {
                        premium = 0;
                    }
                }
            }
            else
            {
                premium = 0;
            }
            return premium;
        }
    }
}
