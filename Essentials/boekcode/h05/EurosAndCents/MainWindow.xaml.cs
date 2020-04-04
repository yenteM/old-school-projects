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

namespace EurosAndCents
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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            int originalCents, wholeEuros, centsLeft;
            originalCents = Convert.ToInt32(amountTextBox.Text);
            EurosAndCents(originalCents, out wholeEuros, out centsLeft);
            eurosTextBlock.Text = Convert.ToString(wholeEuros);
            centsTextBlock.Text = Convert.ToString(centsLeft);
        }

        private void EurosAndCents(int totalCents,
                                   out int euros,
                                   out int centsLeft)
        {
            // int temp = euros; compile error!
            euros = totalCents / 100;
            centsLeft = totalCents % 100;
        }
    }
}
