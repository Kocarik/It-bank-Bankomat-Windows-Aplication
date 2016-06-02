using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace It_bank_Bankomat_Windows_Aplication
{

    class ConnectToDatabase
    {
        private string server, database, password, port, uid;
        public MySqlConnection connection;

        public ConnectToDatabase()
        {
            server = "localhost";
            database = "itBank8";
            uid = "Admin";
            password = "salama";
            port = "3360";
            string connectionString = "SERVER=" + server + ";" + "PORT=" + port + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        public bool openConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.Write(ex.ToString());
                return false;
            }
        }

        public bool closeConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.Write(ex.ToString());
                return false;
            }
        }

        public string selectCard()
        {
            if (openConnection())
            {
                string cardId = null;
                string sqlQuery = "select id from cards";
                MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    cardId = reader["id"].ToString();
                    closeConnection();
                    return cardId;
                }

                else
                {
                    return cardId;
                }

            }

            return null;
        }

    }
}
