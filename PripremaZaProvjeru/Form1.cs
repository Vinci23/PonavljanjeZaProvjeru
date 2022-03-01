using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PripremaZaProvjeru
{
    
    public partial class Form1 : Form
    {
        List<Vozilo> listaVozila = new List<Vozilo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            Vozilo vozilo = new Vozilo(cmbVrsta.Text,txtNaziv.Text,txtMarka.Text,dtpGodPro.Value,trckSnaga.Value);

            listaVozila.Add(vozilo);
            MessageBox.Show("Uspješan unos","Uspjeh",MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void trckSnaga_Scroll(object sender, EventArgs e)
        {
            lblSnaga.Text = trckSnaga.Value.ToString();
        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {
            rtbIspis.Clear();
            foreach (Vozilo vozilo in listaVozila)
            {
                rtbIspis.AppendText(vozilo.ToString());
            }
        }
    }
}
