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

namespace Exercise6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            kleurButton.Click += KleurButton_Click;
            versmalButton.Click += VersmalButton_Click;
            verwijderButton.Click += VerwijderButton_Click;
            exitItem.Click += ExitItem_Click;
            aboutItem.Click += AboutItem_Click;
        }

        private void AboutItem_Click(object sender, RoutedEventArgs e)
        {
            statusBar.Text = "created by me.";
        }

        private void ExitItem_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void VerwijderButton_Click(object sender, RoutedEventArgs e)
        {
            linksBoven.Visibility = Visibility.Hidden;
            linksOnder.Visibility = Visibility.Hidden;
            rechtsBoven.Visibility = Visibility.Hidden;
            rechtsOnder.Visibility = Visibility.Hidden;
        }

        private void VersmalButton_Click(object sender, RoutedEventArgs e)
        {
            this.Width -= 20;
            this.Height -= 20;
            statusBar.Text = Convert.ToString(this.Width);
        }

        private void KleurButton_Click(object sender, RoutedEventArgs e)
        {
            linksBoven.Fill = rechtsOnder.Fill;
        }
    }
}
