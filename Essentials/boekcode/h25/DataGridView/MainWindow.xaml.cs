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
using DataGridView.MusicSalesDataSetTableAdapters;

namespace DataGridView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MusicSalesDataSet musicSalesDataSet;
        private ArtistsTableAdapter artistsTableAdapter;
        private CollectionViewSource artistsViewSource;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            musicSalesDataSet =
                ((DataGridView.MusicSalesDataSet)(this.FindResource("musicSalesDataSet")));
            // Load data into the table Artists. You can modify this code as needed.
            artistsTableAdapter = new ArtistsTableAdapter();
            artistsTableAdapter.Fill(musicSalesDataSet.Artists);
            artistsViewSource = ((CollectionViewSource)(this.FindResource("artistsViewSource")));
            artistsViewSource.View.MoveCurrentToFirst();
        }

        private void highSalesButton_Click(object sender, RoutedEventArgs e)
        {
            decimal minsales = Convert.ToDecimal(salesAboveTextBox.Text);
            artistsTableAdapter.FillBySales(musicSalesDataSet.Artists, minsales);
        }

    }
}
