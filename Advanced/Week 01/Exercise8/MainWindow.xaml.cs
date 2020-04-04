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

namespace Exercise8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            numberTextBox.KeyUp += NumberTextBox_KeyUp;
            letterTextBox.KeyUp += LetterTextBox_KeyUp;
        }

        private void LetterTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(letterTextBox.Text, "^[a-zA-Z]"))
            {
                letterTextBox.Text = letterTextBox.Text.Remove(letterTextBox.Text.Length - 1);
            }
        }

        private void NumberTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(numberTextBox.Text, "[^0-9]"))
            {
                numberTextBox.Text = numberTextBox.Text.Remove(numberTextBox.Text.Length - 1);
            }

        }


    }
}
