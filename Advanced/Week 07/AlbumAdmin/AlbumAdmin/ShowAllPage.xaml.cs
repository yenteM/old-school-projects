﻿using MusicStoreData;
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
    /// Interaction logic for ShowAllPage.xaml
    /// </summary>
    public partial class ShowAllPage : Page
    {
        public ShowAllPage()
        {
            InitializeComponent();

            albumDataGrid.ItemsSource = AlbumRepository.GetAllAlbums();
        }
    }
}
