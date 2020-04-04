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

namespace Oef_6._3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double getal;
        double totaal = 0;
        double count = 0;
        double gemiddelde;
        Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GenereerButton_Click(object sender, RoutedEventArgs e)
        {
            count++;
            getal = 200 + random.NextDouble()*200;
            totaal = totaal + getal;
            gemiddelde = totaal / count;

            laatsteGetalTextBox.Text = Convert.ToString(Math.Round(getal, 2));
            gemiddeldeTextBox.Text = Convert.ToString(Math.Round(gemiddelde,2));
            somTextBox.Text = Convert.ToString(Math.Round(totaal, 2));

        }
    }
}
