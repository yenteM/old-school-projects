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

namespace Exercise2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            LinearGradientBrush linGrBrush = new LinearGradientBrush(Color.FromRgb(0, 255, 0), Color.FromRgb(0, 255, 0), 0);

            helloButton.Background = linGrBrush;
            bigButton.Background = linGrBrush;
        }
    }
}
