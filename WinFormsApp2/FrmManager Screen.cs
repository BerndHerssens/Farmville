namespace WinFormsApp2
{
    public partial class Manager_Screen : Form
    {
        public Gebruiker ingelogdeGebruikerManager = new Gebruiker();
        public Manager_Screen()
        {
            InitializeComponent();
        }
        private void Manager_Screen_Load(object sender, EventArgs e)
        {

        }

        private void lezenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmBestandLezen frmBestandLezen = new FrmBestandLezen();
            frmBestandLezen.Text = "Bestand lezen";
            frmBestandLezen.txtBestandInhoud.Enabled = false;
            frmBestandLezen.btnBestandOpslaan.Enabled = false;
            frmBestandLezen.btnBestandOpslaan.Visible = false;
            frmBestandLezen.cbEncrypteren.Enabled = false;
            frmBestandLezen.cbEncrypteren.Visible = false;
            frmBestandLezen.ShowDialog();
        }

        private void bewerkenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmBestandLezen frmBestandLezen = new FrmBestandLezen();
            frmBestandLezen.Text = "Bestand bewerken";
            frmBestandLezen.ShowDialog();

        }

        private void verwijderenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmBestandVerwijderen frmBestandVerwijderen = new FrmBestandVerwijderen();
            ShowDialog(frmBestandVerwijderen);
        }
    }
}
