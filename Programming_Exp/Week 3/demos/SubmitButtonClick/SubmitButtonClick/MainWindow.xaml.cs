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

namespace SubmitButtonClick
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SubmitButton2.Click += delegate (object sender, RoutedEventArgs e)
            {
                var b = sender as Button;
                MessageBox.Show(String.Format("You clicked {0}", b.Name));
            };

            SubmitButton3.Click += (s, e) =>
            {
                var b = s as Button;
                MessageBox.Show(String.Format("You clicked {0}", b.Name));
            };
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            var b = sender as Button;
            MessageBox.Show(String.Format("You clicked {0}", b.Name));
        }
    }
}
