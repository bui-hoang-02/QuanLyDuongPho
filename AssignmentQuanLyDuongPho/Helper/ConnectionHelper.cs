using System.Data;
using MySql.Data.MySqlClient;

namespace AssignmentQuanLyDuongPho.Helper
{
    public class ConnectionHelper
    {
        private static MySqlConnection Connection;

        public static MySqlConnection GetConnection()
        {
            if (Connection == null || Connection.State == ConnectionState.Closed)
            {
                Connection = new MySqlConnection();
                Connection.ConnectionString = $"server=127.0.0.1;database=quan_ly_duong_pho;UID=root;password=;port=3306";
                Connection.Open();
            }
            return Connection;
        }
    }
}