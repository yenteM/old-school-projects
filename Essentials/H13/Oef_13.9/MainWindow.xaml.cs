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

namespace Oef_13._9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ComboBoxItem red = new ComboBoxItem();
        ComboBoxItem green = new ComboBoxItem();
        ComboBoxItem blue = new ComboBoxItem();
        ComboBoxItem yellow = new ComboBoxItem();
        ComboBoxItem purple = new ComboBoxItem();

        public MainWindow()
        {
            InitializeComponent();
            red.Content = "Red";
            green.Content = "Green";
            blue.Content = "Blue";
            yellow.Content = "Yellow";
            purple.Content = "Purple";
            colorComboBox.Items.Add(red);
            colorComboBox.Items.Add(green);
            colorComboBox.Items.Add(blue);
            colorComboBox.Items.Add(yellow);
            colorComboBox.Items.Add(purple);
            colorComboBox.SelectedIndex = 0;
        }

        private void colorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem hulp = (ComboBoxItem)colorComboBox.SelectedItem;
            Color kleur = (Color)ColorConverter.ConvertFromString(Convert.ToString(hulp.Content));

            colorLabel.Background = new SolidColorBrush(kleur);

        }
    }
}
