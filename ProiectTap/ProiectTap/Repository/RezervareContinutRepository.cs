using ProiectTap.Interfaces;
using ProiectTap.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectTap.Repository
{
    public class RezervareContinutRepository
    {
        private OleDbConnection _connection;
        List<RezervareContinut> continuturi;

        public RezervareContinutRepository()
        {
            _connection = DatabaseConnection.Instance.GetConnection();
        }

        public List<RezervareContinut> GetContinuturi(int idRezervare)
        {
            this.continuturi = new List<RezervareContinut>();
            string query = "SELECT r.IdRezervare, r.Nrc, r.IdCamera, r.DataCazarii, r.PretZi, r.NrZile, c.NrCamera " +
                           "FROM RezervariContinut AS r INNER JOIN Camere AS c ON r.IdCamera= c.IdCamera " +
                           "WHERE r.IdRezervare = " + idRezervare;


            OleDbCommand command = new OleDbCommand(query, _connection);
            _connection.Open();
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.continuturi.Add(new RezervareContinut
                {
                    IdRezervare = reader.GetInt32(0),
                    Nrc = reader.GetInt32(1),
                    IdCamera = reader.GetInt32(2),
                    DataCazarii = reader.GetDateTime(3),
                    PretZi = reader.GetInt32(4),
                    NrZile = reader.GetInt32(5),
                    NrCamera = reader.GetInt32(6),
                });

            }

            _connection.Close();
            return this.continuturi;
        }

        public int GetNextNrc(int idRezervare)
        {
            int nextNrc = 1;
            
            string query = "SELECT MAX(Nrc) FROM RezervariContinut WHERE IdRezervare = @IdRezervare";
            OleDbCommand command = new OleDbCommand(query, _connection);
            _connection.Open();
            command.Parameters.AddWithValue("@IdRezervare", idRezervare);

            object result = command.ExecuteScalar();
            if (result != DBNull.Value)
            {
                nextNrc = Convert.ToInt32(result);
            }
            
            _connection.Close();
            

            return nextNrc;
        }

        public void AddContinut(RezervareContinut continut)
        {
            string query = "INSERT INTO RezervariContinut (IdRezervare, Nrc, IdCamera, DataCazarii, PretZi, NrZile) VALUES ('" + continut.IdRezervare + "', '" + continut.Nrc + "', '" + continut.IdCamera + "', '" + continut.DataCazarii + "', '" + continut.PretZi + "','" + continut.NrZile + "')";
            OleDbCommand command = new OleDbCommand(query, _connection);
            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void UpdateContinut(RezervareContinut continut)
        {
            string query = "UPDATE RezervariContinut SET IdCamera = '" + continut.IdCamera + "', DataCazarii ='" + continut.DataCazarii + "', PretZi = '" + continut.PretZi + "', NrZile = '" + continut.NrZile + "' WHERE IdRezervare = " + continut.IdRezervare + " AND Nrc = " + continut.Nrc;
            OleDbCommand command = new OleDbCommand(query, _connection);
            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void RemoveContinut(int idRezervare, int nrc)
        {
            string query = "DELETE FROM RezervariContinut WHERE IdRezervare = " + idRezervare + " AND Nrc = " + nrc;
            OleDbCommand command = new OleDbCommand(query, _connection);
            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void RemoveByCamera(int idCamera)
        {
            string query = "DELETE FROM RezervariContinut WHERE IdCamera = " + idCamera;
            OleDbCommand command = new OleDbCommand(query, _connection);
            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void RemoveAllContinuturi(int idRezervare)
        {
            string query = "DELETE FROM RezervariContinut WHERE IdRezervare = " + idRezervare;
            OleDbCommand command = new OleDbCommand(query, _connection);
            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
