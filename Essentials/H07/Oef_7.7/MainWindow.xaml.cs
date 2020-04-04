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

namespace Oef_7._7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string screenNumber = "";
        string totalSum = "0";
        string secondsum = "0";
        bool plusOrMinus = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string button = ((Button)sender).Name;


            switch (button)
            {
                case "zeroButton":
                    screenNumber += "0";
                    break;
                case "oneButton":
                    screenNumber += "1";
                    break;
                case "twoButton":
                    screenNumber += "2";
                    break;
                case "threeButton":
                    screenNumber += "3";
                    break;
                case "fourButton":
                    screenNumber += "4";
                    break;
                case "fiveButton":
                    screenNumber += "5";
                    break;
                case "sixButton":
                    screenNumber += "6";
                    break;
                case "sevenButton":
                    screenNumber += "7";
                    break;
                case "eightButton":
                    screenNumber += "8";
                    break;
                case "nineButton":
                    screenNumber += "9";
                    break;
                case "plusButton":
                    plusOrMinus = true;
                    totalSum = "" + (Convert.ToInt32(screenNumber) + Convert.ToInt32(totalSum));
                    screenNumber = totalSum;
                    break;
                case "minusButton":
                    plusOrMinus = false;
                    totalSum = "" + (Convert.ToInt32(screenNumber) - Convert.ToInt32(totalSum));
                    screenNumber = totalSum;
                    break;
                case "equalsButton":
                    if (plusOrMinus == true)
                    {
                        totalSum = "" + Convert.ToInt32(screenNumber) + Convert.ToInt32(totalSum);
                        screenNumber = totalSum;
                    }
                    else
                    {
                        screenNumber = Convert.ToString(Convert.ToInt32(totalSum) - Convert.ToInt32(screenNumber));
                    }

                    break;
                case "clearButton":
                    screenNumber = "";
                    break;
            }

            resultLabel.Content = "";
            resultLabel.Content = screenNumber;

        }
    }
}
