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
    public partial class frmMeni : Form
    {
        private Korisnik korisnik;

        public frmMeni(Korisnik korisnik)
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
            this.Hide();
            frmUplata frmUplata = new frmUplata(korisnik);
            frmUplata.ShowDialog();
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmIsplata frmIsplata = new frmIsplata(korisnik);
            frmIsplata.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBrzaIsplata frmBrzaIsplata = new frmBrzaIsplata(korisnik);
            frmBrzaIsplata.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStanjeRacuna frmStanjeRacuna = new frmStanjeRacuna(korisnik);
            frmStanjeRacuna.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPromjenaPina frmPromjenaPina = new frmPromjenaPina(korisnik);
            frmPromjenaPina.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProvjeraRacuna frmProvjeraRacuna = new frmProvjeraRacuna(korisnik);
            frmProvjeraRacuna.ShowDialog();
            this.Show();
        }
    }
}
