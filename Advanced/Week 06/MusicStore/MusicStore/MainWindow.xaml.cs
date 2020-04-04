using MusicStore.Business;
using MusicStore.Data;
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

namespace MusicStore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly AlbumSummaryByGenre test = new AlbumSummaryByGenre();

        public MainWindow()
        {
            InitializeComponent();

            FillComboBox();
        }

        public void FillComboBox()
        {
            string[] genres = GenreRepository.GetGenres();

            foreach (string s in genres)
            {
                GenreComboBox.Items.Add(s);
            }
            GenreComboBox.Items.RemoveAt(GenreComboBox.Items.Count - 1);
        }

        private void GenreComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            albumDataGrid.ItemsSource = test.GetAlbumSummariesByGenre((GenreComboBox.SelectedIndex + 1));
        }
    }
}
