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

namespace Exercise4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            vergrootButton.Click += VergrootButton_Click;
            verkleinButton.Click += VerkleinButton_Click;
        }

        private void VerkleinButton_Click(object sender, RoutedEventArgs e)
        {
            rapPanel.ItemWidth -= 1;
        }

        private void VergrootButton_Click(object sender, RoutedEventArgs e)
        {
            rapPanel.ItemWidth += 1;
        }
    }
}
