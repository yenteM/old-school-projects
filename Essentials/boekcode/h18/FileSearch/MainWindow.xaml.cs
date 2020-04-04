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

namespace FileSearch
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

        //private void searchButton_Click(object sender, RoutedEventArgs e)
        //{
        //    string sourcepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        //    string line = "";
        //    string[] words = new string[3];
        //    bool found = false;
        //    StreamReader inputStream = null;

        //    // clear any previous results
        //    result1Label.Content = "";
        //    result2Label.Content = "";

        //    if (fileTextBox.Text == "")
        //    {
        //        MessageBox.Show("Error: missing file name!");
        //    }
        //    else if (nameTextBox.Text == "")
        //    {
        //        MessageBox.Show("Error: missing student name!");
        //    }
        //    else
        //    {
        //        string fileToSearch = System.IO.Path.Combine(sourcepath,
        //                                                     fileTextBox.Text);
        //        inputStream = File.OpenText(fileToSearch);
        //        char separator = ',';
        //        line = inputStream.ReadLine();
        //        while ((line != null) && (!found))
        //        {
        //            words = line.Split(separator);
        //            if (words[0].Trim() == nameTextBox.Text)
        //            {
        //                result1Label.Content = words[1].Trim();
        //                result2Label.Content = words[2].Trim();
        //                found = true;
        //            }
        //            else
        //            {
        //                line = inputStream.ReadLine();
        //            }
        //        }
        //        if (!found)
        //        {
        //            MessageBox.Show(nameTextBox.Text + " not found!");
        //        }
        //        inputStream.Close();
        //    }
        //}

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            // search the file with exception handling

            string sourcepath = Environment.GetFolderPath(
                                    Environment.SpecialFolder.MyDocuments);

            string line = "";
            string[] words = new string[3];
            bool found = false;
            StreamReader inputStream = null;

            // clear any previous results
            result1Label.Content = "";
            result2Label.Content = "";

            if (fileTextBox.Text == "")
            {
                MessageBox.Show("Error: missing file name!");
            }
            else if (nameTextBox.Text == "")
            {
                MessageBox.Show("Error: missing student name!");
            }
            else
            {
                try
                {
                    string fileToSearch = System.IO.Path.Combine(sourcepath,
                                                                 fileTextBox.Text);
                    inputStream = File.OpenText(fileToSearch);
                    char separator = ',';
                    line = inputStream.ReadLine();
                    while ((line != null) && (!found))
                    {
                        words = line.Split(separator);
                        if (words[0].Trim() == nameTextBox.Text)
                        {
                            result1Label.Content = words[1].Trim();
                            result2Label.Content = words[2].Trim();
                            found = true;
                        }
                        else
                        {
                            line = inputStream.ReadLine();
                        }
                    }
                    if (!found)
                    {
                        MessageBox.Show(nameTextBox.Text + " not found!");
                    }
                    inputStream.Close();
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show("Error: File not found: " +
                                    fileTextBox.Text +
                                    ". Re-enter name.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error concerning file: " +
                                     fileTextBox.Text +
                                     ". " + ex.Message);
                }
            }
        }

        //private void searchButton_Click(object sender, RoutedEventArgs e)
        //{
        //    // search the file with exception handling

        //    string sourcepath = Environment.GetFolderPath(
        //                            Environment.SpecialFolder.MyDocuments);

        //    string line = "";
        //    string[] words = new string[3];
        //    bool found = false;
        //    StreamReader inputStream = null;

        //    // clear any previous results
        //    result1Label.Content = "";
        //    result2Label.Content = "";

        //    if (fileTextBox.Text == "")
        //    {
        //        MessageBox.Show("Error: missing file name!");
        //    }
        //    else if (nameTextBox.Text == "")
        //    {
        //        MessageBox.Show("Error: missing student name!");
        //    }
        //    else
        //    {
        //        try
        //        {
        //            string fileToSearch = System.IO.Path.Combine(sourcepath,
        //                                                         fileTextBox.Text);
        //            inputStream = File.OpenText(fileToSearch);
        //            char separator = ',';

        //            line = inputStream.ReadLine();
        //            while ((line != null) && (!found))
        //            {
        //                words = line.Split(separator);
        //                if (words[0].Trim() == nameTextBox.Text)
        //                {
        //                    result1Label.Content = words[1].Trim();
        //                    result2Label.Content = words[2].Trim();
        //                    found = true;
        //                }
        //                else
        //                {
        //                    line = inputStream.ReadLine();
        //                }
        //            }
        //            if (!found)
        //            {
        //                MessageBox.Show(nameTextBox.Text + " not found!");
        //            }
        //        }
        //        catch (FileNotFoundException ex)
        //        {
        //            MessageBox.Show("Error: File not found: " +
        //                            fileTextBox.Text +
        //                            ". Re-enter name.");
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error concerning file: " +
        //                             fileTextBox.Text +
        //                             ". " + ex.Message);
        //        }
        //        finally
        //        {
        //            if (inputStream != null)
        //            {
        //                inputStream.Close();
        //            }
        //        }
        //    }
        //}
    }
}
