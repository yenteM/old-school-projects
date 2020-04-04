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

namespace String_Examples
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

        private void executeButton_Click(object sender, RoutedEventArgs e)
        {
            string string1 = string1TextBox.Text;
            string string2 = string2TextBox.Text;
            int m, n;

            // place example code here
            string resultString = "";
            string[] words;
            char[] separators = { ',' };
            words = string1.Split(separators);
            for (int place = 0; place < words.Length; place++)
            {
                resultString += "[" + words[place].Trim() + "] ";
            }

            resultLabel.Content = resultString;
        }
    }
}
