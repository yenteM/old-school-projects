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

namespace Gambling
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random randomNumber = new Random();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void throwButton_Click(object sender, RoutedEventArgs e)
        {
            int die1, die2;

            die1 = randomNumber.Next(1, 7);
            die2 = randomNumber.Next(1, 7);

            valuesLabel.Content = String.Format("The die values are {0} and {1}",
                                             die1, die2);

            if (die1 == die2)
            {
                outcomeLabel.Content = "dice equal - a win";
            }
            else
            {
                outcomeLabel.Content = "dice not equal - lose";
            }
        }
    }
}
