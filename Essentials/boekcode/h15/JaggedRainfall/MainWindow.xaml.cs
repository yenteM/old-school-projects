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

namespace JaggedRainfall
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[][] rainData;
        
        public MainWindow()
        {
            InitializeComponent();
            // of alternatief
            rainData = new int[3][];
            rainData[0] = new int[3];
            rainData[1] = new int[4];
            rainData[2] = new int[7];

            // of alternatief
            rainData[0] = new int[] { 10, 7, 3 };
            rainData[1] = new int[] { 12, 3, 5, 7 };
            rainData[2] = new int[] { 8, 5, 2, 1, 1, 4, 7 };

            Display();
        }

        private void Display()
        {
            dataTextBox.Clear();
            for (int location = 0; location < rainData.Length; location++)
            {
                for (int dayNumber = 0; dayNumber < rainData[location].Length; dayNumber++)
                {
                    string line = String.Format("{0}\t",
                                         rainData[location][dayNumber]);
                    dataTextBox.AppendText(line);
                }
                dataTextBox.AppendText(Environment.NewLine);
            }
        }

        private void changeButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
