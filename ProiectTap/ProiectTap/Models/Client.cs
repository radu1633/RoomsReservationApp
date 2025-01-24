using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectTap.Models
{
    public class Client
    {
        public int IdClient { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string NrTelefon { get; set; }

        public string NumeClient => $"{Nume} {Prenume}";
    }
}
