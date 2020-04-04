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

namespace WordToNumber
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
            try
            {
                MessageBox.Show(Convert.ToString(WordToNumber("hXndred")));
            }
            catch (FormatException exceptionObject)
            {
                MessageBox.Show(exceptionObject.Message);
            }
        }

        private int WordToNumber(string word)
        {
            int result = 0;
            if (word == "ten")
            {
                result = 10;
            }
            else if (word == "hundred")
            {
                result = 100;
            }
            else if (word == "thousand")
            {
                result = 1000;
            }
            else
            {
                throw new FormatException("Wrong input: " + word);
            }
            return result;
        }
    }
}
