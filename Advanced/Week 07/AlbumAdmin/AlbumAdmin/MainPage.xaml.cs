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

namespace AlbumAdmin
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Show_All_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ShowAllPage());
        }

        private void Select_Album_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SelectPage());
        }

        private void Update_Album_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UpdatePage());
        }
    }
}
