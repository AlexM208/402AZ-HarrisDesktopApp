using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HarrisDesktopApp
{
    
        internal class DataAccess
        {
            private string connectionString = "Server=harrisdb.c9a662w4ow2e.us-east-1.rds.amazonaws.com;Database=HarrisDB;User id= admin;Password=Testdatabase1;";
            public DataTable ExecuteQuery(string query)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            return dataTable;
                        }
                    }
                }
            }

            public void ExecuteNonQuery(MySqlCommand command)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    command.Connection = connection;
                    command.ExecuteNonQuery();
                }
            }
        }

    
}
