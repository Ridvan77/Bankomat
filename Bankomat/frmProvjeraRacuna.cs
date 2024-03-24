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
    public partial class frmProvjeraRacuna : Form
    {
        private Korisnik korisnik;
        BankomatDbContext db = new BankomatDbContext();
        List<Transakcija> transakcije;

        public frmProvjeraRacuna(Korisnik korisnik)
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

        private void frmProvjeraRacuna_Load(object sender, EventArgs e)
        {
            dgvTransakcije.AutoGenerateColumns = false;
            transakcije = db.Transakcije.Where(x => x.BrojRacuna == korisnik.Id).ToList();
            if (transakcije != null)
            {
                dgvTransakcije.DataSource = null;
                dgvTransakcije.DataSource = transakcije;
            }
        }
    }
}
