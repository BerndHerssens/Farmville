﻿namespace Groep_project_2
{
    partial class FrmVerkoop
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
            btnLeesBestelling = new Button();
            btnLeveren = new Button();
            btnExit = new Button();
            txtPad = new TextBox();
            txtBestellingsbericht = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtBestandInhoud = new TextBox();
            SuspendLayout();
            // 
            // btnLeesBestelling
            // 
            btnLeesBestelling.Location = new Point(12, 12);
            btnLeesBestelling.Name = "btnLeesBestelling";
            btnLeesBestelling.Size = new Size(143, 23);
            btnLeesBestelling.TabIndex = 0;
            btnLeesBestelling.Text = "Lees Bestelling";
            btnLeesBestelling.UseVisualStyleBackColor = true;
            btnLeesBestelling.Click += btnLeesBestelling_Click;
            // 
            // btnLeveren
            // 
            btnLeveren.Location = new Point(12, 41);
            btnLeveren.Name = "btnLeveren";
            btnLeveren.Size = new Size(143, 23);
            btnLeveren.TabIndex = 1;
            btnLeveren.Text = "Leveren";
            btnLeveren.UseVisualStyleBackColor = true;
            btnLeveren.Click += btnLeveren_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(12, 70);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(143, 23);
            btnExit.TabIndex = 2;
            btnExit.Text = "Sluiten";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtPad
            // 
            txtPad.Location = new Point(268, 13);
            txtPad.Name = "txtPad";
            txtPad.Size = new Size(242, 23);
            txtPad.TabIndex = 3;
            // 
            // txtBestellingsbericht
            // 
            txtBestellingsbericht.Location = new Point(268, 38);
            txtBestellingsbericht.Name = "txtBestellingsbericht";
            txtBestellingsbericht.Size = new Size(242, 23);
            txtBestellingsbericht.TabIndex = 4;
            txtBestellingsbericht.Text = "Dank u voor uw bestelling.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 16);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 5;
            label1.Text = "Pad: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 41);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 6;
            label2.Text = "Verkoopbericht:";
            // 
            // txtBestandInhoud
            // 
            txtBestandInhoud.Location = new Point(12, 99);
            txtBestandInhoud.Multiline = true;
            txtBestandInhoud.Name = "txtBestandInhoud";
            txtBestandInhoud.Size = new Size(498, 328);
            txtBestandInhoud.TabIndex = 7;
            // 
            // FrmVerkoop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 450);
            Controls.Add(txtBestandInhoud);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBestellingsbericht);
            Controls.Add(txtPad);
            Controls.Add(btnExit);
            Controls.Add(btnLeveren);
            Controls.Add(btnLeesBestelling);
            Name = "FrmVerkoop";
            Text = "FrmVerkoop";
            Load += FrmVerkoop_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLeesBestelling;
        private Button btnLeveren;
        private Button btnExit;
        private TextBox txtPad;
        private TextBox txtBestellingsbericht;
        private Label label1;
        private Label label2;
        private TextBox txtBestandInhoud;
    }
}