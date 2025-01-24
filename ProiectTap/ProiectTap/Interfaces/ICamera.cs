using ProiectTap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectTap.Interfaces
{
    public interface ICamera
    {
        bool IsValid();
        bool AlreadyExists(List<Camera> camera);
    }
}
