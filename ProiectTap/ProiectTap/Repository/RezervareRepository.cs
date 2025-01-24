using ProiectTap.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectTap.Interfaces;
using System.Reflection;
using System.Windows.Forms;

namespace ProiectTap.Repository
{
    public class RezervareRepository
    {
        private OleDbConnection _connection;
        List<Rezervare> rezervari;

        public RezervareRepository()
        {
            _connection = DatabaseConnection.Instance.GetConnection();
        }

        public List<Rezervare> GetAllRezervari()
        {
            this.rezervari = new List<Rezervare>();
            string query = "SELECT IdRezervare, DataRezervare, r.IdClient, IdUtilizator, c.Nume & ' ' & c.Prenume AS NumeClient " +
                           "FROM Rezervari AS r INNER JOIN Clienti AS c ON r.IdClient = c.IdClient";


            OleDbCommand command = new OleDbCommand(query, _connection);
            _connection.Open();
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.rezervari.Add(new Rezervare
                {
                    NrRezervare = reader.GetInt32(0),
                    DataRezervare = reader.GetDateTime(1),
                    IdClient = reader.GetInt32(2),
                    IdUtilizator = reader.GetInt32(3),
                    NumeClient = reader.GetString(4),
                });
            }

            _connection.Close();
            return this.rezervari;
        }

        public int GetRezervareByClient(int idClient)
        {
            string query = "SELECT IdRezervare " +
                           "FROM Rezervari WHERE IdClient = " + idClient;
            OleDbCommand command = new OleDbCommand(query, _connection);
            _connection.Open();
            OleDbDataReader reader = command.ExecuteReader();
            int idRezervare = -1;
            if (reader.Read())
            {
                idRezervare = reader.GetInt32(0);
            }
            

            _connection.Close();
            return idRezervare;
        }

        public void AddRezervare(Rezervare rezervare)
        {
            string query = "INSERT INTO Rezervari (DataRezervare, IdClient, IdUtilizator) VALUES ('" + rezervare.DataRezervare + "', '" + rezervare.IdClient + "', '" + rezervare.IdUtilizator + "')";
            OleDbCommand command = new OleDbCommand(query, _connection);
            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void UpdateRezervare(Rezervare rezervare)
        {
            string query = "UPDATE Rezervari SET DataRezervare = '" + rezervare.DataRezervare + "', IdClient ='" + rezervare.IdClient + "', IdUtilizator = '" + rezervare.IdUtilizator + "' WHERE IdRezervare = " + rezervare.NrRezervare;
            OleDbCommand command = new OleDbCommand(query, _connection);
            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void RemoveRezervare(int idRezervare)
        {
            string query = "DELETE FROM Rezervari WHERE IdRezervare = " + idRezervare;
            OleDbCommand command = new OleDbCommand(query, _connection);
            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void RemoveRezervariWithoutContinut()
        {
            string query = "DELETE FROM Rezervari WHERE IdRezervare NOT IN( SELECT IdRezervare FROM RezervariContinut); ";
            OleDbCommand command = new OleDbCommand(query, _connection);
            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
