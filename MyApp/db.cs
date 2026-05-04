using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace MyApp
{
    internal class db
    {
        public static string connectionString = "server=localhost; database=youtube; uid=root; pwd=rootroot;";
        public static MySqlConnection connection = new MySqlConnection(connectionString);


        public static void openConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured trying to connect to the database");
            }
        }

        public static void closeConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured trying to terminate database connection");
            }
        }
    }
}
