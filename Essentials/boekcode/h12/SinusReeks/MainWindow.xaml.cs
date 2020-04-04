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

namespace SinusReeks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            String line = String.Format("{0} en {1}", Sin(14), Math.Sin(14));
            MessageBox.Show(line);
        }

        private double Sin(double x)
        {
            double term, result;

            result = 0.0;
            term = x;
            int n = 1;
            while (Math.Abs(term) >= 0.0001)
            {
                result += term;
                term = -term * x * x / ((n + 1) * (n + 2));
                n += 2;
            }
            return result;
        }
    }
}
