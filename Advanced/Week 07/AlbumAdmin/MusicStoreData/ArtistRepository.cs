using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreData
{
    public class ArtistRepository
    {
        public static string[] GetAllArists()
        {
            string artistNames = "";
            string[] artists = null;
            SqlConnection conn = MusicStoreDb.GetConnection();
            string command = "SELECT [Name] FROM [dbo].[Artist]";
            try
            {
                using (var cmd = new SqlCommand(command, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        artistNames += (string)reader["Name"] + ':';
                    }

                    reader.Close();
                }

                artists = artistNames.Split(':');

            }
            catch (SqlException)
            {

            }

            return artists;
        }

        public static string GetAristNameById(int artistId)
        {
            string artistName = "";

            SqlConnection conn = MusicStoreDb.GetConnection();
            string command = "SELECT [Name] FROM [dbo].[Artist] WHERE [ArtistId] = @ArtistId";
            try
            {
                using (var cmd = new SqlCommand(command, conn))
                {
                    cmd.Parameters.AddWithValue("@ArtistId", artistId);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        artistName = (string)reader["Name"];
                    }

                    reader.Close();
                }
            }
            catch (SqlException)
            {

            }

            return artistName;
        }

        public static Album GetAlbumsById(int albumId)
        {
            Album selectedAlbum = null;
            SqlConnection conn = MusicStoreDb.GetConnection();
            string command = "SELECT * FROM [dbo].[Album] WHERE [ALbumId] = @AlbumId";
            try
            {
                using (var cmd = new SqlCommand(command, conn))
                {
                    cmd.Parameters.AddWithValue("@AlbumId", albumId);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);


                    while (reader.Read())
                    {
                        selectedAlbum = new Album
                        {
                            AlbumId = Convert.ToString(reader["AlbumId"]),
                            GenreId = Convert.ToString(reader["GenreId"]),
                            ArtistId = Convert.ToString(reader["ArtistId"]),
                            Title = Convert.ToString(reader["Title"]),
                            Price = Convert.ToString(reader["Price"]),
                            AlbumArtUrl = Convert.ToString(reader["AlbumArtUrl"]),
                        };
                    }
                    reader.Close();
                }

                selectedAlbum.Genre = GenreRepository.GetGenreById(Convert.ToInt32(selectedAlbum.GenreId));
                selectedAlbum.Artist = ArtistRepository.GetAristNameById(Convert.ToInt32(selectedAlbum.ArtistId));


            }
            catch (SqlException)
            {

            }
            catch (Exception)
            {
                throw new Exception();
            }

            return selectedAlbum;
        }

    }
}
