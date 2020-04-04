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

namespace Guesser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random ageGuesser = new Random();
        private int tries = 0;
        
        public MainWindow()
        {
            InitializeComponent();

            guessLabel.Content = Convert.ToString(ageGuesser.Next(5, 110));
        }

        private void correctButton_Click(object sender, RoutedEventArgs e)
        {
            tries = tries + 1;
            MessageBox.Show("Number of tries was: " + tries);
            tries = 0;
            guessLabel.Content = Convert.ToString(ageGuesser.Next(5, 110));
        }

        private void wrongButton_Click(object sender, RoutedEventArgs e)
        {
            guessLabel.Content = Convert.ToString(ageGuesser.Next(5, 110));
            tries = tries + 1;
        }
    }
}
