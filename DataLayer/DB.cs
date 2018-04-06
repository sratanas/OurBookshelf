using System.Configuration;
using System.Data.SqlClient;

namespace DataLayer
{
    public class DB
    {
        public static string ConnectionString
        {
            get
            {
                string connStr = ConfigurationManager.ConnectionStrings["BookshelfConnection"].ToString();

                //Allows to parse automatically a connection string and manage the individual properties
                //of a class. Makes it easy to manipulate a connection string
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder(connStr);

                return sb.ToString();
            }
        }
        /// <summary>
        /// returns an open connection
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetSqlConnection()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            return conn;
        }


    }

}