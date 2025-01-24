using ProiectTap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectTap.Interfaces
{
    public interface IRezervareContinut
    { 
        int TotalSum(List<RezervareContinut> continuturi);
    }
}
