using Microsoft.Win32;
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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace H18._8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StreamReader inputStream = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            string startdir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            folder.SelectedPath = startdir;

            if (folder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pathTextBox.Text = folder.SelectedPath;
            }
        }

        private void Searchfiles(string path)
        {
            try
            {
                string[] files = Directory.GetFiles(path, "*.txt");
                char separator = '\\';
                
                foreach (string s in files)
                {

                    inputStream = File.OpenText(s);
                    string line = inputStream.ReadLine();
                    while (line != null)
                    {

                        if (line.Contains(searchTextBox.Text) == true)
                        {
                            string[] pad = s.Split(separator);
                            resultTextBox.AppendText(pad[pad.Length-1] + ": " + line);
                            resultTextBox.AppendText(Environment.NewLine);
                        }
                        line = inputStream.ReadLine();
                    }
                    inputStream.Close();
                }
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show(e.Message);
            }






        }

        private void showButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();
            Searchfiles(pathTextBox.Text);
        }
    }
}
