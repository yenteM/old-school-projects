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

namespace FileOutput
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

        private void writeButton_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter outputStream = File.CreateText(@"C:\myfile.txt");
            outputStream.WriteLine("This file will");
            outputStream.WriteLine("contain 3");
            outputStream.WriteLine("lines of text.");
            outputStream.Close();
        }

        private void myDocButton_Click(object sender, RoutedEventArgs e)
        {
            string destination = Environment.GetFolderPath(
                                    Environment.SpecialFolder.MyDocuments);
            statusLabel.Content = "Writing to: " + destination;

            string newFile = System.IO.Path.Combine(destination, "myfile.txt");
            StreamWriter outputStream = File.CreateText(newFile);
            outputStream.WriteLine("This file will");
            outputStream.WriteLine("contain 3");
            outputStream.WriteLine("lines of text.");
            outputStream.Close();
        }

        private void writeAppButton_Click(object sender, RoutedEventArgs e)
        {
            string destination = Environment.GetFolderPath(
                                    Environment.SpecialFolder.ApplicationData);
            statusLabel.Content = "Writing to: " + destination;

            string newFile = System.IO.Path.Combine(destination, "myfile.txt");
            StreamWriter outputStream = File.CreateText(newFile);
            outputStream.WriteLine("This file will");
            outputStream.WriteLine("contain 3");
            outputStream.WriteLine("lines of text.");
            outputStream.Close();
        }
    }
}
