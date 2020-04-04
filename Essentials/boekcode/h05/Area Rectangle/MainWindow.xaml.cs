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

namespace Area_Rectangle
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int a;
            a = AreaRectangle(10, 20);
        }

        private int AreaRectangle(int length, int width)
        {
            int area;
            area = length * width;
            return area;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int n;
            n = AreaRectangle(10, 20);
            MessageBox.Show("Area is " + AreaRectangle(3, 4));
            n = AreaRectangle(10, 20) * AreaRectangle(7, 8);
        }

        private int AreaRectangle2(int length, int width)
        {
            return length * width;
        }
    }
}
