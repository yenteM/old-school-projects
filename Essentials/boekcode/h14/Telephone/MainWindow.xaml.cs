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

namespace Telephone
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string[] names = new string[20];
        private string[] numbers = new string[20];

        public MainWindow()
        {
            InitializeComponent();

            names[0] = "Alex";
            numbers[0] = "2720774";

            names[1] = "Megan";
            numbers[1] = "5678554";

            names[2] = "END";
        }

        private void findButton_Click(object sender, RoutedEventArgs e)
        {
            Find();
        }

        private void Find()
        {
            int index = 0;
            string wanted = nameTextBox.Text;

            while (names[index] != wanted && (names[index] != "END"))
            {
                index++;
            }
            if (names[index] == wanted)
            {
                resultLabel.Content = "Number is " + numbers[index];
            }
            else
            {
                resultLabel.Content = "Name not found";
            }
        }
    }
}
