namespace ProiectTap
{
    partial class MainForm
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
            this.numeLabel = new System.Windows.Forms.Label();
            this.numeText = new System.Windows.Forms.TextBox();
            this.parolaText = new System.Windows.Forms.TextBox();
            this.parolaLabel = new System.Windows.Forms.Label();
            this.conectare = new System.Windows.Forms.Button();
            this.labelTitlu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.clientiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camereMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervariMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // numeLabel
            // 
            this.numeLabel.AutoSize = true;
            this.numeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeLabel.Location = new System.Drawing.Point(40, 111);
            this.numeLabel.Name = "numeLabel";
            this.numeLabel.Size = new System.Drawing.Size(64, 25);
            this.numeLabel.TabIndex = 0;
            this.numeLabel.Text = "Nume";
            // 
            // numeText
            // 
            this.numeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeText.Location = new System.Drawing.Point(45, 139);
            this.numeText.Name = "numeText";
            this.numeText.Size = new System.Drawing.Size(197, 26);
            this.numeText.TabIndex = 1;
            // 
            // parolaText
            // 
            this.parolaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parolaText.Location = new System.Drawing.Point(45, 212);
            this.parolaText.Name = "parolaText";
            this.parolaText.Size = new System.Drawing.Size(197, 26);
            this.parolaText.TabIndex = 2;
            // 
            // parolaLabel
            // 
            this.parolaLabel.AutoSize = true;
            this.parolaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parolaLabel.Location = new System.Drawing.Point(40, 184);
            this.parolaLabel.Name = "parolaLabel";
            this.parolaLabel.Size = new System.Drawing.Size(68, 25);
            this.parolaLabel.TabIndex = 3;
            this.parolaLabel.Text = "Parola";
            // 
            // conectare
            // 
            this.conectare.Location = new System.Drawing.Point(45, 280);
            this.conectare.Name = "conectare";
            this.conectare.Size = new System.Drawing.Size(111, 40);
            this.conectare.TabIndex = 4;
            this.conectare.Text = "Conectare";
            this.conectare.UseVisualStyleBackColor = true;
            this.conectare.Click += new System.EventHandler(this.conectare_click);
            // 
            // labelTitlu
            // 
            this.labelTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitlu.Location = new System.Drawing.Point(331, 111);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(457, 88);
            this.labelTitlu.TabIndex = 5;
            this.labelTitlu.Text = "Aplicatie pentru rezervarea camerelor dintr-un hotel";
            this.labelTitlu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(464, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 67);
            this.label1.TabIndex = 6;
            this.label1.Text = "Marin Radu-George";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientiMenuItem,
            this.camereMenuItem,
            this.rezervariMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(822, 47);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "menuStrip";
            // 
            // clientiMenuItem
            // 
            this.clientiMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.clientiMenuItem.Name = "clientiMenuItem";
            this.clientiMenuItem.Size = new System.Drawing.Size(80, 43);
            this.clientiMenuItem.Text = "Clienti";
            this.clientiMenuItem.Click += new System.EventHandler(this.clientiMenuItem_Click);
            // 
            // camereMenuItem
            // 
            this.camereMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.camereMenuItem.Name = "camereMenuItem";
            this.camereMenuItem.Size = new System.Drawing.Size(91, 43);
            this.camereMenuItem.Text = "Camere";
            this.camereMenuItem.Click += new System.EventHandler(this.camereMenuItem_Click);
            // 
            // rezervariMenuItem
            // 
            this.rezervariMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.rezervariMenuItem.Name = "rezervariMenuItem";
            this.rezervariMenuItem.Size = new System.Drawing.Size(103, 43);
            this.rezervariMenuItem.Text = "Rezervari";
            this.rezervariMenuItem.Click += new System.EventHandler(this.rezervariMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 424);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitlu);
            this.Controls.Add(this.conectare);
            this.Controls.Add(this.parolaLabel);
            this.Controls.Add(this.parolaText);
            this.Controls.Add(this.numeText);
            this.Controls.Add(this.numeLabel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Form principal";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numeLabel;
        private System.Windows.Forms.TextBox numeText;
        private System.Windows.Forms.TextBox parolaText;
        private System.Windows.Forms.Label parolaLabel;
        private System.Windows.Forms.Button conectare;
        private System.Windows.Forms.Label labelTitlu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem clientiMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camereMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervariMenuItem;
    }
}

