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

namespace Oef_13._7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<String> monthList = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            monthList.Add("January");
            monthList.Add("Febuary");
            monthList.Add("March");
            monthList.Add("April");
            monthList.Add("May");
            monthList.Add("June");
            monthList.Add("July");
            monthList.Add("August");
            monthList.Add("September");
            monthList.Add("Oktober");
            monthList.Add("November");
            monthList.Add("December");
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            resultTextBlock.Text = monthList[Convert.ToInt32(indexTextBox.Text)-1];
        }
    }
}
