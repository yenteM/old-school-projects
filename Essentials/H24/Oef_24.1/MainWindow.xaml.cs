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

namespace Oef_24._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Slang slang = new Slang();
        Koe koe = new Koe();


        public MainWindow()
        {
            InitializeComponent();
            slang.Gewicht = 2;
            koe.Gewicht = 500;

            //MessageBox.Show(slang.ToString());
            //MessageBox.Show(koe.ToString());

            MessageBox.Show(slang.ToString());
            MessageBox.Show(koe.ToString());
        }
    }
}
