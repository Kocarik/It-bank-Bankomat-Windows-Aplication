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
            port = "3306";
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

        public bool getCardPin(string cardID, string cardPIN)
        {

            if (openConnection())
            {
                string sqlQuery = "select idc, pin from pinaccess where pin like '" + cardPIN + "'";

                MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    if (reader["idc"] + "" == cardID && reader["pin"] + "" == cardPIN)
                    {
                        closeConnection();
                        return true;
                    }
                }
            }
            closeConnection();
            return false;
        }

        public string getAccountsID(string cardID)
        {
            string accountID = null;
            if (openConnection())
            {
                string sqlQuery = "SELECT accounts.id FROM accounts inner join cards on accounts.id = cards.ida where cards.id like '" + cardID + "'"; ;
                MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        accountID = reader["id"] + "";
                        closeConnection();
                        return accountID;
                    }
                }
            }
            closeConnection();
            return accountID;
        }

        public string getBalance(string cardID)
        {
            string balance = null;
            if (openConnection())
            {
                string sqlQuery = "SELECT accounts.id,balance FROM accounts inner join cards on accounts.id = cards.ida where cards.id like '" + cardID + "'";
                MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        balance = reader["balance"] + "";
                        closeConnection();
                        return balance;
                    }
                }
            }
            closeConnection();
            return balance;
        }


        public bool updateBalance(string accountID, float balance)
        {
            if (openConnection())
            {
                string sqlQuery = "Update accounts set balance = balance -" + balance + " where Accounts.id like '" + accountID + "'";
                MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);
                cmd.Parameters.AddWithValue("@balance", balance);
                cmd.ExecuteNonQuery();
                closeConnection();
                return true;
            }
            return false;
        }

        // insert into bat acess
        public void insetIntobatAcess(int cardID)
        {
            if (openConnection())
            {
                string sqlQuery = "INSERT INTO invalidpinacess (idc, date) values (@cardID, @date )";
                MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);
                cmd.Parameters.AddWithValue("@cardID", cardID);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                cmd.ExecuteNonQuery();
                closeConnection();
            }
        }




    }
}
