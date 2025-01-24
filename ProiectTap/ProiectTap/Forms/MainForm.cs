using ProiectTap.Models;
using ProiectTap.Repository;
using System;
using System.Windows.Forms;

namespace ProiectTap
{
    public partial class MainForm : Form
    {
        UtilizatorRepository _repo;
        Utilizator utilizator;
        public MainForm()
        {
            InitializeComponent();
            _repo = UtilizatorRepository.Instance;
        }
        public void A1(Boolean v)
        {
            menuStrip.Visible = !v;
            parolaLabel.Visible = v;
            parolaText.Visible = v;
            numeText.Enabled = v;
            if (v) conectare.Text = "Conectare";
            else conectare.Text = "Deconectare";
        }

        public bool logare_ok()
        {
            if (numeText.Text == "" || parolaText.Text == "")
            {
                MessageBox.Show("Introduceti toate datele!");
                return false;
            }
            
            utilizator = _repo.GetUtilizator(numeText.Text);
           
            if (utilizator == null)
            {
                MessageBox.Show("Utilizatorul nu exista!");
                return false;
            }
            else if (parolaText.Text != utilizator.Parola)
            {
                MessageBox.Show("Parola incorecta!");
                return false;
            }
            else
            {
                _repo.SetUser(utilizator);
                return true;
            }
        }

        private void conectare_click(object sender, EventArgs e)
        {
            if (conectare.Text == "Conectare")
            {
                if (logare_ok()) A1(false);
            }
            else A1(true);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            A1(true);
        }

        private void clientiMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new ClientiForm();
            f.ShowDialog();
        }

        private void camereMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new CamereForm();
            f.ShowDialog();
        }

        private void rezervariMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new RezervariForm();
            f.ShowDialog();
        }
    }
}
