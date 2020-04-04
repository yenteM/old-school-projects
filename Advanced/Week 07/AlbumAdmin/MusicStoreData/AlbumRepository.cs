using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreData
{
    public class AlbumRepository
    {



        public static List<Album> GetAllAlbums()
        {
            List<Album> AllAlbums = new List<Album>();
            SqlConnection conn = MusicStoreDb.GetConnection();
            string command = "SELECT * FROM [dbo].[Album]";
            try
            {
                using (var cmd = new SqlCommand(command, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);


                    while (reader.Read())
                    {
                        AllAlbums.Add(new Album
                        {
                            AlbumId = Convert.ToString(reader["AlbumId"]),
                            GenreId = Convert.ToString(reader["GenreId"]),
                            ArtistId = Convert.ToString(reader["ArtistId"]),
                            Title = Convert.ToString(reader["Title"]),
                            Price = Convert.ToString(reader["Price"]),
                            AlbumArtUrl = Convert.ToString(reader["AlbumArtUrl"]),
                        });
                    }
                    reader.Close();
                }

            }
            catch (SqlException)
            {

            }

            return AllAlbums;
        }


        public static void UpdateAlbum(Album updateAlbum)
        {
            SqlConnection conn = MusicStoreDb.GetConnection();
            int updateCount = 0;

            string command = "UPDATE [dbo].[Album] SET [GenreId] @GenreId, [ArtistId] = @ArtistId, " +
                "[Title] =@Title, [Price] = @Price, [AlbumArtUrl] = @AlbumArtUrl WHERE [AlbumId] = @AlbumId";
            try
            {
                using (var cmd = new SqlCommand(command, conn))
                {
                    cmd.Parameters.AddWithValue("@AlbumId", updateAlbum.AlbumId);
                    cmd.Parameters.AddWithValue("@GenreId", updateAlbum.GenreId);
                    cmd.Parameters.AddWithValue("@ArtistId", updateAlbum.ArtistId);
                    cmd.Parameters.AddWithValue("@Title", updateAlbum.Title);
                    cmd.Parameters.AddWithValue("@Price", updateAlbum.Price);
                    cmd.Parameters.AddWithValue("@AlbumArtUrl", updateAlbum.AlbumArtUrl);

                    conn.Open();
                    updateCount = (int)cmd.ExecuteScalar();
                }

            }
            catch (SqlException)
            {

            }
        }

    }
}
