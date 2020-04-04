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

namespace Oef_7._13
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

        private void berekenButton_Click(object sender, RoutedEventArgs e)
        {
            if (verlaagdCheckBox.IsChecked == true)
            {
                BTWResultLabel.Content = Convert.ToDouble(nettoTextBox.Text) * 0.06;
                totaalResultLabel.Content = Convert.ToDouble(nettoTextBox.Text) * 1.06;
            }
            else
            {
                BTWResultLabel.Content = Convert.ToDouble(nettoTextBox.Text) * 0.21;
                totaalResultLabel.Content = Convert.ToDouble(nettoTextBox.Text) * 1.21;
            }
        }
    }
}
