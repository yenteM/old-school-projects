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

namespace FirstHello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int count = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void klikButton_Click(object sender, RoutedEventArgs e)
        {
            int mod = count % 2;
            if(mod == 0)
            {
                wesleyLabel.Content = "Varken Wesley";
                wesleyLabel.Background= new SolidColorBrush(Colors.HotPink);
                MessageBox.Show("Dees is saai","Hallo");
            }
            else
            {
                wesleyLabel.Content = "Wesley XAML";
                wesleyLabel.Background = new SolidColorBrush(Colors.White);
            }
            count++;   
        }


    }
}
