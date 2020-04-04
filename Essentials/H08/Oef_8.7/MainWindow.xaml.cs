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

namespace Oef_8._7
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

        private void tekenButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 1; i <= Convert.ToInt32(numberTextBox.Text)+1; i++)
            {

                for (int j = 1; j <= Convert.ToInt32(numberTextBox.Text); j++)
                {
                    if (i == 1)
                    {
                        uitkomstTextBox.Text += "" + '\t' + j * i; 
                    } else
                    {
                        int help = i-1;
                        uitkomstTextBox.Text += "" + '\t' + (j * help);
                    }

                }

                if (i <= Convert.ToInt32(numberTextBox.Text))
                {
                    uitkomstTextBox.Text += Environment.NewLine + i;
                }

            }
        }
    }
}
