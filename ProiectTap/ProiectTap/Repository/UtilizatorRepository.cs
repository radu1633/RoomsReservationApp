using ProiectTap.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectTap.Repository
{
    public class UtilizatorRepository
    {
        private static UtilizatorRepository _instance;
        private Utilizator utilizator;
        private OleDbConnection _connection;


        private UtilizatorRepository()
        {
            _connection = DatabaseConnection.Instance.GetConnection();
        }

        public static UtilizatorRepository Instance
        {
            get
            {
                
                if (_instance == null)
                {
                    _instance = new UtilizatorRepository();
                }
                   
                return _instance;
            }
        }

        public int GetUserId()
        {
            return this.utilizator.IdUtilizator;
        }

        public void SetUser(Utilizator utilizator)
        {
            this.utilizator = utilizator;
        }

        public Utilizator GetUtilizator(string nume)
        {
            Utilizator utilizator = null;
            string query = "Select IdUtilizator,Parola from Utilizatori " +
            "where Nume='" + nume + "'";

            OleDbCommand command = new OleDbCommand(query, _connection);
            _connection.Open();
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                utilizator = new Utilizator
                {
                    IdUtilizator = (int)reader["IdUtilizator"],
                    Nume = nume,
                    Parola = reader["Parola"].ToString()
                };
            }

            _connection.Close();
            return utilizator;
        }

    }
}
