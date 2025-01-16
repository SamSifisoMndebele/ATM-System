using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_System
{
    internal class Connection
    {
        private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + 
            System.Windows.Forms.Application.StartupPath + "\\BankDatabase.mdf;Integrated Security=True";

        internal static void GetConnection(Action<SqlConnection> func)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                func.Invoke(connection);
            }
        }

        internal static void CreateCommand(string queryString)
        {
            using (SqlConnection connection = new SqlConnection(
                       connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                using (SqlDataReader reader =
                    command.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(String.Format("{0}", reader[0]));
                    }
                }
            }
        }
    }
}
