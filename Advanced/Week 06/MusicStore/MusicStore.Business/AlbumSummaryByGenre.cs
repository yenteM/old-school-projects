using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicStore.Data;
using System.Data.SqlClient;
using System.Data;

namespace MusicStore.Business
{
    public class AlbumSummaryByGenre
    {

        public List<AlbumSummary> GetAlbumSummariesByGenre(int genreId)
        {
            List<AlbumSummary> list = new List<AlbumSummary>();

            string[] albums = AlbumRepository.GetAlbumsByGenre(genreId);
            string[] album = null;

            for (int i= 0; i < albums.Count()-1; i++)
            {
                album = albums[i].Split(':');
                list.Add(new AlbumSummary
                {
                    Artist = ArtistRepository.GetAristNameById(Convert.ToInt32(album[2])),
                    Price = album[1],
                    Title = album[0]
                });
            }

            return list;
        }
    }
}
