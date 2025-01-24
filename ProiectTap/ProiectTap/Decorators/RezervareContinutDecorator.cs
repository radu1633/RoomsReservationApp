using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProiectTap.Interfaces;
using ProiectTap.Models;

namespace ProiectTap.Decorators
{
    public class RezervareContinutDecorator : IRezervareContinut
    {
       
        public int TotalSum(List<RezervareContinut> continuturi)
        {
            int totalSum = 0;
            foreach (RezervareContinut continut in continuturi)
            {
                totalSum += continut.PretZi * continut.NrZile;
            }
            return totalSum;
        }

    }
}
