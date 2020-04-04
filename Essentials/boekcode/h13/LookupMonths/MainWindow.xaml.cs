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

namespace LookupMonths
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

        private void lookupButton_Click(object sender, RoutedEventArgs e)
        {
            int monthNumber = Convert.ToInt32(monthNumberTextBox.Text);
            ListBoxItem item = (ListBoxItem)monthListBox.Items[monthNumber - 1];
            string monthName = Convert.ToString(item.Content);
            monthNameTextBox.Text = monthName;
        }
    }
}
