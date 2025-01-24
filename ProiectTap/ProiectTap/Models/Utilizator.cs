using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectTap.Models
{
    public class Utilizator
    {
        public int IdUtilizator {  get; set; }
        public string Nume {  get; set; }
        public string Parola {  get; set; }

        public string getParola()
        {
            return Parola;
        }
    }
}
