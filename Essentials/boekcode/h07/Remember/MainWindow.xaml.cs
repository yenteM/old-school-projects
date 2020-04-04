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

namespace Remember
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool filled;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void fillButton_Click(object sender, RoutedEventArgs e)
        {
            filled = true;
        }

        private void unFillButton_Click(object sender, RoutedEventArgs e)
        {
            filled = false;
        }

        private void drawButton_Click(object sender, RoutedEventArgs e)
        {
            // remove any previous shapes
            paperCanvas.Children.Clear();

            SolidColorBrush brush = new SolidColorBrush(Colors.Blue);
            Rectangle rect = new Rectangle();
            rect.Width = 100;
            rect.Height = 100;
            rect.Margin = new Thickness(10, 10, 0, 0);
            rect.Stroke = brush;
            if (filled)
            {
                rect.Fill = brush;
            }
            else
            {
                rect.Fill = null;
            }
            paperCanvas.Children.Add(rect);
        }
    }
}
