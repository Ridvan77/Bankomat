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
    public partial class frmPrijava : Form
    {
        BankomatDbContext db = new BankomatDbContext();
        public frmPrijava()
        {
            InitializeComponent();
        }

        private void lblIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                if (db.Korisnici.ToList().Exists(x => x.Id == int.Parse(txtBrojRacuna.Text)))
                {
                    List<Korisnik> odabraniKorisnik = db.Korisnici.Where(x => x.Id == int.Parse(txtBrojRacuna.Text)).ToList();
                    if (txtSifra.Text == odabraniKorisnik[0].Sifra)
                    {
                        this.Hide();
                        frmMeni frmMeni = new frmMeni(odabraniKorisnik[0]);
                        frmMeni.ShowDialog();
                        txtBrojRacuna.Text = "";
                        txtSifra.Text = "";
                        this.Show();
                    }
                    else
                        MessageBox.Show("Pogresna sifra!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Pogresan broj racuna!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Niste popunili zahtjevana polja!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool Validiraj()
        {
            return !String.IsNullOrEmpty(txtBrojRacuna.Text) && !String.IsNullOrEmpty(txtSifra.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmIzradaRacuna frmIzradaRacuna = new frmIzradaRacuna();
            frmIzradaRacuna.ShowDialog();
            this.Show();
        }
    }
}
