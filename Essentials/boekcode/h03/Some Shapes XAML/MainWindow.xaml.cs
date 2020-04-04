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

namespace Some_Shapes_XAML
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

        private void drawButton_Click(object sender, RoutedEventArgs e)
        {
            rect1.Visibility = Visibility.Visible;
            rect2.Visibility = Visibility.Visible;
            line1.Visibility = Visibility.Visible;
            ellipse1.Visibility = Visibility.Visible;
            ellipse2.Visibility = Visibility.Visible;
            picture.Visibility = Visibility.Visible;
        }
    }
}
