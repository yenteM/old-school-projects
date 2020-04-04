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

namespace FormatDemo
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

        private void intButton_Click(object sender, RoutedEventArgs e)
        {
            int i = Convert.ToInt32(intTextBox.Text);
            resultLabel.Content = "{0:" + formatTextBox.Text + "} wordt " +
                               String.Format("{0:" + formatTextBox.Text + "}", i);
        }

        private void doubleButton_Click(object sender, RoutedEventArgs e)
        {
            double d = Convert.ToDouble(doubleTextBox.Text);
            resultLabel.Content = "{0:" + formatTextBox.Text + "} wordt " +
                               String.Format("{0:" + formatTextBox.Text + "}", d);
        }
    }
}
