using System;
using System.Collections.Generic;
using System.IO;
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

namespace TestVraag18_1_Stars
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

        private void starsButton_Click(object sender, RoutedEventArgs e)
        {
            string fileName = "pattern.txt";
            StreamWriter streamOut = File.CreateText(fileName);
            for (int lines = 1; lines <= 10; lines++)
            {
                for (int stars = 1; stars <= lines; stars++)
                {
                    streamOut.Write("*");
                }
                streamOut.WriteLine();
            }
            streamOut.Close();
        }
    }
}
