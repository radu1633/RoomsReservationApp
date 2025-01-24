using ProiectTap.Interfaces;
using ProiectTap.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectTap.Repository
{
    public class ClientRepository
    {
        private OleDbConnection _connection;
        List<Client> clients;
        public ClientRepository()
        {
            _connection = DatabaseConnection.Instance.GetConnection();
        }

        public List<Client> GetAllClients()
        {
            this.clients = new List<Client>();
            string query = "SELECT IdClient, Nume, Prenume, NrTelefon FROM Clienti";


            OleDbCommand command = new OleDbCommand(query, _connection);
            _connection.Open();
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.clients.Add(new Client
                {
                    IdClient = reader.GetInt32(0),
                    Nume = reader.GetString(1),
                    Prenume = reader.GetString(2),
                    NrTelefon = reader.GetString(3)
                });
            }

            _connection.Close();
            return this.clients;
        }

        public List<Client> GetFilteredClients(string nume, string prenume, string nrTelefon)
        {
            return this.clients.Where(client =>
                (string.IsNullOrEmpty(nume) || client.Nume == nume) &&
                (string.IsNullOrEmpty(prenume) || client.Prenume == prenume) &&
                (string.IsNullOrEmpty(nrTelefon) || client.NrTelefon == nrTelefon)
            ).ToList();
        }

        public void AddClient(Client client)
        {
            string query = "INSERT INTO Clienti (Nume, Prenume, NrTelefon) VALUES ('" + client.Nume + "', '" + client.Prenume + "', '" + client.NrTelefon + "')";
            OleDbCommand command = new OleDbCommand(query, _connection);
            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void RemoveClient(int idClient)
        {
            string query = "DELETE FROM Clienti WHERE IdClient = " + idClient;
            OleDbCommand command = new OleDbCommand(query, _connection);
            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void UpdateClient(Client client)
        {
            string query = "UPDATE Clienti SET Nume = '" + client.Nume +"', Prenume ='" + client.Prenume + "', NrTelefon = '" + client.NrTelefon + "' WHERE IdClient = " + client.IdClient;
            OleDbCommand command = new OleDbCommand(query, _connection);
            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
