namespace ProiectTap
{
    partial class RezervariForm
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
            this.gridRezervariContinut = new System.Windows.Forms.DataGridView();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.gridRezervari = new System.Windows.Forms.DataGridView();
            this.adaugareRezButon = new System.Windows.Forms.Button();
            this.modificareRezButon = new System.Windows.Forms.Button();
            this.stergereRezButon = new System.Windows.Forms.Button();
            this.cameraComboBox = new System.Windows.Forms.ComboBox();
            this.cameraLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.adaugareRezConButon = new System.Windows.Forms.Button();
            this.modificareRezConButon = new System.Windows.Forms.Button();
            this.stergereRezConButon = new System.Windows.Forms.Button();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.renuntareButon = new System.Windows.Forms.Button();
            this.confirmareButon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridRezervariContinut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRezervari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridRezervariContinut
            // 
            this.gridRezervariContinut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridRezervariContinut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRezervariContinut.Location = new System.Drawing.Point(12, 219);
            this.gridRezervariContinut.Name = "gridRezervariContinut";
            this.gridRezervariContinut.RowHeadersWidth = 51;
            this.gridRezervariContinut.RowTemplate.Height = 24;
            this.gridRezervariContinut.Size = new System.Drawing.Size(776, 197);
            this.gridRezervariContinut.TabIndex = 0;
            this.gridRezervariContinut.SelectionChanged += new System.EventHandler(this.selection_ChangedContinut);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(17, 193);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(45, 18);
            this.totalLabel.TabIndex = 1;
            this.totalLabel.Text = "Total ";
            // 
            // totalBox
            // 
            this.totalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBox.Location = new System.Drawing.Point(68, 190);
            this.totalBox.Name = "totalBox";
            this.totalBox.ReadOnly = true;
            this.totalBox.Size = new System.Drawing.Size(100, 24);
            this.totalBox.TabIndex = 2;
            // 
            // gridRezervari
            // 
            this.gridRezervari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridRezervari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRezervari.Location = new System.Drawing.Point(13, 13);
            this.gridRezervari.Name = "gridRezervari";
            this.gridRezervari.RowHeadersWidth = 51;
            this.gridRezervari.RowTemplate.Height = 24;
            this.gridRezervari.Size = new System.Drawing.Size(336, 171);
            this.gridRezervari.TabIndex = 3;
            this.gridRezervari.SelectionChanged += new System.EventHandler(this.selection_Changed);
            // 
            // adaugareRezButon
            // 
            this.adaugareRezButon.Location = new System.Drawing.Point(355, 54);
            this.adaugareRezButon.Name = "adaugareRezButon";
            this.adaugareRezButon.Size = new System.Drawing.Size(103, 32);
            this.adaugareRezButon.TabIndex = 4;
            this.adaugareRezButon.Text = "Adaugare";
            this.adaugareRezButon.UseVisualStyleBackColor = true;
            this.adaugareRezButon.Click += new System.EventHandler(this.adaugareRezButon_Click);
            // 
            // modificareRezButon
            // 
            this.modificareRezButon.Location = new System.Drawing.Point(464, 54);
            this.modificareRezButon.Name = "modificareRezButon";
            this.modificareRezButon.Size = new System.Drawing.Size(103, 32);
            this.modificareRezButon.TabIndex = 5;
            this.modificareRezButon.Text = "Modificare";
            this.modificareRezButon.UseVisualStyleBackColor = true;
            this.modificareRezButon.Click += new System.EventHandler(this.modificareRezButon_Click);
            // 
            // stergereRezButon
            // 
            this.stergereRezButon.Location = new System.Drawing.Point(573, 54);
            this.stergereRezButon.Name = "stergereRezButon";
            this.stergereRezButon.Size = new System.Drawing.Size(103, 32);
            this.stergereRezButon.TabIndex = 6;
            this.stergereRezButon.Text = "Stergere";
            this.stergereRezButon.UseVisualStyleBackColor = true;
            this.stergereRezButon.Click += new System.EventHandler(this.stergereRezButon_Click);
            // 
            // cameraComboBox
            // 
            this.cameraComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cameraComboBox.FormattingEnabled = true;
            this.cameraComboBox.Location = new System.Drawing.Point(79, 423);
            this.cameraComboBox.Name = "cameraComboBox";
            this.cameraComboBox.Size = new System.Drawing.Size(62, 24);
            this.cameraComboBox.TabIndex = 7;
            // 
            // cameraLabel
            // 
            this.cameraLabel.AutoSize = true;
            this.cameraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cameraLabel.Location = new System.Drawing.Point(12, 425);
            this.cameraLabel.Name = "cameraLabel";
            this.cameraLabel.Size = new System.Drawing.Size(61, 18);
            this.cameraLabel.TabIndex = 8;
            this.cameraLabel.Text = "Camera";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(230, 425);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(90, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Data";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(405, 424);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(45, 22);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(341, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "NrZile";
            // 
            // adaugareRezConButon
            // 
            this.adaugareRezConButon.Location = new System.Drawing.Point(469, 422);
            this.adaugareRezConButon.Name = "adaugareRezConButon";
            this.adaugareRezConButon.Size = new System.Drawing.Size(103, 26);
            this.adaugareRezConButon.TabIndex = 13;
            this.adaugareRezConButon.Text = "Adaugare";
            this.adaugareRezConButon.UseVisualStyleBackColor = true;
            this.adaugareRezConButon.Click += new System.EventHandler(this.adaugareRezConButon_Click);
            // 
            // modificareRezConButon
            // 
            this.modificareRezConButon.Location = new System.Drawing.Point(578, 422);
            this.modificareRezConButon.Name = "modificareRezConButon";
            this.modificareRezConButon.Size = new System.Drawing.Size(103, 26);
            this.modificareRezConButon.TabIndex = 14;
            this.modificareRezConButon.Text = "Modificare";
            this.modificareRezConButon.UseVisualStyleBackColor = true;
            this.modificareRezConButon.Click += new System.EventHandler(this.modificareRezConButon_Click);
            // 
            // stergereRezConButon
            // 
            this.stergereRezConButon.Location = new System.Drawing.Point(687, 422);
            this.stergereRezConButon.Name = "stergereRezConButon";
            this.stergereRezConButon.Size = new System.Drawing.Size(103, 26);
            this.stergereRezConButon.TabIndex = 15;
            this.stergereRezConButon.Text = "Stergere";
            this.stergereRezConButon.UseVisualStyleBackColor = true;
            this.stergereRezConButon.Click += new System.EventHandler(this.stergereRezConButon_Click);
            // 
            // clientComboBox
            // 
            this.clientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(426, 13);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(146, 24);
            this.clientComboBox.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(359, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Client";
            // 
            // renuntareButon
            // 
            this.renuntareButon.Location = new System.Drawing.Point(682, 179);
            this.renuntareButon.Name = "renuntareButon";
            this.renuntareButon.Size = new System.Drawing.Size(103, 32);
            this.renuntareButon.TabIndex = 20;
            this.renuntareButon.Text = "Renuntare";
            this.renuntareButon.UseVisualStyleBackColor = true;
            this.renuntareButon.Click += new System.EventHandler(this.renuntareButon_Click);
            // 
            // confirmareButon
            // 
            this.confirmareButon.Location = new System.Drawing.Point(573, 179);
            this.confirmareButon.Name = "confirmareButon";
            this.confirmareButon.Size = new System.Drawing.Size(103, 32);
            this.confirmareButon.TabIndex = 21;
            this.confirmareButon.Text = "Confirmare";
            this.confirmareButon.UseVisualStyleBackColor = true;
            this.confirmareButon.Click += new System.EventHandler(this.salvareButon_Click);
            // 
            // RezervariForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirmareButon);
            this.Controls.Add(this.renuntareButon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clientComboBox);
            this.Controls.Add(this.stergereRezConButon);
            this.Controls.Add(this.modificareRezConButon);
            this.Controls.Add(this.adaugareRezConButon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cameraLabel);
            this.Controls.Add(this.cameraComboBox);
            this.Controls.Add(this.stergereRezButon);
            this.Controls.Add(this.modificareRezButon);
            this.Controls.Add(this.adaugareRezButon);
            this.Controls.Add(this.gridRezervari);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.gridRezervariContinut);
            this.Name = "RezervariForm";
            this.Text = "Rezervari";
            this.Load += new System.EventHandler(this.RezervariForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRezervariContinut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRezervari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridRezervariContinut;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.DataGridView gridRezervari;
        private System.Windows.Forms.Button adaugareRezButon;
        private System.Windows.Forms.Button modificareRezButon;
        private System.Windows.Forms.Button stergereRezButon;
        private System.Windows.Forms.ComboBox cameraComboBox;
        private System.Windows.Forms.Label cameraLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button adaugareRezConButon;
        private System.Windows.Forms.Button modificareRezConButon;
        private System.Windows.Forms.Button stergereRezConButon;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button renuntareButon;
        private System.Windows.Forms.Button confirmareButon;
    }
}