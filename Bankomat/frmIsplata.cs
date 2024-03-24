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
    public partial class frmIsplata : Form
    {
        BankomatDbContext db = new BankomatDbContext();
        private Korisnik korisnik;

        public frmIsplata(Korisnik korisnik)
        {
            InitializeComponent();
            this.korisnik = korisnik;
        }

        private void frmIsplata_Load(object sender, EventArgs e)
        {
            lblStanjeRacuna.Text = korisnik.StanjeRacuna.ToString();
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

        private bool Validiraj()
        {
            return !string.IsNullOrEmpty(txtIsplata.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float broj = 0.0f;
            if (Validiraj())
            {
                if (float.TryParse(txtIsplata.Text, out broj) && broj > 0)
                {
                    if (broj <= korisnik.StanjeRacuna)
                    {
                        korisnik.StanjeRacuna -= broj;
                        Transakcija transakcija = new Transakcija()
                        {
                            BrojRacuna = korisnik.Id,
                            Tip = "Isplata",
                            Iznos = broj,
                            Datum = DateTime.Now
                        };
                        db.Add(transakcija);
                        db.Entry(korisnik).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Isplata uspješna!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblStanjeRacuna.Text = korisnik.StanjeRacuna.ToString();
                    }
                    else
                        MessageBox.Show("Nedovoljno sredstava!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Niste unijeli validan broj!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Niste unijeli validan broj!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
