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

namespace SomEnVerschil
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
            int g1, g2;
            int s, v;

            g1 = Convert.ToInt32(getal1TextBox.Text);
            g2 = Convert.ToInt32(getal2TextBox.Text);

            //s = Som(g1, g2);
            //v = Verschil(g1, g2);

            SomEnVerschil(g1, g2, out s, out v);
            somLabel.Content = Convert.ToString(s);
            verschilLabel.Content = Convert.ToString(v);
        }

        private int Som(int getal1, int getal2)
        {
            return getal1 + getal2;
        }

        private int Verschil(int getal1, int getal2)
        {
            return getal1 - getal2;
        }

        private void SomEnVerschil(int getal1, int getal2, out int som, out int verschil)
        {
            som = getal1 + getal2;
            verschil = getal1 - getal2;
        }

        private void ShowSum(Label display, int a, int b)
        {
            display.Content = Convert.ToString(a + b);
        }
    }
}
