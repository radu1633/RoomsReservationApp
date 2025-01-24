using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectTap.Models
{
    public class RezervareContinut
    {
        public int IdRezervare { get; set; }
        public int Nrc { get; set; }
        public int IdCamera { get; set; }
        public int NrCamera { get; set; }
        public DateTime DataCazarii { get; set; }
        public int PretZi { get; set; }
        public int NrZile { get; set; }

    }
}
