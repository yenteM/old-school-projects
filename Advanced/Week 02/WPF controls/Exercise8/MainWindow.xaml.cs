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

namespace Exercise8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            gewichtTextBlock.Text = "Gewicht(kg): " + gewichtSlider.Value.ToString();
            lengteTextBlock.Text = "lengte(cm): " + lengteSlider.Value.ToString();

            gewichtSlider.ValueChanged += Slider_ValueChanged;
            lengteSlider.ValueChanged += Slider_ValueChanged;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double BMI = Math.Round((gewichtSlider.Value / ((lengteSlider.Value/100) * (lengteSlider.Value / 100))), 2);
            gewichtTextBlock.Text = "Gewicht(kg): " + gewichtSlider.Value.ToString();
            lengteTextBlock.Text = "lengte(cm): " + lengteSlider.Value.ToString();
            bmiTextBlock.Text = "BMI: " + BMI;

            if (BMI < 18.5)
            {
                klasseTextBlock.Text = "ONDERGEWICHT";
                klasseTextBlock.Background = new SolidColorBrush(Colors.Orange);
            }
            else if (BMI >= 18.5 && BMI < 25)
            {
                klasseTextBlock.Text = "NORMAAL GEWICHT";
                klasseTextBlock.Background = new SolidColorBrush(Colors.Green);
            }
            else if (BMI >= 25 && BMI < 30)
            {
                klasseTextBlock.Text = "OVERGEWICHT";
                klasseTextBlock.Background = new SolidColorBrush(Colors.Orange);
            }
            else
            {
                klasseTextBlock.Text = "OBESITAS";
                klasseTextBlock.Background = new SolidColorBrush(Colors.Red);
            }


        }
    }
}
