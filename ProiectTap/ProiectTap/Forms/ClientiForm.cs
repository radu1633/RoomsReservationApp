using ProiectTap.Decorators;
using ProiectTap.Models;
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

namespace ProiectTap
{
    public partial class ClientiForm: Form
    {
        ClientRepository _repo;
        RezervareRepository _rezervareRepo;
        RezervareContinutRepository _rezervareContinutRepo;
        List<Client> clients;
        string _buttonPressed;
        int _id;
        Client _client;
        public ClientiForm()
        {
            InitializeComponent();
            _repo = new ClientRepository();
            _rezervareRepo = new RezervareRepository();
            _rezervareContinutRepo = new RezervareContinutRepository();
        }

        public void A1(Boolean v)
        {
            //numeClientText.Enabled = v;
            //prenumeClient.Enabled = v;
            //nrTelefonText.Enabled = v;
            salavareButon.Enabled = v;
            renuntareButon.Enabled = v;
            cautareButon.Enabled = !v;
            adaugareButon.Enabled = !v;
            actualizareButon.Enabled = !v;
            stergereButon.Enabled = !v;
        }

        private void ClientiForm_Load(object sender, EventArgs e)
        {
            LoadClients();
            A1(false);
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadClients()
        {
            clients = _repo.GetAllClients();
            this.dataGridView1.DataSource = clients;
            this.dataGridView1.Columns["IdClient"].Visible = false;
            this.dataGridView1.Columns["NumeClient"].Visible = false;
            //this.dataGridView1.Columns["Nume"].Width = 100;
            //this.dataGridView1.Columns["NrTelefon"].Width = 100;
        }

        private void adaugareButon_Click(object sender, EventArgs e)
        {
            A1(true);
            Button button = sender as Button;
            this._buttonPressed = button.Text;
        }

        private void stergereButon_Click(object sender, EventArgs e)
        {
            A1(true);
            Button button = sender as Button;
            this._buttonPressed = button.Text;
            
        }

        private void actualizareButon_Click(object sender, EventArgs e)
        {
            A1(true);
            numeClientText.Text = _client.Nume;
            prenumeClient.Text = _client.Prenume;
            nrTelefonText.Text = _client.NrTelefon;
            Button button = sender as Button;
            this._buttonPressed = button.Text;
        }

        private void cautareButon_Click(object sender, EventArgs e)
        {
            A1(true);
            Button button = sender as Button;
            this._buttonPressed = button.Text;
        }

        private void salavareButon_Click(object sender, EventArgs e)
        {
            if (this._buttonPressed == "Adaugare")
            {
                Client client = new Client()
                {
                    IdClient = -1,
                    Nume = numeClientText.Text,
                    Prenume = prenumeClient.Text,
                    NrTelefon = nrTelefonText.Text,
                };
                var decorator = new ClientDecorator(client);
                if(decorator.IsValid() == true && decorator.AlreadyExists(this.clients) == false)
                {
                    _repo.AddClient(client);
                    LoadClients();
                    numeClientText.Text = "";
                    nrTelefonText.Text = "";
                    prenumeClient.Text = "";
                    A1(false);
                }
                
            }
            else if (this._buttonPressed == "Modificare")
            {
                Client client = new Client()
                {
                    IdClient = this._client.IdClient,
                    Nume = numeClientText.Text,
                    Prenume = prenumeClient.Text,
                    NrTelefon = nrTelefonText.Text,
                };
                var decorator = new ClientDecorator(client);
                if (decorator.IsValid() == true )
                {
                    _repo.UpdateClient(client);
                    LoadClients();
                    numeClientText.Text = "";
                    nrTelefonText.Text = "";
                    prenumeClient.Text = "";
                    A1(false);
                }
                
            }
            else if(this._buttonPressed == "Stergere")
            {
                var confirmResult = MessageBox.Show("Odata cu stergerea unui client, se vor sterge si rezervarile facute de acesta. \n" +
                                       "Doriti sa continuati?",
                                        "Warning",
                                        MessageBoxButtons.YesNo);
                if(confirmResult == DialogResult.Yes)
                {
                    int idRezervare = _rezervareRepo.GetRezervareByClient(this._client.IdClient);
                    if(idRezervare == -1)
                    {
                        _repo.RemoveClient(this._client.IdClient);
                        LoadClients();
                        A1(false);
                    }
                    else
                    {
                        _rezervareContinutRepo.RemoveAllContinuturi(idRezervare);
                        _rezervareRepo.RemoveRezervare(idRezervare);
                        _repo.RemoveClient(this._client.IdClient);
                        LoadClients();
                        A1(false);
                    }
                    
                }
                else
                {
                    A1(false);
                }
                
            }
            else
            {

                this.dataGridView1.DataSource = _repo.GetFilteredClients(numeClientText.Text, prenumeClient.Text, nrTelefonText.Text);
                salavareButon.Enabled = false;
                numeClientText.Enabled = false;
                nrTelefonText.Enabled = false;
                prenumeClient.Enabled = false;
            }

        }

        private void renuntareButon_Click(object sender, EventArgs e)
        {
            numeClientText.Text = "";
            nrTelefonText.Text = "";
            prenumeClient.Text = "";
            LoadClients();
            A1(false);
        }

        private void selection_Changed(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.SelectedRows.Count > 0)
            {
                _client = GetSelectedRowClient();
            }
            
            if(this._buttonPressed == "Actualizare")
            {
                numeClientText.Text = _client.Nume;
                prenumeClient.Text = _client.Prenume;
                nrTelefonText.Text = _client.NrTelefon;
            }
            
        }

        private Client GetSelectedRowClient()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                Client client = new Client()
                {
                    IdClient = int.Parse(selectedRow.Cells["IdClient"].Value.ToString()),
                    Nume = selectedRow.Cells["Nume"].Value.ToString(),
                    Prenume = selectedRow.Cells["Prenume"].Value.ToString(),
                    NrTelefon = selectedRow.Cells["NrTelefon"].Value.ToString(),
                };
                
                return client;
            }
            
            MessageBox.Show("Nu există niciun rând selectat!");
            return null;
            
        }

        

        
    }
}
