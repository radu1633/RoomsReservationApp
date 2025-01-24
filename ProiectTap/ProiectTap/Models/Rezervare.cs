using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectTap.Models
{
    public class Rezervare
    {
        public int NrRezervare { get; set; }
        public DateTime DataRezervare { get; set; }
        public int IdClient {  get; set; }
        public int IdUtilizator { get; set; }
        public string NumeClient { get; set; }
    }
}
