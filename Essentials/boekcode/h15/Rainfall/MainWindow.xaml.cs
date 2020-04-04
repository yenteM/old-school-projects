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

namespace Rainfall
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[,] rainData = {{10, 7, 3, 28, 5, 6, 3},
                                  {12, 3, 5, 7, 12, 5, 8},
                                  {8, 5, 2, 1, 1, 4, 7}};

        public MainWindow()
        {
            InitializeComponent();
            Display();
        }

        private void changeButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeValue();
        }

        private void ChangeValue()
        {
            int dayNumber = Convert.ToInt32(dayTextBox.Text);
            int location = Convert.ToInt32(locationTextBox.Text);
            int dataValue = Convert.ToInt32(valueTextBox.Text);
            rainData[location, dayNumber] = dataValue;

            Display();
            CalculateTotal();
        }

        private void Display()
        {
            dataTextBox.Clear();
            for (int location = 0; location < 3; location++)
            {
                for (int dayNumber = 0; dayNumber < 7; dayNumber++)
                {
                    string line = String.Format("{0}\t",
                                         rainData[location, dayNumber]);
                    dataTextBox.AppendText(line);
                }
                dataTextBox.AppendText(Environment.NewLine);
            }
        }

        private void CalculateTotal()
        {
            int total = 0;
            //for (int location = 0; location < 3; location++)
            //{
            //    for (int dayNumber = 0; dayNumber < 7; dayNumber++)
            //    {
            //        total += rainData[location, dayNumber];
            //    }
            //}
            foreach (int item in rainData)
            {
                total += item;
            }
            totalLabel.Content = "Total rainfall is " + total;
        }

    }
}
