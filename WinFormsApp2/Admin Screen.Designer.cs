namespace WinFormsApp2
{
    partial class Admin_Screen
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
            menuStrip1 = new MenuStrip();
            gebruikersToolStripMenuItem = new ToolStripMenuItem();
            gebruikerToolStripMenuItem = new ToolStripMenuItem();
            aanmakenToolStripMenuItem = new ToolStripMenuItem();
            bewerkenToolStripMenuItem = new ToolStripMenuItem();
            verwijderenToolStripMenuItem = new ToolStripMenuItem();
            bestandenToolStripMenuItem = new ToolStripMenuItem();
            lezenToolStripMenuItem = new ToolStripMenuItem();
            bewerkenToolStripMenuItem1 = new ToolStripMenuItem();
            verwijderenToolStripMenuItem1 = new ToolStripMenuItem();
            afdelingenToolStripMenuItem = new ToolStripMenuItem();
            openenToolStripMenuItem = new ToolStripMenuItem();
            aanmakenToolStripMenuItem1 = new ToolStripMenuItem();
            verwijderenToolStripMenuItem2 = new ToolStripMenuItem();
            encryptmentKeyToolStripMenuItem = new ToolStripMenuItem();
            vernieuwenToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            afsluitenToolStripMenuItem = new ToolStripMenuItem();
            lblWelkomAdmin = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gebruikersToolStripMenuItem, logoutToolStripMenuItem, afsluitenToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(557, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gebruikersToolStripMenuItem
            // 
            gebruikersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gebruikerToolStripMenuItem, bestandenToolStripMenuItem, afdelingenToolStripMenuItem, encryptmentKeyToolStripMenuItem });
            gebruikersToolStripMenuItem.Name = "gebruikersToolStripMenuItem";
            gebruikersToolStripMenuItem.Size = new Size(60, 24);
            gebruikersToolStripMenuItem.Text = "Menu";
            // 
            // gebruikerToolStripMenuItem
            // 
            gebruikerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aanmakenToolStripMenuItem, bewerkenToolStripMenuItem, verwijderenToolStripMenuItem });
            gebruikerToolStripMenuItem.Name = "gebruikerToolStripMenuItem";
            gebruikerToolStripMenuItem.Size = new Size(224, 26);
            gebruikerToolStripMenuItem.Text = "Gebruiker ";
            // 
            // aanmakenToolStripMenuItem
            // 
            aanmakenToolStripMenuItem.Name = "aanmakenToolStripMenuItem";
            aanmakenToolStripMenuItem.Size = new Size(170, 26);
            aanmakenToolStripMenuItem.Text = "Aanmaken";
            // 
            // bewerkenToolStripMenuItem
            // 
            bewerkenToolStripMenuItem.Name = "bewerkenToolStripMenuItem";
            bewerkenToolStripMenuItem.Size = new Size(170, 26);
            bewerkenToolStripMenuItem.Text = "Bewerken";
            // 
            // verwijderenToolStripMenuItem
            // 
            verwijderenToolStripMenuItem.Name = "verwijderenToolStripMenuItem";
            verwijderenToolStripMenuItem.Size = new Size(170, 26);
            verwijderenToolStripMenuItem.Text = "Verwijderen";
            // 
            // bestandenToolStripMenuItem
            // 
            bestandenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lezenToolStripMenuItem, bewerkenToolStripMenuItem1, verwijderenToolStripMenuItem1 });
            bestandenToolStripMenuItem.Name = "bestandenToolStripMenuItem";
            bestandenToolStripMenuItem.Size = new Size(224, 26);
            bestandenToolStripMenuItem.Text = "Bestanden";
            // 
            // lezenToolStripMenuItem
            // 
            lezenToolStripMenuItem.Name = "lezenToolStripMenuItem";
            lezenToolStripMenuItem.Size = new Size(224, 26);
            lezenToolStripMenuItem.Text = "Lezen";
            lezenToolStripMenuItem.Click += lezenToolStripMenuItem_Click;
            // 
            // bewerkenToolStripMenuItem1
            // 
            bewerkenToolStripMenuItem1.Name = "bewerkenToolStripMenuItem1";
            bewerkenToolStripMenuItem1.Size = new Size(224, 26);
            bewerkenToolStripMenuItem1.Text = "Bewerken";
            bewerkenToolStripMenuItem1.Click += bewerkenToolStripMenuItem1_Click;
            // 
            // verwijderenToolStripMenuItem1
            // 
            verwijderenToolStripMenuItem1.Name = "verwijderenToolStripMenuItem1";
            verwijderenToolStripMenuItem1.Size = new Size(224, 26);
            verwijderenToolStripMenuItem1.Text = "Verwijderen";
            verwijderenToolStripMenuItem1.Click += verwijderenToolStripMenuItem1_Click;
            // 
            // afdelingenToolStripMenuItem
            // 
            afdelingenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openenToolStripMenuItem, aanmakenToolStripMenuItem1, verwijderenToolStripMenuItem2 });
            afdelingenToolStripMenuItem.Name = "afdelingenToolStripMenuItem";
            afdelingenToolStripMenuItem.Size = new Size(224, 26);
            afdelingenToolStripMenuItem.Text = "Afdelingen";
            // 
            // openenToolStripMenuItem
            // 
            openenToolStripMenuItem.Name = "openenToolStripMenuItem";
            openenToolStripMenuItem.Size = new Size(170, 26);
            openenToolStripMenuItem.Text = "Lezen";
            // 
            // aanmakenToolStripMenuItem1
            // 
            aanmakenToolStripMenuItem1.Name = "aanmakenToolStripMenuItem1";
            aanmakenToolStripMenuItem1.Size = new Size(170, 26);
            aanmakenToolStripMenuItem1.Text = "Aanmaken";
            // 
            // verwijderenToolStripMenuItem2
            // 
            verwijderenToolStripMenuItem2.Name = "verwijderenToolStripMenuItem2";
            verwijderenToolStripMenuItem2.Size = new Size(170, 26);
            verwijderenToolStripMenuItem2.Text = "Verwijderen";
            // 
            // encryptmentKeyToolStripMenuItem
            // 
            encryptmentKeyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vernieuwenToolStripMenuItem });
            encryptmentKeyToolStripMenuItem.Name = "encryptmentKeyToolStripMenuItem";
            encryptmentKeyToolStripMenuItem.Size = new Size(224, 26);
            encryptmentKeyToolStripMenuItem.Text = "Encryptment Key";
            // 
            // vernieuwenToolStripMenuItem
            // 
            vernieuwenToolStripMenuItem.Name = "vernieuwenToolStripMenuItem";
            vernieuwenToolStripMenuItem.Size = new Size(224, 26);
            vernieuwenToolStripMenuItem.Text = "Vernieuwen";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(70, 24);
            logoutToolStripMenuItem.Text = "Logout";
            // 
            // afsluitenToolStripMenuItem
            // 
            afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            afsluitenToolStripMenuItem.Size = new Size(81, 24);
            afsluitenToolStripMenuItem.Text = "Afsluiten";
            // 
            // lblWelkomAdmin
            // 
            lblWelkomAdmin.AutoSize = true;
            lblWelkomAdmin.Location = new Point(14, 52);
            lblWelkomAdmin.Name = "lblWelkomAdmin";
            lblWelkomAdmin.Size = new Size(50, 20);
            lblWelkomAdmin.TabIndex = 1;
            lblWelkomAdmin.Text = "label1";
            // 
            // Admin_Screen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 392);
            Controls.Add(lblWelkomAdmin);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Admin_Screen";
            Text = "Admin_Screen";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gebruikersToolStripMenuItem;
        private ToolStripMenuItem gebruikerToolStripMenuItem;
        private ToolStripMenuItem aanmakenToolStripMenuItem;
        private ToolStripMenuItem bewerkenToolStripMenuItem;
        private ToolStripMenuItem verwijderenToolStripMenuItem;
        private ToolStripMenuItem bestandenToolStripMenuItem;
        private ToolStripMenuItem lezenToolStripMenuItem;
        private ToolStripMenuItem bewerkenToolStripMenuItem1;
        private ToolStripMenuItem verwijderenToolStripMenuItem1;
        private ToolStripMenuItem afdelingenToolStripMenuItem;
        private ToolStripMenuItem openenToolStripMenuItem;
        private ToolStripMenuItem aanmakenToolStripMenuItem1;
        private ToolStripMenuItem verwijderenToolStripMenuItem2;
        private ToolStripMenuItem encryptmentKeyToolStripMenuItem;
        private ToolStripMenuItem vernieuwenToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem afsluitenToolStripMenuItem;
        private Label lblWelkomAdmin;
    }
}