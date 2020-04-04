using MusicStoreData;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for SelectPage.xaml
    /// </summary>
    public partial class SelectPage : Page
    {
        public SelectPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.DataContext = ArtistRepository.GetAlbumsById(Convert.ToInt32(albumIdTextBox.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("The album with id " + albumIdTextBox.Text + " couldn't be found or doens't exist.");
            }
        }
    }
}
