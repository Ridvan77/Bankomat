using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankomat
{
    public partial class frmIzradaRacuna : Form
    {
        BankomatDbContext db = new BankomatDbContext();
        public frmIzradaRacuna()
        {
            InitializeComponent();
        }

        private void lblIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                Korisnik korisnik = new Korisnik()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Adresa = txtAdresa.Text,
                    Telefon = txtTelefon.Text,
                    Sifra = txtSifra.Text,
                    Email = txtEmail.Text,
                    Spol = cbSpol.Text == "Muški" ? false : true,
                    Posao = cbPosao.Text,
                    Dob = dtpDob.Value
                };
                db.Add(korisnik);
                db.SaveChanges();
                MessageBox.Show("Korisnik uspješno dodan!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Niste popunili sva polja", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool Validiraj()
        {
            return !string.IsNullOrEmpty(txtIme.Text) &&
                !string.IsNullOrEmpty(txtPrezime.Text) &&
                !string.IsNullOrEmpty(txtAdresa.Text) &&
                !string.IsNullOrEmpty(txtTelefon.Text) &&
                !string.IsNullOrEmpty(txtSifra.Text) &&
                !string.IsNullOrEmpty(cbSpol.Text) &&
                !string.IsNullOrEmpty(cbPosao.Text);
        }
    }
}
