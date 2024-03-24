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
    public partial class frmStanjeRacuna : Form
    {
        private Korisnik korisnik;
        BankomatDbContext db = new BankomatDbContext();

        public frmStanjeRacuna(Korisnik korisnik)
        {
            InitializeComponent();
            this.korisnik = korisnik;
        }

        private void frmStanjeRacuna_Load(object sender, EventArgs e)
        {
            lblBrojRacuna.Text = korisnik.Id.ToString();
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
    }
}
