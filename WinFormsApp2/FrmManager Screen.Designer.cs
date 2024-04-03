namespace WinFormsApp2
{
    partial class Manager_Screen
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
            lblWelkomManager = new Label();
            menuStrip1 = new MenuStrip();
            werknemersToolStripMenuItem = new ToolStripMenuItem();
            lijstTonenToolStripMenuItem = new ToolStripMenuItem();
            aanmakenToolStripMenuItem = new ToolStripMenuItem();
            bewerkenToolStripMenuItem = new ToolStripMenuItem();
            verwijderenToolStripMenuItem = new ToolStripMenuItem();
            bestandenToolStripMenuItem = new ToolStripMenuItem();
            uitMijnAfdelingToolStripMenuItem = new ToolStripMenuItem();
            lezenToolStripMenuItem = new ToolStripMenuItem();
            bewerkenToolStripMenuItem1 = new ToolStripMenuItem();
            verwijderenToolStripMenuItem1 = new ToolStripMenuItem();
            uitAndereToolStripMenuItem = new ToolStripMenuItem();
            mijnBestandenToolStripMenuItem = new ToolStripMenuItem();
            lezenToolStripMenuItem1 = new ToolStripMenuItem();
            bewerkenToolStripMenuItem2 = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            afsluitenToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelkomManager
            // 
            lblWelkomManager.AutoSize = true;
            lblWelkomManager.Location = new Point(12, 39);
            lblWelkomManager.Name = "lblWelkomManager";
            lblWelkomManager.Size = new Size(38, 15);
            lblWelkomManager.TabIndex = 0;
            lblWelkomManager.Text = "label1";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { werknemersToolStripMenuItem, bestandenToolStripMenuItem, logoutToolStripMenuItem, afsluitenToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(464, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // werknemersToolStripMenuItem
            // 
            werknemersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lijstTonenToolStripMenuItem, aanmakenToolStripMenuItem, bewerkenToolStripMenuItem, verwijderenToolStripMenuItem });
            werknemersToolStripMenuItem.Name = "werknemersToolStripMenuItem";
            werknemersToolStripMenuItem.Size = new Size(85, 20);
            werknemersToolStripMenuItem.Text = "Werknemers";
            // 
            // lijstTonenToolStripMenuItem
            // 
            lijstTonenToolStripMenuItem.Name = "lijstTonenToolStripMenuItem";
            lijstTonenToolStripMenuItem.Size = new Size(180, 22);
            lijstTonenToolStripMenuItem.Text = "Lijst Tonen";
            // 
            // aanmakenToolStripMenuItem
            // 
            aanmakenToolStripMenuItem.Name = "aanmakenToolStripMenuItem";
            aanmakenToolStripMenuItem.Size = new Size(180, 22);
            aanmakenToolStripMenuItem.Text = "Aanmaken";
            // 
            // bewerkenToolStripMenuItem
            // 
            bewerkenToolStripMenuItem.Name = "bewerkenToolStripMenuItem";
            bewerkenToolStripMenuItem.Size = new Size(180, 22);
            bewerkenToolStripMenuItem.Text = "Bewerken";
            // 
            // verwijderenToolStripMenuItem
            // 
            verwijderenToolStripMenuItem.Name = "verwijderenToolStripMenuItem";
            verwijderenToolStripMenuItem.Size = new Size(180, 22);
            verwijderenToolStripMenuItem.Text = "Verwijderen";
            // 
            // bestandenToolStripMenuItem
            // 
            bestandenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { uitMijnAfdelingToolStripMenuItem, uitAndereToolStripMenuItem, mijnBestandenToolStripMenuItem });
            bestandenToolStripMenuItem.Name = "bestandenToolStripMenuItem";
            bestandenToolStripMenuItem.Size = new Size(74, 20);
            bestandenToolStripMenuItem.Text = "Bestanden";
            // 
            // uitMijnAfdelingToolStripMenuItem
            // 
            uitMijnAfdelingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lezenToolStripMenuItem, bewerkenToolStripMenuItem1, verwijderenToolStripMenuItem1 });
            uitMijnAfdelingToolStripMenuItem.Name = "uitMijnAfdelingToolStripMenuItem";
            uitMijnAfdelingToolStripMenuItem.Size = new Size(191, 22);
            uitMijnAfdelingToolStripMenuItem.Text = "Uit Mijn Afdeling";
            // 
            // lezenToolStripMenuItem
            // 
            lezenToolStripMenuItem.Name = "lezenToolStripMenuItem";
            lezenToolStripMenuItem.Size = new Size(180, 22);
            lezenToolStripMenuItem.Text = "Lezen";
            lezenToolStripMenuItem.Click += lezenToolStripMenuItem_Click_1;
            // 
            // bewerkenToolStripMenuItem1
            // 
            bewerkenToolStripMenuItem1.Name = "bewerkenToolStripMenuItem1";
            bewerkenToolStripMenuItem1.Size = new Size(180, 22);
            bewerkenToolStripMenuItem1.Text = "Bewerken";
            bewerkenToolStripMenuItem1.Click += bewerkenToolStripMenuItem1_Click;
            // 
            // verwijderenToolStripMenuItem1
            // 
            verwijderenToolStripMenuItem1.Name = "verwijderenToolStripMenuItem1";
            verwijderenToolStripMenuItem1.Size = new Size(180, 22);
            verwijderenToolStripMenuItem1.Text = "Verwijderen";
            verwijderenToolStripMenuItem1.Click += verwijderenToolStripMenuItem1_Click;
            // 
            // uitAndereToolStripMenuItem
            // 
            uitAndereToolStripMenuItem.Name = "uitAndereToolStripMenuItem";
            uitAndereToolStripMenuItem.Size = new Size(191, 22);
            uitAndereToolStripMenuItem.Text = "Uit Andere Afdelingen";
            // 
            // mijnBestandenToolStripMenuItem
            // 
            mijnBestandenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lezenToolStripMenuItem1, bewerkenToolStripMenuItem2 });
            mijnBestandenToolStripMenuItem.Name = "mijnBestandenToolStripMenuItem";
            mijnBestandenToolStripMenuItem.Size = new Size(191, 22);
            mijnBestandenToolStripMenuItem.Text = "Mijn Bestanden";
            // 
            // lezenToolStripMenuItem1
            // 
            lezenToolStripMenuItem1.Name = "lezenToolStripMenuItem1";
            lezenToolStripMenuItem1.Size = new Size(125, 22);
            lezenToolStripMenuItem1.Text = "Lezen";
            // 
            // bewerkenToolStripMenuItem2
            // 
            bewerkenToolStripMenuItem2.Name = "bewerkenToolStripMenuItem2";
            bewerkenToolStripMenuItem2.Size = new Size(125, 22);
            bewerkenToolStripMenuItem2.Text = "Bewerken";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(57, 20);
            logoutToolStripMenuItem.Text = "Logout";
            // 
            // afsluitenToolStripMenuItem
            // 
            afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            afsluitenToolStripMenuItem.Size = new Size(66, 20);
            afsluitenToolStripMenuItem.Text = "Afsluiten";
            // 
            // Manager_Screen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 255);
            Controls.Add(lblWelkomManager);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Manager_Screen";
            Text = "Manager_Screen";
            Load += Manager_Screen_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelkomManager;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem werknemersToolStripMenuItem;
        private ToolStripMenuItem bestandenToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem afsluitenToolStripMenuItem;
        private ToolStripMenuItem lijstTonenToolStripMenuItem;
        private ToolStripMenuItem aanmakenToolStripMenuItem;
        private ToolStripMenuItem bewerkenToolStripMenuItem;
        private ToolStripMenuItem verwijderenToolStripMenuItem;
        private ToolStripMenuItem uitMijnAfdelingToolStripMenuItem;
        private ToolStripMenuItem lezenToolStripMenuItem;
        private ToolStripMenuItem bewerkenToolStripMenuItem1;
        private ToolStripMenuItem verwijderenToolStripMenuItem1;
        private ToolStripMenuItem uitAndereToolStripMenuItem;
        private ToolStripMenuItem mijnBestandenToolStripMenuItem;
        private ToolStripMenuItem lezenToolStripMenuItem1;
        private ToolStripMenuItem bewerkenToolStripMenuItem2;
    }
}