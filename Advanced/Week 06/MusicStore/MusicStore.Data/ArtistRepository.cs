using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Data
{
    public class ArtistRepository
    {

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
    }
}
