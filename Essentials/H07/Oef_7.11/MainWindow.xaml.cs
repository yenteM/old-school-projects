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

namespace Oef_7._11
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

        private void randomButton1_Click(object sender, RoutedEventArgs e)
        {
            Random random1 = new Random(5000);
            Random randomer1 = new Random();
            for (int i = 0; i < randomer1.Next(1,50); i++)
            {
                randomLabel1.Content = random1.Next();
            }
            
        }

        private void randomButton2_Click(object sender, RoutedEventArgs e)
        {
            Random random2 = new Random(5000);
            Random randomer2 = new Random();
            for (int i = 0; i < randomer2.Next(50, 100); i++)
            {
                randomLabel2.Content = random2.Next();
            }
        }
    }
}
