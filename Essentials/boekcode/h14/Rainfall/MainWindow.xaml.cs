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
        private int[] rain = { 7, 8, 0, 4, 3, 8, 1 };
        
        public MainWindow()
        {
            InitializeComponent();

            Display();
            Largest();
        }

        private void Display()
        {
            rainfallTextBox.Clear();
            for (int dayNumber = 0; dayNumber < 7; dayNumber++)
            {
                string line = String.Format("day {0} rain {1}",
                                            dayNumber,
                                            rain[dayNumber]);
                rainfallTextBox.AppendText(line);
                rainfallTextBox.AppendText(Environment.NewLine);
            }
        }

        private void NewValue()
        {
            int index = Convert.ToInt32(indexTextBox.Text);
            int data = Convert.ToInt32(valueTextBox.Text);
            rain[index] = data;
            Display();
            Largest();
        }

        private void Largest()
        {
            int highest = rain[0];
            for (int index = 1; index < 7; index++)
            {
                if (highest < rain[index])
                {
                    highest = rain[index];
                }
            }
            largestLabel.Content = "Largest value is " + highest;
        }

        private void changeButton_Click(object sender, RoutedEventArgs e)
        {
            NewValue();
        }

        // Testvraag 14.7:
        //private void WeekTotal()
        //{
        //    int total = 0;
        //    foreach (int rainday in rain)
        //    {
        //        total += rainday;
        //    }
        //    totalLabel.Content = "Week total is: " + total; 
        //}
    }
}
