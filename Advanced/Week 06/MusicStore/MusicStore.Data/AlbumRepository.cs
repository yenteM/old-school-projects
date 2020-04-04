using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Data
{
    public class AlbumRepository
    {

        public static string[] GetAlbumsByGenre(int genreId)
        {
            string albums = "";
            string[] selectedAlbums = null;
            SqlConnection conn = MusicStoreDb.GetConnection();
            string command = "SELECT [Title], [Price], [ArtistId] FROM [dbo].[Album] WHERE [GenreId] = @GenreId";
            try
            {
                using (var cmd = new SqlCommand(command, conn))
                {
                    cmd.Parameters.AddWithValue("@GenreId", genreId);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);


                    while (reader.Read())
                    {
                        albums += (string)reader["Title"] + ":" + Convert.ToString(reader["Price"]) + ":" + Convert.ToString(reader["ArtistId"]) + ";";
                    }
                    reader.Close();
                }

                selectedAlbums = albums.Split(';');

            }
            catch (SqlException)
            {

            }

            return selectedAlbums;
        }

        public static string[] GetAllAlbums()
        {
            string albums = "";
            string[] selectedAlbums = null;
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
                        albums += (string)reader["Title"] + ":" + Convert.ToString(reader["Price"]) + ":" + Convert.ToString(reader["ArtistId"]) + ";";
                    }
                    reader.Close();
                }

                selectedAlbums = albums.Split(';');

            }
            catch (SqlException)
            {

            }

            return selectedAlbums;
        }
    }
}
