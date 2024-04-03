namespace WinFormsApp2
{
    public partial class Admin_Screen : Form
    {
        public Admin_Screen()
        {
            InitializeComponent();
        }

        private void lezenToolStripMenuItem_Click(object sender, EventArgs e)
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
