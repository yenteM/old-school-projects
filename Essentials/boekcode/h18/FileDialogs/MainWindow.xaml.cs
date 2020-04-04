using Microsoft.Win32;
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

namespace FileDialogs
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

        private void openButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string startdir = Environment.GetFolderPath(
                                 Environment.SpecialFolder.MyPictures);
            openFileDialog.InitialDirectory = startdir;
            openFileDialog.Filter = "Image Files|*.BMP;" +
                                    "*.JPG;*.GIF|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true) // User clicks Open
            {
                MessageBox.Show(openFileDialog.FileName);
            }
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(
                                         Environment.SpecialFolder.MyDocuments);
            if (dialog.ShowDialog() == true) // User clicks Save
            {
                MessageBox.Show(dialog.FileName);
            }
        }
    }
}
