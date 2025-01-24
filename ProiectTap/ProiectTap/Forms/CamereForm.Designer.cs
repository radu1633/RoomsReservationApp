namespace ProiectTap
{
    partial class CamereForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nrCameraLabel = new System.Windows.Forms.Label();
            this.nrLocuriLabel = new System.Windows.Forms.Label();
            this.etajLabel = new System.Windows.Forms.Label();
            this.pretZiLabel = new System.Windows.Forms.Label();
            this.spImagineLabel = new System.Windows.Forms.Label();
            this.nrCameraText = new System.Windows.Forms.TextBox();
            this.nrLocuriText = new System.Windows.Forms.TextBox();
            this.etajText = new System.Windows.Forms.TextBox();
            this.pretZiText = new System.Windows.Forms.TextBox();
            this.spImaginePicker = new System.Windows.Forms.OpenFileDialog();
            this.spImagineText = new System.Windows.Forms.TextBox();
            this.incarcaButon = new System.Windows.Forms.Button();
            this.spImagineBox = new System.Windows.Forms.PictureBox();
            this.adaugareButon = new System.Windows.Forms.Button();
            this.modificareButon = new System.Windows.Forms.Button();
            this.stergereButon = new System.Windows.Forms.Button();
            this.cautareButon = new System.Windows.Forms.Button();
            this.confirmareButon = new System.Windows.Forms.Button();
            this.renuntareButon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spImagineBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(413, 307);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.selection_Changed);
            // 
            // nrCameraLabel
            // 
            this.nrCameraLabel.AutoSize = true;
            this.nrCameraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrCameraLabel.Location = new System.Drawing.Point(457, 84);
            this.nrCameraLabel.Name = "nrCameraLabel";
            this.nrCameraLabel.Size = new System.Drawing.Size(121, 18);
            this.nrCameraLabel.TabIndex = 1;
            this.nrCameraLabel.Text = "Numarul camerei";
            // 
            // nrLocuriLabel
            // 
            this.nrLocuriLabel.AutoSize = true;
            this.nrLocuriLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrLocuriLabel.Location = new System.Drawing.Point(457, 147);
            this.nrLocuriLabel.Name = "nrLocuriLabel";
            this.nrLocuriLabel.Size = new System.Drawing.Size(124, 18);
            this.nrLocuriLabel.TabIndex = 2;
            this.nrLocuriLabel.Text = "Numarul de locuri";
            // 
            // etajLabel
            // 
            this.etajLabel.AutoSize = true;
            this.etajLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etajLabel.Location = new System.Drawing.Point(457, 209);
            this.etajLabel.Name = "etajLabel";
            this.etajLabel.Size = new System.Drawing.Size(33, 18);
            this.etajLabel.TabIndex = 3;
            this.etajLabel.Text = "Etaj";
            // 
            // pretZiLabel
            // 
            this.pretZiLabel.AutoSize = true;
            this.pretZiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretZiLabel.Location = new System.Drawing.Point(457, 276);
            this.pretZiLabel.Name = "pretZiLabel";
            this.pretZiLabel.Size = new System.Drawing.Size(126, 18);
            this.pretZiLabel.TabIndex = 4;
            this.pretZiLabel.Text = "Pretul camerei / zi";
            // 
            // spImagineLabel
            // 
            this.spImagineLabel.AutoSize = true;
            this.spImagineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spImagineLabel.Location = new System.Drawing.Point(460, 335);
            this.spImagineLabel.Name = "spImagineLabel";
            this.spImagineLabel.Size = new System.Drawing.Size(119, 18);
            this.spImagineLabel.TabIndex = 5;
            this.spImagineLabel.Text = "Alegeti o imagine";
            // 
            // nrCameraText
            // 
            this.nrCameraText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrCameraText.Location = new System.Drawing.Point(460, 103);
            this.nrCameraText.Name = "nrCameraText";
            this.nrCameraText.Size = new System.Drawing.Size(100, 24);
            this.nrCameraText.TabIndex = 6;
            // 
            // nrLocuriText
            // 
            this.nrLocuriText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrLocuriText.Location = new System.Drawing.Point(460, 167);
            this.nrLocuriText.Name = "nrLocuriText";
            this.nrLocuriText.Size = new System.Drawing.Size(100, 24);
            this.nrLocuriText.TabIndex = 7;
            // 
            // etajText
            // 
            this.etajText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etajText.Location = new System.Drawing.Point(460, 229);
            this.etajText.Name = "etajText";
            this.etajText.Size = new System.Drawing.Size(100, 24);
            this.etajText.TabIndex = 8;
            // 
            // pretZiText
            // 
            this.pretZiText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretZiText.Location = new System.Drawing.Point(460, 296);
            this.pretZiText.Name = "pretZiText";
            this.pretZiText.Size = new System.Drawing.Size(100, 24);
            this.pretZiText.TabIndex = 9;
            // 
            // spImaginePicker
            // 
            this.spImaginePicker.FileName = "openFileDialog1";
            // 
            // spImagineText
            // 
            this.spImagineText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spImagineText.Location = new System.Drawing.Point(460, 355);
            this.spImagineText.Name = "spImagineText";
            this.spImagineText.ReadOnly = true;
            this.spImagineText.Size = new System.Drawing.Size(100, 24);
            this.spImagineText.TabIndex = 10;
            // 
            // incarcaButon
            // 
            this.incarcaButon.Location = new System.Drawing.Point(567, 353);
            this.incarcaButon.Name = "incarcaButon";
            this.incarcaButon.Size = new System.Drawing.Size(75, 26);
            this.incarcaButon.TabIndex = 11;
            this.incarcaButon.Text = "Incarca";
            this.incarcaButon.UseVisualStyleBackColor = true;
            this.incarcaButon.Click += new System.EventHandler(this.incarcaButon_Click);
            // 
            // spImagineBox
            // 
            this.spImagineBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spImagineBox.Location = new System.Drawing.Point(601, 84);
            this.spImagineBox.Name = "spImagineBox";
            this.spImagineBox.Size = new System.Drawing.Size(251, 236);
            this.spImagineBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spImagineBox.TabIndex = 12;
            this.spImagineBox.TabStop = false;
            // 
            // adaugareButon
            // 
            this.adaugareButon.Location = new System.Drawing.Point(12, 25);
            this.adaugareButon.Name = "adaugareButon";
            this.adaugareButon.Size = new System.Drawing.Size(90, 33);
            this.adaugareButon.TabIndex = 13;
            this.adaugareButon.Text = "Adaugare";
            this.adaugareButon.UseVisualStyleBackColor = true;
            this.adaugareButon.Click += new System.EventHandler(this.adaugareButon_Click);
            // 
            // modificareButon
            // 
            this.modificareButon.Location = new System.Drawing.Point(108, 25);
            this.modificareButon.Name = "modificareButon";
            this.modificareButon.Size = new System.Drawing.Size(103, 33);
            this.modificareButon.TabIndex = 14;
            this.modificareButon.Text = "Modificare";
            this.modificareButon.UseVisualStyleBackColor = true;
            this.modificareButon.Click += new System.EventHandler(this.modificareButon_Click);
            // 
            // stergereButon
            // 
            this.stergereButon.Location = new System.Drawing.Point(217, 25);
            this.stergereButon.Name = "stergereButon";
            this.stergereButon.Size = new System.Drawing.Size(102, 33);
            this.stergereButon.TabIndex = 15;
            this.stergereButon.Text = "Stergere";
            this.stergereButon.UseVisualStyleBackColor = true;
            this.stergereButon.Click += new System.EventHandler(this.stergereButon_Click);
            // 
            // cautareButon
            // 
            this.cautareButon.Location = new System.Drawing.Point(323, 25);
            this.cautareButon.Name = "cautareButon";
            this.cautareButon.Size = new System.Drawing.Size(102, 33);
            this.cautareButon.TabIndex = 16;
            this.cautareButon.Text = "Cautare";
            this.cautareButon.UseVisualStyleBackColor = true;
            this.cautareButon.Click += new System.EventHandler(this.cautareButon_Click);
            // 
            // confirmareButon
            // 
            this.confirmareButon.Location = new System.Drawing.Point(460, 25);
            this.confirmareButon.Name = "confirmareButon";
            this.confirmareButon.Size = new System.Drawing.Size(102, 33);
            this.confirmareButon.TabIndex = 17;
            this.confirmareButon.Text = "Confirmare";
            this.confirmareButon.UseVisualStyleBackColor = true;
            this.confirmareButon.Click += new System.EventHandler(this.confirmareButon_Click);
            // 
            // renuntareButon
            // 
            this.renuntareButon.Location = new System.Drawing.Point(567, 25);
            this.renuntareButon.Name = "renuntareButon";
            this.renuntareButon.Size = new System.Drawing.Size(102, 33);
            this.renuntareButon.TabIndex = 18;
            this.renuntareButon.Text = "Renuntare";
            this.renuntareButon.UseVisualStyleBackColor = true;
            this.renuntareButon.Click += new System.EventHandler(this.renuntareButon_Click);
            // 
            // CamereForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 399);
            this.Controls.Add(this.renuntareButon);
            this.Controls.Add(this.confirmareButon);
            this.Controls.Add(this.cautareButon);
            this.Controls.Add(this.stergereButon);
            this.Controls.Add(this.modificareButon);
            this.Controls.Add(this.adaugareButon);
            this.Controls.Add(this.spImagineBox);
            this.Controls.Add(this.incarcaButon);
            this.Controls.Add(this.spImagineText);
            this.Controls.Add(this.pretZiText);
            this.Controls.Add(this.etajText);
            this.Controls.Add(this.nrLocuriText);
            this.Controls.Add(this.nrCameraText);
            this.Controls.Add(this.spImagineLabel);
            this.Controls.Add(this.pretZiLabel);
            this.Controls.Add(this.etajLabel);
            this.Controls.Add(this.nrLocuriLabel);
            this.Controls.Add(this.nrCameraLabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CamereForm";
            this.Text = "Camere";
            this.Load += new System.EventHandler(this.CamereForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spImagineBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label nrCameraLabel;
        private System.Windows.Forms.Label nrLocuriLabel;
        private System.Windows.Forms.Label etajLabel;
        private System.Windows.Forms.Label pretZiLabel;
        private System.Windows.Forms.Label spImagineLabel;
        private System.Windows.Forms.TextBox nrCameraText;
        private System.Windows.Forms.TextBox nrLocuriText;
        private System.Windows.Forms.TextBox etajText;
        private System.Windows.Forms.TextBox pretZiText;
        private System.Windows.Forms.OpenFileDialog spImaginePicker;
        private System.Windows.Forms.TextBox spImagineText;
        private System.Windows.Forms.Button incarcaButon;
        private System.Windows.Forms.PictureBox spImagineBox;
        private System.Windows.Forms.Button adaugareButon;
        private System.Windows.Forms.Button modificareButon;
        private System.Windows.Forms.Button stergereButon;
        private System.Windows.Forms.Button cautareButon;
        private System.Windows.Forms.Button confirmareButon;
        private System.Windows.Forms.Button renuntareButon;
    }
}