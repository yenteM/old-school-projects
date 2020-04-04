using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreData
{
    public class GenreRepository
    {

        public static string[] GetGenres()
        {
            string genres = "";
            string[] allGenres = null;
            SqlConnection conn = MusicStoreDb.GetConnection();
            string command = "SELECT [Name] FROM [dbo].[Genre]";
            try
            {
                using (var cmd = new SqlCommand(command, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);


                    while (reader.Read())
                    {
                        genres += (string)reader["Name"] + ",";
                    }
                    reader.Close();
                }

                allGenres = genres.Split(',');

            }
            catch (SqlException)
            {

            }

            return allGenres;
        }

        public static string GetGenreById(int genreId)
        {
            string genre = "";
            SqlConnection conn = MusicStoreDb.GetConnection();
            string command = "SELECT [Name] FROM [dbo].[Genre] WHERE [GenreId] = @GenreId";
            try
            {
                using (var cmd = new SqlCommand(command, conn))
                {
                    cmd.Parameters.AddWithValue("@GenreId", genreId);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);


                    while (reader.Read())
                    {
                        genre = (string)reader["Name"];
                    }
                    reader.Close();
                }

            }
            catch (SqlException)
            {

            }

            return genre;
        }
    }
}
