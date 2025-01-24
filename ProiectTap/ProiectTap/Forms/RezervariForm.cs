using ProiectTap.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProiectTap.Models;
using ProiectTap.Interfaces;
using ProiectTap.Decorators;


namespace ProiectTap
{
    public partial class RezervariForm : Form
    {
        List<Rezervare> rezervari;
        List<Client> clients;
        List<RezervareContinut> continuturi;
        List<Camera> camere;

        RezervareRepository _rezervariRepo;
        ClientRepository _clientRepo;
        RezervareContinut _continut;
        UtilizatorRepository _utilizatorRepo;
        RezervareContinutRepository _rezervareContinutRepository;
        CameraRepository _cameraRepo;

        RezervareContinutDecorator decorator;
        Rezervare _rezervare;
        string _buttonPressed;

        public RezervariForm()
        {
            InitializeComponent();
            _rezervariRepo = new RezervareRepository();
            _clientRepo = new ClientRepository();
            _utilizatorRepo = UtilizatorRepository.Instance;
            _rezervareContinutRepository = new RezervareContinutRepository();
            _cameraRepo = new CameraRepository();
            decorator = new RezervareContinutDecorator();
        }

        public void A1(Boolean v)
        {
            confirmareButon.Enabled = v;
            renuntareButon.Enabled = v;
            adaugareRezButon.Enabled = !v;
            modificareRezButon.Enabled = !v;
            stergereRezButon.Enabled = !v;
            adaugareRezConButon.Enabled = !v;
            modificareRezConButon.Enabled = !v;
            stergereRezConButon.Enabled = !v;
        }

        public void A2(Boolean v)
        {
            confirmareButon.Enabled = v;
            renuntareButon.Enabled = !v;
            adaugareRezConButon.Enabled = !v;
            //modificareRezConButon.Enabled = !v;
            //stergereRezConButon.Enabled = !v;
        }

        private void RezervariForm_Load(object sender, EventArgs e)
        {
            LoadRezervari();
            LoadClienti();
            LoadCamere();
            this.gridRezervari.ReadOnly = true;
            this.gridRezervari.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.gridRezervariContinut.ReadOnly = true;
            this.gridRezervariContinut.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            A1(false);
        }

        private void LoadRezervari()
        {
            rezervari = _rezervariRepo.GetAllRezervari();
            this.gridRezervari.DataSource = rezervari;
            this.gridRezervari.Columns["IdClient"].Visible = false;
            this.gridRezervari.Columns["IdUtilizator"].Visible = false;
            this.gridRezervari.Columns["DataRezervare"].DefaultCellStyle.Format = "dd/MM/yyyy";
            this.gridRezervari.ReadOnly = true;
            this.gridRezervari.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void LoadCamere()
        {
            camere = _cameraRepo.GetAllCamere();
            this.cameraComboBox.DataSource = camere;
            cameraComboBox.DisplayMember = "NrCamera";
            cameraComboBox.ValueMember = "IdCamera";
        }

        public void LoadContinuturi(int idRezervare)
        {
            this.continuturi = _rezervareContinutRepository.GetContinuturi(idRezervare);
        }

        public void LoadClienti()
        {
            clients = _clientRepo.GetAllClients();
            this.clientComboBox.DataSource = clients;
            clientComboBox.DisplayMember = "NumeClient";
            clientComboBox.ValueMember = "IdClient";
        }

        private void adaugareRezButon_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            this._buttonPressed = button.Name;
            A1(true);
        }

        private void modificareRezButon_Click(object sender, EventArgs e)
        {
            if (_rezervare == null)
            {
                MessageBox.Show("Un rand din tabela de rezervari trebuie selectat!");
                return;
            }
            foreach (Client client in clientComboBox.Items)
            {
                if (client.NumeClient == _rezervare.NumeClient)
                {
                    clientComboBox.SelectedItem = client;
                    break;
                }
            }
            Button button = sender as Button;
            this._buttonPressed = button.Name;
            A1(true);
            
            
        }

        private void stergereRezButon_Click(object sender, EventArgs e)
        {
            if (_rezervare == null) 
            {
                MessageBox.Show("Un rand din tabela de rezervari trebuie selectat!");
                return;
            }
            Button button = sender as Button;
            this._buttonPressed = button.Name;
            A1(true);
            
            
        }

        private void adaugareRezConButon_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            this._buttonPressed = button.Name;
            A1(true);
        }

        private void modificareRezConButon_Click(object sender, EventArgs e)
        {
            if (_continut == null)
            {
                MessageBox.Show("Un rand din tabela de continuturi trebuie selectat!");
                return;
            }
            foreach (Camera camera in cameraComboBox.Items)
            {
                if (camera.NrCamera == _continut.NrCamera)
                {
                    cameraComboBox.SelectedItem = camera;
                    break;
                }
            }

            dateTimePicker1.Value = _continut.DataCazarii;
            numericUpDown1.Value = _continut.NrZile;
            Button button = sender as Button;
            this._buttonPressed = button.Name;
            A1(true);
        }

        private void stergereRezConButon_Click(object sender, EventArgs e)
        {
            if (_continut == null)
            {
                MessageBox.Show("Un rand din tabela de continuturi trebuie selectat!");
                return;
            }
            Button button = sender as Button;
            this._buttonPressed = button.Name;
            A1(true);
        }

        private void salvareButon_Click(object sender, EventArgs e)
        {
            if (this._buttonPressed == "adaugareRezButon")
            {
                Client client = (Client)this.clientComboBox.SelectedItem;
                Rezervare rezervare = new Rezervare()
                {
                    NrRezervare = -1,
                    DataRezervare = DateTime.Now.Date,
                    IdClient = (int)this.clientComboBox.SelectedValue,
                    IdUtilizator = _utilizatorRepo.GetUserId(),
                    NumeClient = client.NumeClient,

                };
                
                _rezervariRepo.AddRezervare(rezervare);
                LoadRezervari();
                int idRezervare = rezervari.Max(r => r.NrRezervare);
                SelecteazaRezervare(idRezervare);
                GetSelectedRowRezervare();
                
                //A1(false);
                A2(false);
            }
            else if(this._buttonPressed == "modificareRezButon")
            {
                Client client = (Client)this.clientComboBox.SelectedItem;
                Rezervare rezervare = new Rezervare()
                {
                    NrRezervare = _rezervare.NrRezervare,
                    DataRezervare = DateTime.Now.Date,
                    IdClient = (int)this.clientComboBox.SelectedValue,
                    IdUtilizator = _utilizatorRepo.GetUserId(),
                    NumeClient = client.NumeClient,

                };

                _rezervariRepo.UpdateRezervare(rezervare);
                LoadRezervari();
                A1(false);
            }
            else if (this._buttonPressed == "stergereRezButon")
            {

                _rezervareContinutRepository.RemoveAllContinuturi(this._rezervare.NrRezervare);
                _rezervariRepo.RemoveRezervare(this._rezervare.NrRezervare);
                LoadRezervari();
                A1(false);
            }
            else if(this._buttonPressed == "adaugareRezConButon")
            {
                int idCamera = (int)cameraComboBox.SelectedValue;
                RezervareContinut continut = new RezervareContinut()
                {
                    IdRezervare = _rezervare.NrRezervare,
                    Nrc = _rezervareContinutRepository.GetNextNrc(_rezervare.NrRezervare) + 1,
                    IdCamera = idCamera,
                    NrCamera = -1,
                    DataCazarii = dateTimePicker1.Value.Date,
                    PretZi = camere.FirstOrDefault(c => c.IdCamera == idCamera).PretZi,
                    NrZile = (int)numericUpDown1.Value

                };
                
                
                _rezervareContinutRepository.AddContinut(continut);

                SelecteazaRezervare(_rezervare.NrRezervare);
                GetSelectedRowRezervare();
                this.totalBox.Text = decorator.TotalSum(continuturi).ToString();
                A1(false);
                
                
            }
            else if (this._buttonPressed == "modificareRezConButon")
            {
                int idCamera = (int)cameraComboBox.SelectedValue;
                RezervareContinut continut = new RezervareContinut()
                {
                    IdRezervare = _rezervare.NrRezervare,
                    Nrc = _rezervareContinutRepository.GetNextNrc(_rezervare.NrRezervare),
                    IdCamera = idCamera,
                    NrCamera = -1,
                    DataCazarii = dateTimePicker1.Value.Date,
                    PretZi = camere.FirstOrDefault(c => c.IdCamera == idCamera).PretZi,
                    NrZile = (int)numericUpDown1.Value

                };
                int Nrc = _rezervareContinutRepository.GetNextNrc(_rezervare.NrRezervare);
                _rezervareContinutRepository.UpdateContinut(continut);
                SelecteazaRezervare(_rezervare.NrRezervare);
                GetSelectedRowRezervare();
                this.totalBox.Text = decorator.TotalSum(continuturi).ToString();
                A1(false);
            }
            else if (this._buttonPressed == "stergereRezConButon")
            {
                if(continuturi.Count == 1)
                {
                    _rezervareContinutRepository.RemoveContinut(_continut.IdRezervare, _continut.Nrc);
                    _rezervariRepo.RemoveRezervare(this._rezervare.NrRezervare);
                    LoadRezervari();
                }
                else
                {
                    _rezervareContinutRepository.RemoveContinut(_continut.IdRezervare, _continut.Nrc);
                }

                SelecteazaRezervare(_rezervare.NrRezervare);
                GetSelectedRowRezervare();
                this.totalBox.Text = decorator.TotalSum(continuturi).ToString();
                A1(false);
            }

        }

        private void renuntareButon_Click(object sender, EventArgs e)
        {
            if (this.continuturi.Count == 0) //&& _buttonPressed == "adaugareRezButon")
            {
                var confirmResult = MessageBox.Show("Cel putin un continut trebuie adaugat la crearea unei rezervari, in caz contrat rezervarea se va sterge?",
                                        "Continuati?",
                                        MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.No)
                {
                    _rezervariRepo.RemoveRezervare(_rezervare.NrRezervare);
                    LoadRezervari();
                    A1(false);
                }
            }
            else
            {
                A1(false);
            }

            Button button = sender as Button;
            this._buttonPressed = button.Name;

        }

        private void selection_Changed(object sender, EventArgs e)
        {
            if (gridRezervari.Rows.Count > 0 && gridRezervari.SelectedRows.Count > 0)
            {
                _rezervare = GetSelectedRowRezervare();

            }

            
            if (this._buttonPressed == "modificareRezButon")
            {
                foreach (Client client in clientComboBox.Items)
                {
                    if (client.NumeClient == _rezervare.NumeClient)
                    {
                        clientComboBox.SelectedItem = client;
                        break;
                    }
                }
            }

        }

        private void selection_ChangedContinut(object sender, EventArgs e)
        {
            if (gridRezervariContinut.Rows.Count > 0 && gridRezervariContinut.SelectedRows.Count > 0)
            {
                _continut = GetSelectedRowContinut();
                

            }

            if (this._buttonPressed == "modificareRezConButon")
            {
                foreach (Camera camera in cameraComboBox.Items)
                {
                    if (camera.NrCamera == _continut.NrCamera)
                    {
                        cameraComboBox.SelectedItem = camera;
                        break;
                    }
                }

                dateTimePicker1.Value = _continut.DataCazarii;
                numericUpDown1.Value = _continut.NrZile;
            }

        }

        private void SelecteazaRezervare(int nrRezervare)
        {
            foreach (DataGridViewRow row in gridRezervari.Rows)
            {
                if (row.Cells["NrRezervare"].Value != null &&
                    (int)row.Cells["NrRezervare"].Value == nrRezervare)
                {
                    gridRezervari.ClearSelection();                
                    row.Selected = true;                           
                    gridRezervari.FirstDisplayedScrollingRowIndex = row.Index; 
                    break;
                }
            }
        }

        private Rezervare GetSelectedRowRezervare()
        {
            if (gridRezervari.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gridRezervari.SelectedRows[0];

                int idRezervare = int.Parse(selectedRow.Cells["NrRezervare"].Value.ToString());
                DateTime dataRezervare = DateTime.Parse(selectedRow.Cells["DataRezervare"].Value.ToString());
                int idClient = int.Parse(selectedRow.Cells["IdClient"].Value.ToString());
                int idUtilizator = int.Parse(selectedRow.Cells["IdUtilizator"].Value.ToString());
                string numeClient = selectedRow.Cells["NumeClient"].Value.ToString();

                Rezervare rezervare = new Rezervare()
                {
                   NrRezervare = idRezervare,
                   DataRezervare = dataRezervare,
                   IdClient = idClient,
                   IdUtilizator = idUtilizator,
                   NumeClient = numeClient
                };
                this.continuturi = _rezervareContinutRepository.GetContinuturi(rezervare.NrRezervare);
                this.gridRezervariContinut.DataSource = this.continuturi;
                this.gridRezervariContinut.Columns["IdRezervare"].Visible = false;
                this.gridRezervariContinut.Columns["Nrc"].Visible = false;
                this.gridRezervariContinut.Columns["IdCamera"].Visible = false;
                this.gridRezervariContinut.Columns["DataCazarii"].DefaultCellStyle.Format = "dd/MM/yyyy";
                this.totalBox.Text = decorator.TotalSum(continuturi).ToString();
                return rezervare;
            }

            MessageBox.Show("Nu există niciun rând selectat!");
            return null;

        }

        private RezervareContinut GetSelectedRowContinut()
        {
            if (gridRezervariContinut.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gridRezervariContinut.SelectedRows[0];

                int idRezervare = int.Parse(selectedRow.Cells["IdRezervare"].Value.ToString());
                int nrc = int.Parse(selectedRow.Cells["Nrc"].Value.ToString());
                int idCamera = int.Parse(selectedRow.Cells["IdCamera"].Value.ToString());
                int nrCamera = int.Parse(selectedRow.Cells["NrCamera"].Value.ToString());
                DateTime dataCazarii = DateTime.Parse(selectedRow.Cells["DataCazarii"].Value.ToString());
                int pretZi = int.Parse(selectedRow.Cells["PretZi"].Value.ToString());
                int NrZile = int.Parse(selectedRow.Cells["NrZile"].Value.ToString());
                

                RezervareContinut continut = new RezervareContinut()
                {
                    IdRezervare = idRezervare,
                    Nrc = nrc,
                    IdCamera = idCamera,
                    NrCamera = nrCamera,
                    DataCazarii = dataCazarii,
                    PretZi = pretZi,
                    NrZile = NrZile
                };
                
                return continut;
            }

            MessageBox.Show("Nu există niciun rând selectat!");
            return null;

        }


    }
}
