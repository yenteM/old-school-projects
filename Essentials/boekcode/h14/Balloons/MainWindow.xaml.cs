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

namespace Balloons
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Balloon[] partyList = new Balloon[10];

        public MainWindow()
        {
            InitializeComponent();

            partyList[0] = new Balloon(10, 10, 50);
            partyList[1] = new Balloon(50, 50, 100);
            partyList[2] = new Balloon(100, 100, 200);
        }

        private void drawButton_Click(object sender, RoutedEventArgs e)
        {
            balloonCanvas.Children.Clear();
            for (int index = 0; index < 3; index++)
            {
                partyList[index].DisplayOn(balloonCanvas);
            }
        }

        //private void drawButton_Click(object sender, RoutedEventArgs e)
        //{
        //    balloonCanvas.Children.Clear();
        //    foreach (Balloon balloon in partyList)
        //    {
        //        if (balloon != null)
        //        {
        //            balloon.DisplayOn(balloonCanvas);
        //        }
        //    }
        //}
    }
}
