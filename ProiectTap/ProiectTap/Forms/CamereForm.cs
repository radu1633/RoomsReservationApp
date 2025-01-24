using ProiectTap.Repository;
using ProiectTap.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProiectTap.Decorators;
using ProiectTap.Interfaces;

namespace ProiectTap
{
    public partial class CamereForm : Form
    {
        CameraRepository _repo;
        RezervareRepository _rezervareRepo;
        RezervareContinutRepository _rezervareContinutRepo;
        List<Camera> camere;
        string _buttonPressed;
        Camera _camera;
        public CamereForm()
        {
            InitializeComponent();
            _repo = new CameraRepository();
            _rezervareRepo = new RezervareRepository();
            _rezervareContinutRepo = new RezervareContinutRepository();
        }

        private void CamereForm_Load(object sender, EventArgs e)
        {
            LoadCamere();
            A1(false);
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void A1(Boolean v)
        {
            confirmareButon.Enabled = v;
            renuntareButon.Enabled = v;
            cautareButon.Enabled = !v;
            adaugareButon.Enabled = !v;
            modificareButon.Enabled = !v;
            stergereButon.Enabled = !v;
        }

        private void EmptyTexts()
        {
            this.nrCameraText.Text = "";
            this.nrLocuriText.Text = "";
            this.etajText.Text = "";
            this.pretZiText.Text = "";
            this.spImagineText.Text = "";
            this.spImagineBox.ImageLocation = "";
        }

        private bool AreEmpty()
        {
            if (this.nrCameraText.Text == "" ||
            this.nrLocuriText.Text == "" ||
            this.etajText.Text == "" ||
            this.pretZiText.Text == "")
            {
                MessageBox.Show("Toate campurile trebuie completate!");
                return false;
            }
            return true;
        }

        public bool AreDigits()
        {
            if (!this.nrCameraText.Text.All(char.IsDigit) ||
            !this.nrLocuriText.Text.All(char.IsDigit) ||
            !this.etajText.Text.All(char.IsDigit) ||
            !this.pretZiText.Text.All(char.IsDigit))
            {
                MessageBox.Show("Campurile trebuie sa contina doar numere!");
                return false;
            }
            return true;
        }

        private void LoadCamere()
        {
            camere = _repo.GetAllCamere();
            this.dataGridView1.DataSource = camere;
            this.dataGridView1.Columns["IdCamera"].Visible = false;
            this.dataGridView1.Columns["SpImagine"].Visible = false;
        }

        private void adaugareButon_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            this._buttonPressed = button.Text;
            A1(true);
        }

        private void incarcaButon_Click(object sender, EventArgs e)
        {
            spImaginePicker.Filter = "Imagini (*.jpg;*.jpeg;*.png;)|*.jpg;*.jpeg;*.png;";
            spImaginePicker.Title = "Selectează un fișier imagine";

            if (spImaginePicker.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = spImaginePicker.FileName;

                spImagineText.Text = selectedImagePath;
                spImagineBox.ImageLocation = selectedImagePath;
            }
        }

        private void modificareButon_Click(object sender, EventArgs e)
        {
            nrCameraText.Text = _camera.NrCamera.ToString();
            nrLocuriText.Text = _camera.NrLocuri.ToString();
            etajText.Text = _camera.Etaj.ToString();
            pretZiText.Text = _camera.PretZi.ToString();
            spImagineText.Text = _camera.SpImagine;
            spImagineBox.ImageLocation = _camera.SpImagine;
            Button button = sender as Button;
            this._buttonPressed = button.Text;
            A1(true);
        }

        private void stergereButon_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            this._buttonPressed = button.Text;
            A1(true);
        }

        private void cautareButon_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            this._buttonPressed = button.Text;
            A1(true);
        }
        private void renuntareButon_Click(object sender, EventArgs e)
        {
            confirmareButon.Enabled = true;
            nrCameraText.Enabled = true;
            nrLocuriText.Enabled = true;
            etajText.Enabled = true;
            pretZiText.Enabled = true;
            Button button = sender as Button;
            this._buttonPressed = button.Text;
            EmptyTexts();
            LoadCamere();
            A1(false);
        }

        private void confirmareButon_Click(object sender, EventArgs e)
        {
            if (this._buttonPressed == "Adaugare")
            {
                if (AreEmpty() == false || AreDigits() == false) return;
                Camera camera = new Camera()
                {
                    IdCamera = -1,
                    NrCamera = int.Parse(nrCameraText.Text),
                    NrLocuri = int.Parse(nrLocuriText.Text),
                    Etaj = int.Parse(etajText.Text),
                    PretZi = int.Parse(pretZiText.Text),
                    SpImagine = spImagineText.Text,
                    
                };
                var decorator = new CameraDecorator(camera);
                if (decorator.IsValid() == true && decorator.AlreadyExists(this.camere) == false)
                {
                    _repo.AddCamera(camera);
                    LoadCamere();
                    EmptyTexts();
                    A1(false);
                }

            }
            else if (this._buttonPressed == "Modificare")
            {
                if (AreEmpty() == false || AreDigits() == false) return;
                Camera camera = new Camera()
                {
                    IdCamera = this._camera.IdCamera,
                    NrCamera = int.Parse(nrCameraText.Text),
                    NrLocuri = int.Parse(nrLocuriText.Text),
                    Etaj = int.Parse(etajText.Text),
                    PretZi = int.Parse(pretZiText.Text),
                    SpImagine = spImagineText.Text,
                };
                var decorator = new CameraDecorator(camera);
                if (decorator.IsValid() == true)
                {
                    _repo.UpdateCamera(camera);
                    LoadCamere();
                    EmptyTexts();
                    A1(false);
                }
            }
            else if (this._buttonPressed == "Stergere")
            {
                var confirmResult = MessageBox.Show("Odata cu stergerea unei canere, se vor sterge si continuturile rezervarilor pe care aceasta se afla. \n" +
                                       "Doriti sa continuati?",
                                        "Warning",
                                        MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                { 
                    _rezervareContinutRepo.RemoveByCamera(this._camera.IdCamera);
                    _rezervareRepo.RemoveRezervariWithoutContinut();
                    _repo.RemoveCamera(this._camera.IdCamera);
                    LoadCamere();
                    EmptyTexts();
                    A1(false);
                }
                else
                {
                    A1(false);
                }
                
            }
            else
            {

                this.dataGridView1.DataSource = _repo.GetFilteredCamere(nrCameraText.Text, nrLocuriText.Text, etajText.Text, pretZiText.Text);
                confirmareButon.Enabled = false;
                nrCameraText.Enabled = false;
                nrLocuriText.Enabled = false;
                etajText.Enabled = false;
                pretZiText.Enabled = false;
            }
        }
        private void selection_Changed(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.SelectedRows.Count > 0)
            {
                _camera = GetSelectedRowCamera();
            }

            if (this._buttonPressed == "Modificare")
            {
                nrCameraText.Text = _camera.NrCamera.ToString();
                nrLocuriText.Text = _camera.NrLocuri.ToString();
                etajText.Text = _camera.Etaj.ToString();
                pretZiText.Text = _camera.PretZi.ToString();
                spImagineText.Text = _camera.SpImagine;
                spImagineBox.ImageLocation = _camera.SpImagine;
            }

        }


        private Camera GetSelectedRowCamera()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int idCamera = int.Parse(selectedRow.Cells["IdCamera"].Value.ToString());
                int nrCamera = int.Parse(selectedRow.Cells["NrCamera"].Value.ToString());
                int nrLocuri = int.Parse(selectedRow.Cells["NrLocuri"].Value.ToString());
                int etaj = int.Parse(selectedRow.Cells["Etaj"].Value.ToString());
                int pretZi = int.Parse(selectedRow.Cells["PretZi"].Value.ToString());
                string spImagine = selectedRow.Cells["SpImagine"].Value.ToString();

                Camera camera = new Camera()
                {
                    IdCamera = idCamera,
                    NrCamera = nrCamera,
                    NrLocuri = nrLocuri,
                    Etaj = etaj,
                    PretZi = pretZi,
                    SpImagine = spImagine
                };
                return camera;
            }

            MessageBox.Show("Nu există niciun rând selectat!");
            return null;

        }

        
    }
}
