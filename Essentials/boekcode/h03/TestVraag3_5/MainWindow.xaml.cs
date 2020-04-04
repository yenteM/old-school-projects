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

namespace TestVraag3_5
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
            Line l1 = new Line();
            l1.X1 = 0; l1.Y1 = 0;
            l1.X2 = 100; l1.Y2 = 100;
            l1.Stroke = new SolidColorBrush(Colors.Black);

            Line l2 = new Line();
            l2.X1 = 0; l2.Y1 = 100;
            l2.X2 = 100; l2.Y2 = 0;
            l2.Stroke = new SolidColorBrush(Colors.Black);

            paperCanvas.Children.Add(l1);
            paperCanvas.Children.Add(l2);
        }
    }
}
