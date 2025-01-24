using ProiectTap.Interfaces;
using ProiectTap.Models;
using ProiectTap.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectTap.Decorators
{
    public class ClientDecorator : IClient
    {
        private readonly Client _client;
        private readonly ClientRepository _repo;

        public ClientDecorator(Client client)
        {
            _client = client;
            _repo = new ClientRepository();
        }

        public bool AlreadyExists(List<Client> clients)
        {
            var check = clients.Any(client => client.NrTelefon == _client.NrTelefon);
            if (check == true)
            {
                MessageBox.Show("Acest numar de telefon exista deja in sistem!");
                return true;
            }
            return false;
        }

        public bool IsValid()
        {
            return ValidateName(_client.Nume) &&
               ValidateName(_client.Prenume) &&
               ValidatePhoneNumber(_client.NrTelefon);
        }

        private bool ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length < 2)
            {
                MessageBox.Show("Numele și prenumele trebuie să aibă cel puțin 2 caractere și să nu fie goale!");
                return false;
            }
            if (!name.All(char.IsLetter)){
                MessageBox.Show("Numele și prenumele trebuie să contina doar litere!");
                return false;
            }
            return true;
        }

        private bool ValidatePhoneNumber(string phoneNumber)
        {
            // Exemplu de validare simplă pentru număr de telefon
            if (string.IsNullOrWhiteSpace(phoneNumber) || phoneNumber.Length != 10 || !phoneNumber.All(char.IsDigit))
            {
                MessageBox.Show("Numărul de telefon trebuie să aibă exact 10 cifre!");
                return false;
            }
            return true;
        }
    }
}
