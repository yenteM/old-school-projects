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

namespace FileInput
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

        private void readButton_Click(object sender, RoutedEventArgs e)
        {
            string sourcepath = Environment.GetFolderPath(
                                   Environment.SpecialFolder.MyDocuments);
            // Use System.IO.Path io Path because of misinterpretation with
            // System.Shapes.Path
            string myfile = System.IO.Path.Combine(sourcepath, "myfile.txt");
            StreamReader inputStream = File.OpenText(myfile);
            string line = inputStream.ReadLine();
            while (line != null)
            {
                fileTextBox.AppendText(line);
                fileTextBox.AppendText(Environment.NewLine);
                line = inputStream.ReadLine();
            }
            inputStream.Close();
        }
    }
}
