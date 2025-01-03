using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDataLogger_CSharp.database
{
    internal class DatabaseConnection
    {
        // database - "CSharpProject";
        // sample: string connectionString = "Server=COLDCOF63E\\SQLEXPRESS;Database=HealthDataLogger;Integrated Security=True;";
        private static DatabaseConnection instance;

        private SqlConnection connection;

        private DatabaseConnection() 
        {
            string connectionString = "Server=COLDCOF63E\\SQLEXPRESS;Database=HealthDataLogger;Integrated Security=True;TrustServerCertificate=True;";
            //string connectionString = "Server=MYTHINKPAD\\SQLEXPRESS;Database=HealthDataLogger;Trusted_Connection=True;TrustServerCertificate=True;";
            connection = new SqlConnection(connectionString);
        }

        public static DatabaseConnection Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseConnection();
                }
                return instance;
            }
        }

        public SqlConnection GetConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed ||
                connection.State == System.Data.ConnectionState.Broken)
            {
                connection.Open();
            }
            return connection;
        }

        public void Dispose() 
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
