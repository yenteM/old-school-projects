using MusicStoreData;
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
    /// Interaction logic for UpdatePage.xaml
    /// </summary>
    public partial class UpdatePage : Page
    {
        public UpdatePage()
        {
            InitializeComponent();



        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Album selectedAlbum = ArtistRepository.GetAlbumsById(Convert.ToInt32(albumIdTextBox.Text));
                this.DataContext = selectedAlbum;
                FillGenreComboBox();
                FillArtistComboBox();
                GenreComboBox.SelectedIndex = Convert.ToInt32(selectedAlbum.GenreId) - 1;
                ArtistComboBox.SelectedIndex = Convert.ToInt32(selectedAlbum.ArtistId) - 1;
            }
            catch (Exception)
            {
                MessageBox.Show("The album with id " + albumIdTextBox.Text + " couldn't be found or doens't exist.");
            }
        }

        public void FillGenreComboBox()
        {
            string[] genres = GenreRepository.GetGenres();

            foreach (string s in genres)
            {
                GenreComboBox.Items.Add(s);
            }
            GenreComboBox.Items.RemoveAt(GenreComboBox.Items.Count - 1);
        }

        public void FillArtistComboBox()
        {
            string[] artists = ArtistRepository.GetAllArists();

            foreach (string s in artists)
            {
                ArtistComboBox.Items.Add(s);
            }
            GenreComboBox.Items.RemoveAt(GenreComboBox.Items.Count - 1);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Album album = new Album();
            album.AlbumId = albumIdTextBox.Text;
            album.GenreId = Convert.ToString(GenreComboBox.SelectedIndex);
            album.ArtistId = Convert.ToString(ArtistComboBox.SelectedIndex);
            album.Title = titleTextBox.Text;
            album.Price = priceTextBox.Text;
            album.AlbumArtUrl = artURLTextBox.Text;

            AlbumRepository.UpdateAlbum(album);
        }
    }
}
