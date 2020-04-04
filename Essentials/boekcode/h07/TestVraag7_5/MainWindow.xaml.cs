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

namespace TestVraag7_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int loon = 0;
        private double belasting = 0;
        
        public MainWindow()
        {
            InitializeComponent();
            toonLoon();
            toonBelasting();
            salarySlider.ValueChanged += salarySlider_ValueChanged;
        }

        private void salarySlider_ValueChanged(object sender,
                                 RoutedPropertyChangedEventArgs<double> e)
        {
            toonLoon();
            toonBelasting();
        }

        private void toonLoon()
        {
            loon = Convert.ToInt32(salarySlider.Value);
            loonLabel.Content = String.Format("{0:c}", loon);
        }

        private void toonBelasting()
        {
            if (loon <= 10000)
            {
                belasting = 0;
            }
            if ((loon > 10000) && (loon <= 50000))
            {
                belasting = (loon - 10000) * 0.2;
            }
            if (loon > 50000)
            {
                belasting = 8000 + ((loon - 50000) * 0.9);
            }

            belastingLabel.Content = String.Format("{0:c}", belasting);
        }
    }
}
