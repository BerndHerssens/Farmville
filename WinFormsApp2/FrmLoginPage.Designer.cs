namespace WinFormsApp2
{
    partial class FrmLoginPage
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
            label1 = new Label();
            label2 = new Label();
            txtNaam = new TextBox();
            txtWachtwoord = new TextBox();
            btnLogin = new Button();
            btnAfsluiten = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 19);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Naam";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 49);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 1;
            label2.Text = "Wachtwoord";
            // 
            // txtNaam
            // 
            txtNaam.Location = new Point(118, 16);
            txtNaam.Name = "txtNaam";
            txtNaam.Size = new Size(196, 23);
            txtNaam.TabIndex = 2;
            // 
            // txtWachtwoord
            // 
            txtWachtwoord.Location = new Point(118, 45);
            txtWachtwoord.Name = "txtWachtwoord";
            txtWachtwoord.PasswordChar = '#';
            txtWachtwoord.Size = new Size(196, 23);
            txtWachtwoord.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(356, 15);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnAfsluiten
            // 
            btnAfsluiten.Location = new Point(356, 44);
            btnAfsluiten.Name = "btnAfsluiten";
            btnAfsluiten.Size = new Size(75, 23);
            btnAfsluiten.TabIndex = 5;
            btnAfsluiten.Text = "Afsluiten";
            btnAfsluiten.UseVisualStyleBackColor = true;
            btnAfsluiten.Click += btnAfsluiten_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 78);
            Controls.Add(btnAfsluiten);
            Controls.Add(btnLogin);
            Controls.Add(txtWachtwoord);
            Controls.Add(txtNaam);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginPage";
            Text = "LoginPage";
            Load += LoginPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNaam;
        private TextBox txtWachtwoord;
        private Button btnLogin;
        private Button btnAfsluiten;
    }
}