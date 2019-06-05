using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace PWLogin
{
    /// <summary>
    /// Adatbázis kapcsolat létesítés singletonnal
    /// </summary>
    class SingleDB
    {
        private static SingleDB uniqueInstance = null;
        private MySqlConnection connection;
        private string server;
        private string port;
        private string database;
        private string uid;
        private string password;

        private SingleDB()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            port = "3306";
            database = "pandawdb";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" +
                               "DATABASE=" + database + ";" +
                               "UID=" + uid + ";" +
                               "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
            MySqlCommand comm = connection.CreateCommand();
            

        }

        /// <summary>
        /// publikus metódus, mellyel meghívjuk a privát konstruktort
        /// </summary>
        /// <returns></returns>
        public static SingleDB getInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new SingleDB();
            return uniqueInstance;
        }
        public string getUser(string searchFor)
        {
           
            MySqlCommand comm = connection.CreateCommand();
            comm.CommandText = "SELECT username FROM users WHERE username= '"+searchFor+"'";
            try
            {
                connection.Open();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            MySqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                if (!reader[0].Equals(searchFor))
                {
                    Console.WriteLine("Nincs ilyen felhasználó");
                }
                else
                    return reader[0].ToString();
            }
            return reader[0].ToString();
        }

    }
}
