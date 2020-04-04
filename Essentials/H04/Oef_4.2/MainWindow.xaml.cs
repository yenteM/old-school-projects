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

namespace Oef_4._2
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
            double straal = Convert.ToDouble(straalTextBox.Text);
            double omtrek = Math.Round(2* Math.PI * straal, 2);
            double oppervlakte = Math.Round(Math.PI * Math.Pow(straal, 2), 2);
            double volume = Math.Round((4 * Math.PI / 3) * Math.Pow(straal, 3), 2);

            omtrekTextBlock.Text = Convert.ToString(omtrek);
            oppervlakteTextBlock.Text = Convert.ToString(oppervlakte);
            volumeTextBlock.Text = Convert.ToString(volume);
 
        }
    }
}
