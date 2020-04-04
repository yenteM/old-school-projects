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

namespace Oef_17._6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private EmailChecker check = new EmailChecker();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void controleerButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (check.CheckAddress(EmailTextBox.Text) == true)
                {
                    MessageBox.Show("correcte email");
                }
            }
            catch (InvalidEmailException exception)
            {
                MessageBox.Show("foutieve email");
            }
            
        }
    }
}
