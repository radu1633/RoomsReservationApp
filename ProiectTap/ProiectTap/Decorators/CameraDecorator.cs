using ProiectTap.Interfaces;
using ProiectTap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectTap.Decorators
{
    public class CameraDecorator : ICamera
    {
        private readonly Camera _camera;

        public CameraDecorator(Camera camera)
        {
            _camera = camera;
        }
        
        public bool AlreadyExists(List<Camera> camere)
        {
            var check = camere.Any(camera => camera.NrCamera == _camera.NrCamera);
            if (check == true)
            {
                MessageBox.Show("Aceasta camera exista deja in sistem!");
                return true;
            }
            return false;
        }

        public bool IsValid()
        {
            return ValidatePositiveNumber(_camera.NrCamera, "Număr Cameră") &&
               ValidatePositiveNumber(_camera.NrLocuri, "Număr Locuri") &&
               ValidatePositiveNumber(_camera.Etaj, "Etaj") &&
               ValidatePositiveNumber(_camera.PretZi, "Preț/Zi");
        }

        private bool ValidatePositiveNumber(int value, string fieldName)
        {
            if (value <= 0)
            {
                MessageBox.Show($"{fieldName} trebuie să fie un număr pozitiv și mai mare decât 0.");
                return false;
            }
            return true;
        }
    }
}
