namespace Bankomat
{
    public partial class frmBankomat : Form
    {
        public frmBankomat()
        {
            InitializeComponent();
        }

        private void frmBankomat_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            pBPocetna.Increment(1);
            lblProgressBar.Text = pBPocetna.Value.ToString() + "%";
            if (pBPocetna.Value == 100)
            {
                timer.Stop();
                timer.Enabled = false;
                frmPrijava Prijava = new frmPrijava();
                this.Hide();
                Prijava.ShowDialog();
            }
        }
    }
}
