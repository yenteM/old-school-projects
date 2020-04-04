using RecordNavigator.MusicSalesDataSetTableAdapters;
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

namespace RecordNavigator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// Based on:
    /// http://msdn.microsoft.com/en-us/library/dd547149.aspx
    /// </summary>
    public partial class MainWindow : Window
    {
        CollectionViewSource artistsViewSource;
        ArtistsTableAdapter musicSalesDataSetArtistsTableAdapter;
        MusicSalesDataSet musicSalesDataSet;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Load data into the table Artist.
            // You can modify this code as needed.
            musicSalesDataSet = ((MusicSalesDataSet)
                (this.FindResource("musicSalesDataSet")));
            musicSalesDataSetArtistsTableAdapter = new ArtistsTableAdapter();
            musicSalesDataSetArtistsTableAdapter.Fill(musicSalesDataSet.Artists);
            artistsViewSource = ((CollectionViewSource)
                (this.FindResource("artistsViewSource")));
            artistsViewSource.View.MoveCurrentToFirst();

            updatePositionStatus();
        }

        private void updatePositionStatus()
        {
            positionTextBox.Text =
                String.Format("{0} of {1}",
                              artistsViewSource.View.CurrentPosition + 1,
                              musicSalesDataSet.Artists.Count);
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            if (artistsViewSource.View.CurrentPosition > 0)
            {
                artistsViewSource.View.MoveCurrentToPrevious();
                updatePositionStatus();
            }
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            if (artistsViewSource.View.CurrentPosition < 
                  ((CollectionView)artistsViewSource.View).Count - 1)
            {
                artistsViewSource.View.MoveCurrentToNext();
                updatePositionStatus();
            }
        }

        private void firstButton_Click(object sender, RoutedEventArgs e)
        {
            artistsViewSource.View.MoveCurrentToFirst();
            updatePositionStatus();
        }

        private void lastButton_Click(object sender, RoutedEventArgs e)
        {
            artistsViewSource.View.MoveCurrentToLast();
            updatePositionStatus();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            musicSalesDataSetArtistsTableAdapter.Update(musicSalesDataSet.Artists);
        }   
    }
}
