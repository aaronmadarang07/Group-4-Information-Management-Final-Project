using MySql.Data.MySqlClient;

namespace Group_4_Information_Management_Final_Project
{
    public class DBHelper
    {
        private static string connectionString =
    "Server=127.0.0.1;Port=3307;Database=clinic_db;Uid=root;Pwd=;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}