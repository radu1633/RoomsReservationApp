using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectTap
{
    public class DatabaseConnection
    {
        private static DatabaseConnection _instance;
        private OleDbConnection _connection;

        private DatabaseConnection()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=A:\\Facultate\\Anul 3\\Tehnici avansate de programare\\ProiectTap.accdb";
            _connection = new OleDbConnection(connectionString);
        }

        public static DatabaseConnection Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DatabaseConnection();
                }
                return _instance;
            }
        }

        public OleDbConnection GetConnection()
        {
            return _connection;
        }
    }
}
