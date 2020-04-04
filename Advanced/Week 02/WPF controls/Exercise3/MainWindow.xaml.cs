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

namespace Exercise3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Rectangle rect = new Rectangle();
        int margin = 200;

        public MainWindow()
        {
            InitializeComponent();

            
            rect.Width = 100;
            rect.Height = 100;
            rect.Stroke = new SolidColorBrush(Colors.Yellow);
            rect.Fill = new SolidColorBrush(Colors.Yellow);
            rect.Margin = new Thickness(margin, 0,0,0);
            colorCanvas.Children.Add(rect);

            growButton.Click += GrowButton_Click;
            shrinkButton.Click += ShrinkButton_Click;

        }

        private void ShrinkButton_Click(object sender, RoutedEventArgs e)
        {
            colorCanvas.Children.Clear();
            rect.Width = rect.Width - 10;
            margin += 5;
            rect.Margin = new Thickness(margin, 0, 0, 0);
            colorCanvas.Children.Add(rect);
        }

        private void GrowButton_Click(object sender, RoutedEventArgs e)
        {
            colorCanvas.Children.Clear();
            rect.Width = rect.Width + 10;
            margin -= 5;
            rect.Margin = new Thickness(margin, 0, 0, 0);
            colorCanvas.Children.Add(rect);
        }

    }
}
