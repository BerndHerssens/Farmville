namespace WinFormsApp2
{
    partial class FrmBestandLezen
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
            txtPad = new TextBox();
            btnBestandKiezen = new Button();
            txtBestandInhoud = new TextBox();
            btnAnnuleer = new Button();
            btnBestandOpslaan = new Button();
            cbEncrypteren = new CheckBox();
            cmbGrondstoffen = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtNaamGrondstof = new TextBox();
            label3 = new Label();
            txtHoeveelheidGrondstof = new TextBox();
            SuspendLayout();
            // 
            // txtPad
            // 
            txtPad.Location = new Point(10, 9);
            txtPad.Margin = new Padding(3, 2, 3, 2);
            txtPad.Name = "txtPad";
            txtPad.Size = new Size(289, 23);
            txtPad.TabIndex = 0;
            // 
            // btnBestandKiezen
            // 
            btnBestandKiezen.Location = new Point(304, 8);
            btnBestandKiezen.Margin = new Padding(3, 2, 3, 2);
            btnBestandKiezen.Name = "btnBestandKiezen";
            btnBestandKiezen.Size = new Size(148, 22);
            btnBestandKiezen.TabIndex = 1;
            btnBestandKiezen.Text = "Bestand kiezen";
            btnBestandKiezen.UseVisualStyleBackColor = true;
            btnBestandKiezen.Click += btnBestandKiezen_Click;
            // 
            // txtBestandInhoud
            // 
            txtBestandInhoud.Location = new Point(10, 34);
            txtBestandInhoud.Margin = new Padding(3, 2, 3, 2);
            txtBestandInhoud.Multiline = true;
            txtBestandInhoud.Name = "txtBestandInhoud";
            txtBestandInhoud.Size = new Size(289, 296);
            txtBestandInhoud.TabIndex = 2;
            // 
            // btnAnnuleer
            // 
            btnAnnuleer.Location = new Point(305, 308);
            btnAnnuleer.Margin = new Padding(3, 2, 3, 2);
            btnAnnuleer.Name = "btnAnnuleer";
            btnAnnuleer.Size = new Size(148, 22);
            btnAnnuleer.TabIndex = 3;
            btnAnnuleer.Text = "Annuleer";
            btnAnnuleer.UseVisualStyleBackColor = true;
            btnAnnuleer.Click += btnAnnuleer_Click;
            // 
            // btnBestandOpslaan
            // 
            btnBestandOpslaan.Location = new Point(305, 34);
            btnBestandOpslaan.Margin = new Padding(3, 2, 3, 2);
            btnBestandOpslaan.Name = "btnBestandOpslaan";
            btnBestandOpslaan.Size = new Size(148, 22);
            btnBestandOpslaan.TabIndex = 4;
            btnBestandOpslaan.Text = "Bestand opslaan";
            btnBestandOpslaan.UseVisualStyleBackColor = true;
            btnBestandOpslaan.Click += btnBestandOpslaan_Click;
            // 
            // cbEncrypteren
            // 
            cbEncrypteren.AutoSize = true;
            cbEncrypteren.Location = new Point(305, 61);
            cbEncrypteren.Name = "cbEncrypteren";
            cbEncrypteren.Size = new Size(116, 19);
            cbEncrypteren.TabIndex = 5;
            cbEncrypteren.Text = "Data encrypteren";
            cbEncrypteren.UseVisualStyleBackColor = true;
            // 
            // cmbGrondstoffen
            // 
            cmbGrondstoffen.FormattingEnabled = true;
            cmbGrondstoffen.Location = new Point(305, 104);
            cmbGrondstoffen.Name = "cmbGrondstoffen";
            cmbGrondstoffen.Size = new Size(121, 23);
            cmbGrondstoffen.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(305, 86);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 7;
            label1.Text = "Grondstoffen:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(305, 130);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 8;
            label2.Text = "Naam grondstof:";
            // 
            // txtNaamGrondstof
            // 
            txtNaamGrondstof.Location = new Point(305, 148);
            txtNaamGrondstof.Name = "txtNaamGrondstof";
            txtNaamGrondstof.Size = new Size(121, 23);
            txtNaamGrondstof.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(305, 174);
            label3.Name = "label3";
            label3.Size = new Size(131, 15);
            label3.TabIndex = 10;
            label3.Text = "Hoeveelheid grondstof:";
            // 
            // txtHoeveelheidGrondstof
            // 
            txtHoeveelheidGrondstof.Location = new Point(305, 192);
            txtHoeveelheidGrondstof.Name = "txtHoeveelheidGrondstof";
            txtHoeveelheidGrondstof.Size = new Size(121, 23);
            txtHoeveelheidGrondstof.TabIndex = 11;
            // 
            // FrmBestandLezen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 342);
            Controls.Add(txtHoeveelheidGrondstof);
            Controls.Add(label3);
            Controls.Add(txtNaamGrondstof);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbGrondstoffen);
            Controls.Add(cbEncrypteren);
            Controls.Add(btnBestandOpslaan);
            Controls.Add(btnAnnuleer);
            Controls.Add(txtBestandInhoud);
            Controls.Add(btnBestandKiezen);
            Controls.Add(txtPad);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmBestandLezen";
            Text = "Bestand lezen";
            Load += FrmBestandLezen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPad;
        private Button btnBestandKiezen;
        private Button btnAnnuleer;
        public TextBox txtBestandInhoud;
        public Button btnBestandOpslaan;
        public CheckBox cbEncrypteren;
        private ComboBox cmbGrondstoffen;
        private Label label1;
        private Label label2;
        private TextBox txtNaamGrondstof;
        private Label label3;
        private TextBox txtHoeveelheidGrondstof;
    }
}