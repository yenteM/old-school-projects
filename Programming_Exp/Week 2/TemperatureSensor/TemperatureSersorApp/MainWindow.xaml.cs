using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using TemperatureSersorApp.Views;

namespace TemperatureSersorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            loadControls();
        }

        private void loadControls()
        {
            var textBasedView = new TextBasedView();
            layoutRoot.Children.Add(textBasedView);

            var progressBasedView = new ProgressBasedView();
            layoutRoot.Children.Add(progressBasedView);
        }
    }
}
