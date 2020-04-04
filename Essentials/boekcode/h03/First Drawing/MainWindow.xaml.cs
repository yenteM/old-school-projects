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

namespace First_Drawing
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
            Rectangle rect1 = new Rectangle();
            rect1.Width = 100;
            rect1.Height = 50;
            rect1.Margin = new Thickness(10, 10, 0, 0);
            rect1.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(rect1);

            Rectangle rect2 = new Rectangle();
            rect2.Width = 100;
            rect2.Height = 100;
            rect2.Margin = new Thickness(10, 75, 0, 0);
            rect2.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(rect2);
        }
    }
}
