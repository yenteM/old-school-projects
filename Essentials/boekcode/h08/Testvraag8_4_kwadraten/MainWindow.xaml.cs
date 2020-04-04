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

namespace Testvraag8_4_kwadraten
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

        private void displayButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();
            for (int getal = 1; getal <= 5; getal++)
            {
                string lijn = String.Format("{0} {1}", getal, getal * getal);
                resultTextBox.AppendText(lijn);
                resultTextBox.AppendText(Environment.NewLine);
            }
        }
    }
}
