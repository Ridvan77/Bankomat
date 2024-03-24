using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Bankomat
{
    public partial class frmUplata : Form
    {
        BankomatDbContext db = new BankomatDbContext();
        private Korisnik korisnik;

        public frmUplata(Korisnik korisnik)
        {
            InitializeComponent();
            this.korisnik = korisnik;
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
            float broj = 0.0f;
            if (Validiraj())
            {
                if (float.TryParse(txtUplata.Text, out broj) && broj >= 0)
                {
                    korisnik.StanjeRacuna += broj;
                    Transakcija transakcija = new Transakcija()
                    {
                        BrojRacuna = korisnik.Id,
                        Tip = "Uplata",
                        Iznos = broj,
                        Datum = DateTime.Now
                    };
                    db.Add(transakcija);
                    db.Entry(korisnik).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Uplata uspješna!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Niste unijeli validan broj!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Niste unijeli validan broj!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private bool Validiraj()
        {
            return !string.IsNullOrEmpty(txtUplata.Text);
        }
    }
}
