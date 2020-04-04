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
        private List<Balloon> partyList = new List<Balloon>();
        
        public MainWindow()
        {
            InitializeComponent();

            partyList.Add(new Balloon(10, 10, 50));
            partyList.Add(new Balloon(50, 50, 100));
            partyList.Add(new Balloon(100, 100, 200));
        }

        private void drawButton_Click(object sender, RoutedEventArgs e)
        {
            balloonCanvas.Children.Clear();
            foreach (Balloon balloon in partyList)
            {
                balloon.DisplayOn(balloonCanvas);
            }
        }
    }
}
