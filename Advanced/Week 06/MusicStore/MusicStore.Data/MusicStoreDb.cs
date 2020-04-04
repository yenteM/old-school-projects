using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Data
{
    public class MusicStoreDb
    {

        public static SqlConnection GetConnection ()
        {
            SqlConnection connection = new SqlConnection("Data Source = (localdb)\\mssqllocaldb ; Initial Catalog = MvcMusicStore; Integrated Security = true");
            return connection;
        }
    }
}
