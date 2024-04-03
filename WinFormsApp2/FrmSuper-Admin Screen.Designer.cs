namespace WinFormsApp2
{
    partial class Super_Admin_Screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            cbJSONEncoderen = new CheckBox();
            cbJSONLezen = new CheckBox();
            cbJSONAanmaken = new CheckBox();
            cbJSONBewerken = new CheckBox();
            cbTXTEncoderen = new CheckBox();
            cbTXTLezen = new CheckBox();
            cbTXTAanmaken = new CheckBox();
            cbTXTBewerken = new CheckBox();
            cbXMLEncoderen = new CheckBox();
            cbXMLLezen = new CheckBox();
            cbXMLAanmaken = new CheckBox();
            cbXMLBewerken = new CheckBox();
            groupBox2 = new GroupBox();
            btnGebruikerAanmaken = new Button();
            cmbGebruikersRol = new ComboBox();
            txtGebruikerPaswoord = new TextBox();
            txtGebruikerVoornaam = new TextBox();
            txtGebruikerNaam = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnAanmakenRol = new Button();
            textBox1 = new TextBox();
            btnCheckAll = new Button();
            btnUncheckAll = new Button();
            button2 = new Button();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbJSONEncoderen);
            groupBox1.Controls.Add(cbJSONLezen);
            groupBox1.Controls.Add(cbJSONAanmaken);
            groupBox1.Controls.Add(cbJSONBewerken);
            groupBox1.Controls.Add(cbTXTEncoderen);
            groupBox1.Controls.Add(cbTXTLezen);
            groupBox1.Controls.Add(cbTXTAanmaken);
            groupBox1.Controls.Add(cbTXTBewerken);
            groupBox1.Controls.Add(cbXMLEncoderen);
            groupBox1.Controls.Add(cbXMLLezen);
            groupBox1.Controls.Add(cbXMLAanmaken);
            groupBox1.Controls.Add(cbXMLBewerken);
            groupBox1.Location = new Point(44, 224);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(264, 339);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rechten";
            // 
            // cbJSONEncoderen
            // 
            cbJSONEncoderen.AutoSize = true;
            cbJSONEncoderen.Location = new Point(6, 302);
            cbJSONEncoderen.Name = "cbJSONEncoderen";
            cbJSONEncoderen.Size = new Size(136, 19);
            cbJSONEncoderen.TabIndex = 11;
            cbJSONEncoderen.Text = "Kan JSON Encoderen";
            cbJSONEncoderen.UseVisualStyleBackColor = true;
            // 
            // cbJSONLezen
            // 
            cbJSONLezen.AutoSize = true;
            cbJSONLezen.Location = new Point(6, 277);
            cbJSONLezen.Name = "cbJSONLezen";
            cbJSONLezen.Size = new Size(110, 19);
            cbJSONLezen.TabIndex = 10;
            cbJSONLezen.Text = "Kan JSON Lezen";
            cbJSONLezen.UseVisualStyleBackColor = true;
            // 
            // cbJSONAanmaken
            // 
            cbJSONAanmaken.AutoSize = true;
            cbJSONAanmaken.Location = new Point(6, 252);
            cbJSONAanmaken.Name = "cbJSONAanmaken";
            cbJSONAanmaken.Size = new Size(137, 19);
            cbJSONAanmaken.TabIndex = 9;
            cbJSONAanmaken.Text = "Kan JSON Aanmaken";
            cbJSONAanmaken.UseVisualStyleBackColor = true;
            // 
            // cbJSONBewerken
            // 
            cbJSONBewerken.AutoSize = true;
            cbJSONBewerken.Location = new Point(6, 227);
            cbJSONBewerken.Name = "cbJSONBewerken";
            cbJSONBewerken.Size = new Size(131, 19);
            cbJSONBewerken.TabIndex = 8;
            cbJSONBewerken.Text = "Kan JSON Bewerken";
            cbJSONBewerken.UseVisualStyleBackColor = true;
            // 
            // cbTXTEncoderen
            // 
            cbTXTEncoderen.AutoSize = true;
            cbTXTEncoderen.Location = new Point(6, 202);
            cbTXTEncoderen.Name = "cbTXTEncoderen";
            cbTXTEncoderen.Size = new Size(127, 19);
            cbTXTEncoderen.TabIndex = 7;
            cbTXTEncoderen.Text = "Kan TXT Encoderen";
            cbTXTEncoderen.UseVisualStyleBackColor = true;
            // 
            // cbTXTLezen
            // 
            cbTXTLezen.AutoSize = true;
            cbTXTLezen.Location = new Point(6, 177);
            cbTXTLezen.Name = "cbTXTLezen";
            cbTXTLezen.Size = new Size(101, 19);
            cbTXTLezen.TabIndex = 6;
            cbTXTLezen.Text = "Kan TXT Lezen";
            cbTXTLezen.UseVisualStyleBackColor = true;
            // 
            // cbTXTAanmaken
            // 
            cbTXTAanmaken.AutoSize = true;
            cbTXTAanmaken.Location = new Point(6, 152);
            cbTXTAanmaken.Name = "cbTXTAanmaken";
            cbTXTAanmaken.Size = new Size(128, 19);
            cbTXTAanmaken.TabIndex = 5;
            cbTXTAanmaken.Text = "Kan TXT Aanmaken";
            cbTXTAanmaken.UseVisualStyleBackColor = true;
            // 
            // cbTXTBewerken
            // 
            cbTXTBewerken.AutoSize = true;
            cbTXTBewerken.Location = new Point(6, 127);
            cbTXTBewerken.Name = "cbTXTBewerken";
            cbTXTBewerken.Size = new Size(122, 19);
            cbTXTBewerken.TabIndex = 4;
            cbTXTBewerken.Text = "Kan TXT Bewerken";
            cbTXTBewerken.UseVisualStyleBackColor = true;
            // 
            // cbXMLEncoderen
            // 
            cbXMLEncoderen.AutoSize = true;
            cbXMLEncoderen.Location = new Point(6, 102);
            cbXMLEncoderen.Name = "cbXMLEncoderen";
            cbXMLEncoderen.Size = new Size(132, 19);
            cbXMLEncoderen.TabIndex = 3;
            cbXMLEncoderen.Text = "Kan XML Encoderen";
            cbXMLEncoderen.UseVisualStyleBackColor = true;
            // 
            // cbXMLLezen
            // 
            cbXMLLezen.AutoSize = true;
            cbXMLLezen.Location = new Point(6, 77);
            cbXMLLezen.Name = "cbXMLLezen";
            cbXMLLezen.Size = new Size(106, 19);
            cbXMLLezen.TabIndex = 2;
            cbXMLLezen.Text = "Kan XML Lezen";
            cbXMLLezen.UseVisualStyleBackColor = true;
            // 
            // cbXMLAanmaken
            // 
            cbXMLAanmaken.AutoSize = true;
            cbXMLAanmaken.Location = new Point(6, 48);
            cbXMLAanmaken.Name = "cbXMLAanmaken";
            cbXMLAanmaken.Size = new Size(133, 19);
            cbXMLAanmaken.TabIndex = 1;
            cbXMLAanmaken.Text = "Kan XML Aanmaken";
            cbXMLAanmaken.UseVisualStyleBackColor = true;
            // 
            // cbXMLBewerken
            // 
            cbXMLBewerken.AutoSize = true;
            cbXMLBewerken.Location = new Point(6, 22);
            cbXMLBewerken.Name = "cbXMLBewerken";
            cbXMLBewerken.Size = new Size(127, 19);
            cbXMLBewerken.TabIndex = 0;
            cbXMLBewerken.Text = "Kan XML Bewerken";
            cbXMLBewerken.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btnGebruikerAanmaken);
            groupBox2.Controls.Add(cmbGebruikersRol);
            groupBox2.Controls.Add(txtGebruikerPaswoord);
            groupBox2.Controls.Add(txtGebruikerVoornaam);
            groupBox2.Controls.Add(txtGebruikerNaam);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(471, 224);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(346, 255);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gebruiker";
            // 
            // btnGebruikerAanmaken
            // 
            btnGebruikerAanmaken.Location = new Point(192, 214);
            btnGebruikerAanmaken.Name = "btnGebruikerAanmaken";
            btnGebruikerAanmaken.Size = new Size(148, 35);
            btnGebruikerAanmaken.TabIndex = 13;
            btnGebruikerAanmaken.Text = "Aanmaken";
            btnGebruikerAanmaken.UseVisualStyleBackColor = true;
            btnGebruikerAanmaken.Click += btnGebruikerAanmaken_Click_1;
            // 
            // cmbGebruikersRol
            // 
            cmbGebruikersRol.FormattingEnabled = true;
            cmbGebruikersRol.Location = new Point(122, 22);
            cmbGebruikersRol.Name = "cmbGebruikersRol";
            cmbGebruikersRol.Size = new Size(218, 23);
            cmbGebruikersRol.TabIndex = 8;
            // 
            // txtGebruikerPaswoord
            // 
            txtGebruikerPaswoord.Location = new Point(122, 110);
            txtGebruikerPaswoord.Name = "txtGebruikerPaswoord";
            txtGebruikerPaswoord.Size = new Size(218, 23);
            txtGebruikerPaswoord.TabIndex = 7;
            // 
            // txtGebruikerVoornaam
            // 
            txtGebruikerVoornaam.Location = new Point(122, 81);
            txtGebruikerVoornaam.Name = "txtGebruikerVoornaam";
            txtGebruikerVoornaam.Size = new Size(218, 23);
            txtGebruikerVoornaam.TabIndex = 6;
            // 
            // txtGebruikerNaam
            // 
            txtGebruikerNaam.Location = new Point(122, 51);
            txtGebruikerNaam.Name = "txtGebruikerNaam";
            txtGebruikerNaam.Size = new Size(218, 23);
            txtGebruikerNaam.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 113);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 5;
            label5.Text = "Paswoord:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 84);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 4;
            label4.Text = "Voornaam:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 25);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 2;
            label2.Text = "Gebruikersrol:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 54);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 3;
            label3.Text = "Naam:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 36);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 0;
            label1.Text = "Benaming gebruikersrol";
            // 
            // btnAanmakenRol
            // 
            btnAanmakenRol.Location = new Point(278, 54);
            btnAanmakenRol.Name = "btnAanmakenRol";
            btnAanmakenRol.Size = new Size(126, 23);
            btnAanmakenRol.TabIndex = 12;
            btnAanmakenRol.Text = "Aanmaken";
            btnAanmakenRol.UseVisualStyleBackColor = true;
            btnAanmakenRol.Click += btnAanmakenRol_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(44, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 23);
            textBox1.TabIndex = 2;
            // 
            // btnCheckAll
            // 
            btnCheckAll.Location = new Point(44, 158);
            btnCheckAll.Name = "btnCheckAll";
            btnCheckAll.Size = new Size(143, 27);
            btnCheckAll.TabIndex = 9;
            btnCheckAll.Text = "Check All";
            btnCheckAll.UseVisualStyleBackColor = true;
            btnCheckAll.Click += btnCheckAll_Click_1;
            // 
            // btnUncheckAll
            // 
            btnUncheckAll.Location = new Point(44, 191);
            btnUncheckAll.Name = "btnUncheckAll";
            btnUncheckAll.Size = new Size(143, 27);
            btnUncheckAll.TabIndex = 10;
            btnUncheckAll.Text = "Uncheck All";
            btnUncheckAll.UseVisualStyleBackColor = true;
            btnUncheckAll.Click += btnUncheckAll_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(668, 508);
            button2.Name = "button2";
            button2.Size = new Size(149, 37);
            button2.TabIndex = 14;
            button2.Text = "Afsluiten";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 152);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 14;
            label6.Text = "label6";
            // 
            // Super_Admin_Screen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 582);
            Controls.Add(button2);
            Controls.Add(btnCheckAll);
            Controls.Add(btnAanmakenRol);
            Controls.Add(btnUncheckAll);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Super_Admin_Screen";
            Text = "Super_Admin_Screen";
            Load += Super_Admin_Screen_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private CheckBox cbJSONEncoderen;
        private CheckBox cbJSONLezen;
        private CheckBox cbJSONAanmaken;
        private CheckBox cbJSONBewerken;
        private CheckBox cbTXTEncoderen;
        private CheckBox cbTXTLezen;
        private CheckBox cbTXTAanmaken;
        private CheckBox cbTXTBewerken;
        private CheckBox cbXMLEncoderen;
        private CheckBox cbXMLLezen;
        private CheckBox cbXMLAanmaken;
        private CheckBox cbXMLBewerken;
        private Button btnGebruikerAanmaken;
        private ComboBox cmbGebruikersRol;
        private TextBox txtGebruikerPaswoord;
        private TextBox txtGebruikerVoornaam;
        private TextBox txtGebruikerNaam;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label3;
        private Button btnAanmakenRol;
        private TextBox textBox1;
        private Button btnCheckAll;
        private Button btnUncheckAll;
        private Button button2;
        private Label label6;
    }
}