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

namespace MeerdereCatch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            int bottom;
            int top = 100;
            try
            {
                bottom = Int32.Parse(bottomTextBox.Text);
                statusLabel.Content = String.Format("Dividing into 100 gives {0}",
                                                    (top / bottom));
            }
            catch (DivideByZeroException exceptionObject)
            {
                statusLabel.Content = "Error - zero: re-enter data.";
            }
            catch (FormatException exceptionObject)
            {
                statusLabel.Content = "Error in number: re-enter.";
            }
            catch (SystemException exceptionObject)
            {
                MessageBox.Show(exceptionObject.ToString());
            }
        }
    }
}
