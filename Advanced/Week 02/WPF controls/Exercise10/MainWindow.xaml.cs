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

namespace Exercise10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LinearGradientBrush grayToBlue;
        LinearGradientBrush greenToPurple;

        public MainWindow()
        {
            InitializeComponent();

            grayToBlue = new LinearGradientBrush(Colors.Gray, Colors.Blue, 0);
            greenToPurple = new LinearGradientBrush(Colors.Green, Colors.Purple, 0);

            


        }
    }
}
