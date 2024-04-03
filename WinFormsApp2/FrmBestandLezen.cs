using System.Text.Json;
using System.Xml;

namespace WinFormsApp2
{
    public partial class FrmBestandLezen : Form
    {
        public FrmBestandLezen()
        {
            InitializeComponent();
        }
        private void FrmBestandLezen_Load(object sender, EventArgs e)
        {
            BewerkVeldenVerbergen();
        }
        List<Grondstof> listVraag = new List<Grondstof>();
        string bestandinhoud;
        string pad = "";
        private void btnBestandKiezen_Click(object sender, EventArgs e)
        {
            txtBestandInhoud.Clear();
            bestandinhoud = "";
            cmbGrondstoffen.DataSource = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Bestand kiezen",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "",
                Filter = "TXT files (*.txt)|*.txt|XML files (*.xml)|*.xml|JSON files (*.json)|*.json|All files (*.*)|*.*",
                AddExtension = true,
                FilterIndex = 4,
                RestoreDirectory = false,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pad = openFileDialog1.FileName;
                if (pad.Contains(".txt"))
                {
                    openFileDialog1.DefaultExt = ".txt";
                    BewerkVeldenVerbergen();
                    TXTSInlezen();
                }
                else if (pad.Contains(".xml"))
                {
                    txtBestandInhoud.Enabled = false;
                    openFileDialog1.DefaultExt = ".xml";
                    BewerkveldenWeergeven();
                    XMLInlezen();

                }
                else if (pad.Contains(".json"))
                {
                    openFileDialog1.DefaultExt = ".json";
                    BewerkveldenWeergeven();
                    JSONInlezen();
                }
                txtPad.Text = pad;
            }
        }

        private void btnBestandOpslaan_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog()
            {
                InitialDirectory = @"C:\",
                Title = "Kies bestandslocatie",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "",
                Filter = "TXT files (*.txt)|*.txt|XML files (*.xml)|*.xml|JSON files (*.json)|*.json|All files (*.*)|*.*",
                AddExtension = true,
                FilterIndex = 4,
                RestoreDirectory = false,
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pad = saveFileDialog1.FileName;
                if (pad.Contains(".txt"))
                {
                    saveFileDialog1.DefaultExt = ".txt";
                    TXTSWegschrijven();
                }
                else if (pad.Contains(".xml")) 
                {
                    saveFileDialog1.DefaultExt = ".xml";
                    GegevenslijstAanpassen();
                    XMLAanmakenEnWegschrijven();
                }
                else if (pad.Contains(".json"))
                {
                    saveFileDialog1.DefaultExt = ".json";
                }
                txtPad.Text = pad;
            }
        }

        private void btnAnnuleer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //eigen methodes - nieuwste update voor readability en reusability
        public void BewerkVeldenVerbergen()
        {
            txtBestandInhoud.Enabled = true;
            txtPad.Enabled = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            txtNaamGrondstof.Enabled = false;
            txtNaamGrondstof.Visible = false;
            txtHoeveelheidGrondstof.Enabled = false;
            txtHoeveelheidGrondstof.Visible = false;
            cmbGrondstoffen.Visible = false;
            cmbGrondstoffen.Enabled = false;
        }
        public void BewerkveldenWeergeven()
        {
            txtBestandInhoud.Enabled = false;
            txtPad.Enabled = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            txtNaamGrondstof.Enabled = true;
            txtNaamGrondstof.Visible = true;
            txtHoeveelheidGrondstof.Enabled = true;
            txtHoeveelheidGrondstof.Visible = true;
            cmbGrondstoffen.Visible = true;
            cmbGrondstoffen.Enabled = true;
        }
        public void TXTSInlezen()
        {
            using (StreamReader reader = new StreamReader(pad))
            {
                while (!reader.EndOfStream)
                {
                    bestandinhoud += reader.ReadLine() + Environment.NewLine;
                }

                txtBestandInhoud.Text = bestandinhoud;
            }
        }
        public void TXTSWegschrijven()
        {
            using (StreamWriter writer = new StreamWriter(pad))
            {
                bestandinhoud += txtBestandInhoud.Text;
                writer.WriteLine(bestandinhoud);
            }
        }
        public void GegevenslijstAanpassen()
        {
            foreach (Grondstof eenGrondstof in listVraag)
            {
                if (cmbGrondstoffen.Text == eenGrondstof.Naam)
                {
                    if (!(String.IsNullOrEmpty(txtNaamGrondstof.Text) && String.IsNullOrEmpty(txtHoeveelheidGrondstof.Text)))
                    {
                        eenGrondstof.Naam = txtNaamGrondstof.Text;
                        eenGrondstof.Hoeveelheid = Convert.ToInt32(txtHoeveelheidGrondstof.Text);
                    }
                    else
                    {
                        eenGrondstof.Naam = eenGrondstof.Naam;
                        eenGrondstof.Hoeveelheid = eenGrondstof.Hoeveelheid;
                    }
                }
            }
        }
        public void XMLInlezen()
        {
            listVraag.Clear();
            cmbGrondstoffen.Items.Clear();
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(pad);
            XmlNodeList nodesGrondstoffen = xmlDocument.SelectNodes("//Grondstof");
            txtBestandInhoud.Text = "<Grondstoffen>" + Environment.NewLine;
            foreach (XmlNode nodeGrondstof in nodesGrondstoffen)
            {
                Grondstof dezeGrondstof = new Grondstof();
                txtBestandInhoud.Text += " <Grondstof>" + Environment.NewLine;
                txtBestandInhoud.Text += "   <Naam> ";
                txtBestandInhoud.Text += nodeGrondstof.ChildNodes[0].InnerText;
                txtBestandInhoud.Text += "  </Naam>" + Environment.NewLine;
                dezeGrondstof.Naam = nodeGrondstof.ChildNodes[0].InnerText;
                txtBestandInhoud.Text += "   <Aantal> ";
                txtBestandInhoud.Text += nodeGrondstof.ChildNodes[1].InnerText;
                txtBestandInhoud.Text += "  </Aantal>" + Environment.NewLine;
                dezeGrondstof.Hoeveelheid = Convert.ToInt32(nodeGrondstof.ChildNodes[1].InnerText);
                txtBestandInhoud.Text += " </Grondstof>" + Environment.NewLine;
                listVraag.Add(dezeGrondstof);
                cmbGrondstoffen.Items.Add(dezeGrondstof.Naam);
            }
            txtBestandInhoud.Text += "</Grondstoffen>";
            cmbGrondstoffen.SelectedIndex = 0;
        }
        public void XMLAanmakenEnWegschrijven()
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlElement mainRoot = xmlDocument.CreateElement("Grondstoffen");
            xmlDocument.AppendChild(mainRoot);
            foreach (Grondstof dezeGrondstof in listVraag)
            {
                XmlElement root = xmlDocument.CreateElement("Grondstof");
                mainRoot.AppendChild(root);

                XmlElement grondstofNaam = xmlDocument.CreateElement("Naam");
                grondstofNaam.InnerText = dezeGrondstof.Naam.ToString();
                root.AppendChild(grondstofNaam);

                XmlElement grondstofAantal = xmlDocument.CreateElement("Aantal");
                grondstofAantal.InnerText = dezeGrondstof.Hoeveelheid.ToString();
                root.AppendChild(grondstofAantal);
            }
            xmlDocument.Save(pad);
            XMLInlezen();
        }
        public void JSONInlezen()
        {
            using (StreamReader r = new StreamReader(@"Aanbod.json"))
            {
                string json = r.ReadToEnd();
                listVraag = JsonSerializer.Deserialize<List<Grondstof>>(json);
                txtBestandInhoud.Text = json;
            }
        }
    }
}
