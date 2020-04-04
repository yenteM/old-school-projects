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

namespace Oef_4._9
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

        private void frisdrankButton_Click(object sender, RoutedEventArgs e)
        {
            int amountGiven = Convert.ToInt32(inputBox.Text);
            int itemCost = 45;
            int rest = amountGiven - itemCost;
            int euro, cent50, cent20, cent10 ,cent5 , cent2, cent1;

            euro = rest / 100;
            rest = rest % 100;

            cent50 = rest / 50;
            rest = rest % 50;

            cent20 = rest / 20;
            rest = rest % 20;

            cent10 = rest / 10;
            rest = rest % 10;

            cent5 = rest / 5;
            rest = rest % 5;

            cent2 = rest / 2;
            rest = rest % 2;

            cent1 = rest / 1;
            rest = rest % 1;

            MessageBox.Show("Number of 1 euro coins is " + euro);
            MessageBox.Show("Number of 50 cent coins is " + cent50);
            MessageBox.Show("Number of 20 cent coins is " + cent20);
            MessageBox.Show("Number of 10 cent coins is " + cent10);
            MessageBox.Show("Number of 5 cent coins is " + cent5);
            MessageBox.Show("Number of 2 cent coins is " + cent2);
            MessageBox.Show("Number of 1 cent coins is " + cent1);



        }
    }
}
