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
    public partial class frmBrzaIsplata : Form
    {
        private Korisnik korisnik;
        BankomatDbContext db = new BankomatDbContext();

        public frmBrzaIsplata(Korisnik korisnik)
        {
            InitializeComponent();
            this.korisnik = korisnik;
        }

        private void frmBrzaIsplata_Load(object sender, EventArgs e)
        {
            lblStanjeRacuna.Text = korisnik.StanjeRacuna.ToString() + " KM";
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

        private void Isplati(float iznos)
        {
            if (iznos <= korisnik.StanjeRacuna)
            {
                korisnik.StanjeRacuna -= iznos;
                Transakcija transakcija = new Transakcija()
                {
                    BrojRacuna = korisnik.Id,
                    Tip = "Isplata",
                    Iznos = iznos,
                    Datum = DateTime.Now
                };
                db.Add(transakcija);
                db.Entry(korisnik).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Isplata uspješna!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblStanjeRacuna.Text = korisnik.StanjeRacuna.ToString() + " KM";
            }
            else
                MessageBox.Show("Nedovoljno sredstava!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Isplati(10);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Isplati(20);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Isplati(50);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Isplati(100);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Isplati(200);
        }
    }
}
