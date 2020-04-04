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

namespace Exercise5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            BerekenButton.Click += BerekenButton_Click;
        }

        private void BerekenButton_Click(object sender, RoutedEventArgs e)
        {
            snelheidTextBlock.Text = "Rompsnelheid: " + (Math.Sqrt(Convert.ToDouble(lengthBox.Text))*1.34) + " knopen.";
        }
    }
}
