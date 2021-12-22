using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MyShelfOfBooks
{
    class DataBase
    {
        MySqlConnectionStringBuilder connectionString;
        public MySqlConnection connection;

        // Метод создания Строки подключения, и Коннекшина
        public void CreateStrConnection()
        {
            connectionString = new MySqlConnectionStringBuilder();
            connectionString.Server = "localhost";
            connectionString.UserID = "root";
            connectionString.Password = "root";
            connectionString.Database = "database_book";

            connection = new MySqlConnection(connectionString.ToString());

        }
        public int AddBook(string Title, string Author, string Genre, string DateCreate)
        {
            var check = -1;
            MySqlConnection connection = new MySqlConnection(connectionString.ConnectionString);
            connection.Open();
            string CommandText = "INSERT INTO 'database_book'.'books' ('Title','Genre','Author','DateCreate')" + $"VALUES ('{Title}','{Genre}','{Author}',{DateCreate}');";
            MySqlCommand command = new MySqlCommand(CommandText, connection);
            check = command.ExecuteNonQuery();
            connection.Close();
            return check;
        }
    }
}
