using ProiectTap.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectTap.Repository
{
    public class CameraRepository
    {
        private OleDbConnection _connection;
        List<Camera> camere;

        public CameraRepository()
        {
            _connection = DatabaseConnection.Instance.GetConnection();
        }

        public List<Camera> GetAllCamere()
        {
            this.camere = new List<Camera>();
            string query = "SELECT IdCamera, NrCamera, NrLocuri, Etaj, PretZi, SpImagine FROM Camere";


            OleDbCommand command = new OleDbCommand(query, _connection);
            _connection.Open();
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.camere.Add(new Camera
                {
                    IdCamera = reader.GetInt32(0),
                    NrCamera = reader.GetInt32(1),
                    NrLocuri = reader.GetInt32(2),
                    Etaj = reader.GetInt32(3),
                    PretZi = reader.GetInt32(4),
                    SpImagine = reader.GetString(5),
                });
            }

            _connection.Close();
            return this.camere.OrderBy(c => c.NrCamera).ToList();
        }

        public List<Camera> GetFilteredCamere(string nrCamera, string nrLocuri, string etaj, string pretZi)
        {
            return this.camere.Where(camera =>
                (string.IsNullOrEmpty(nrCamera) || camera.NrCamera == int.Parse(nrCamera)) &&
                (string.IsNullOrEmpty(nrLocuri) || camera.NrLocuri == int.Parse(nrLocuri)) &&
                (string.IsNullOrEmpty(etaj) || camera.Etaj == int.Parse(etaj)) &&
                (string.IsNullOrEmpty(pretZi) || camera.PretZi == int.Parse(pretZi))
            ).ToList();
        }

        public void AddCamera(Camera camera)
        {
            string query = "INSERT INTO Camere (NrCamera, NrLocuri, Etaj, PretZi, SpImagine) VALUES ('" + camera.NrCamera + "', '" + camera.NrLocuri + "', '" + camera.Etaj + "', '" + camera.PretZi + "', '" + camera.SpImagine + "')";
            OleDbCommand command = new OleDbCommand(query, _connection);
            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void RemoveCamera(int idCamera)
        {
            string query = "DELETE FROM Camere WHERE IdCamera = " + idCamera;
            OleDbCommand command = new OleDbCommand(query, _connection);
            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void UpdateCamera(Camera camera)
        {
            string query = "UPDATE Camere SET Nrcamera = '" + camera.NrCamera + "', NrLocuri ='" + camera.NrLocuri + "', Etaj = '" + camera.Etaj + "', PretZi ='" + camera.PretZi + "', SpImagine ='" + camera.SpImagine + "' WHERE IdCamera = " + camera.IdCamera;
            OleDbCommand command = new OleDbCommand(query, _connection);
            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
