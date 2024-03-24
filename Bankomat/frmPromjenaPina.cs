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
    public partial class frmPromjenaPina : Form
    {
        private Korisnik korisnik;
        BankomatDbContext db = new BankomatDbContext();

        public frmPromjenaPina(Korisnik korisnik)
        {
            InitializeComponent();
            this.korisnik = korisnik;
        }

        private void frmPromjenaPina_Load(object sender, EventArgs e)
        {
            lblStariPin.Text = korisnik.Sifra;
        }

        private void lblIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                if (txtNoviPin.Text == txtPotvrdaPina.Text)
                {
                    korisnik.Sifra = txtNoviPin.Text;
                    db.Entry(korisnik).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    lblStariPin.Text = txtNoviPin.Text;
                    MessageBox.Show("Šifra uspješno promijenjena!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Šifre se ne poklapaju!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Niste unijeli validnu šifru!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private bool Validiraj()
        {
            return !string.IsNullOrWhiteSpace(txtNoviPin.Text) && !string.IsNullOrWhiteSpace(txtPotvrdaPina.Text);
        }
    }
}
