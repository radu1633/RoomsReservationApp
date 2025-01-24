namespace ProiectTap
{
    partial class ClientiForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ProiectTap.DataSet1();
            this.clientiTableAdapter = new ProiectTap.DataSet1TableAdapters.ClientiTableAdapter();
            this.numeClientText = new System.Windows.Forms.TextBox();
            this.nrTelefonText = new System.Windows.Forms.TextBox();
            this.numeClientLabel = new System.Windows.Forms.Label();
            this.nrTelefonLabel = new System.Windows.Forms.Label();
            this.adaugareButon = new System.Windows.Forms.Button();
            this.stergereButon = new System.Windows.Forms.Button();
            this.actualizareButon = new System.Windows.Forms.Button();
            this.salavareButon = new System.Windows.Forms.Button();
            this.prenumeClient = new System.Windows.Forms.TextBox();
            this.prenumeLabel = new System.Windows.Forms.Label();
            this.cautareButon = new System.Windows.Forms.Button();
            this.renuntareButon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(344, 219);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.selection_Changed);
            // 
            // clientiBindingSource
            // 
            this.clientiBindingSource.DataMember = "Clienti";
            this.clientiBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientiTableAdapter
            // 
            this.clientiTableAdapter.ClearBeforeFill = true;
            // 
            // numeClientText
            // 
            this.numeClientText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeClientText.Location = new System.Drawing.Point(377, 32);
            this.numeClientText.Name = "numeClientText";
            this.numeClientText.Size = new System.Drawing.Size(163, 26);
            this.numeClientText.TabIndex = 1;
            // 
            // nrTelefonText
            // 
            this.nrTelefonText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrTelefonText.Location = new System.Drawing.Point(377, 182);
            this.nrTelefonText.Name = "nrTelefonText";
            this.nrTelefonText.Size = new System.Drawing.Size(163, 26);
            this.nrTelefonText.TabIndex = 2;
            // 
            // numeClientLabel
            // 
            this.numeClientLabel.AutoSize = true;
            this.numeClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeClientLabel.Location = new System.Drawing.Point(377, 9);
            this.numeClientLabel.Name = "numeClientLabel";
            this.numeClientLabel.Size = new System.Drawing.Size(98, 20);
            this.numeClientLabel.TabIndex = 3;
            this.numeClientLabel.Text = "Nume client";
            // 
            // nrTelefonLabel
            // 
            this.nrTelefonLabel.AutoSize = true;
            this.nrTelefonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrTelefonLabel.Location = new System.Drawing.Point(377, 151);
            this.nrTelefonLabel.Name = "nrTelefonLabel";
            this.nrTelefonLabel.Size = new System.Drawing.Size(114, 20);
            this.nrTelefonLabel.TabIndex = 4;
            this.nrTelefonLabel.Text = "Numar telefon";
            // 
            // adaugareButon
            // 
            this.adaugareButon.Location = new System.Drawing.Point(577, 63);
            this.adaugareButon.Name = "adaugareButon";
            this.adaugareButon.Size = new System.Drawing.Size(97, 28);
            this.adaugareButon.TabIndex = 5;
            this.adaugareButon.Text = "Adaugare";
            this.adaugareButon.UseVisualStyleBackColor = true;
            this.adaugareButon.Click += new System.EventHandler(this.adaugareButon_Click);
            // 
            // stergereButon
            // 
            this.stergereButon.Location = new System.Drawing.Point(577, 107);
            this.stergereButon.Name = "stergereButon";
            this.stergereButon.Size = new System.Drawing.Size(97, 28);
            this.stergereButon.TabIndex = 6;
            this.stergereButon.Text = "Stergere";
            this.stergereButon.UseVisualStyleBackColor = true;
            this.stergereButon.Click += new System.EventHandler(this.stergereButon_Click);
            // 
            // actualizareButon
            // 
            this.actualizareButon.Location = new System.Drawing.Point(680, 63);
            this.actualizareButon.Name = "actualizareButon";
            this.actualizareButon.Size = new System.Drawing.Size(97, 28);
            this.actualizareButon.TabIndex = 7;
            this.actualizareButon.Text = "Modificare";
            this.actualizareButon.UseVisualStyleBackColor = true;
            this.actualizareButon.Click += new System.EventHandler(this.actualizareButon_Click);
            // 
            // salavareButon
            // 
            this.salavareButon.Location = new System.Drawing.Point(577, 151);
            this.salavareButon.Name = "salavareButon";
            this.salavareButon.Size = new System.Drawing.Size(97, 28);
            this.salavareButon.TabIndex = 8;
            this.salavareButon.Text = "Confirmare";
            this.salavareButon.UseVisualStyleBackColor = true;
            this.salavareButon.Click += new System.EventHandler(this.salavareButon_Click);
            // 
            // prenumeClient
            // 
            this.prenumeClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenumeClient.Location = new System.Drawing.Point(377, 109);
            this.prenumeClient.Name = "prenumeClient";
            this.prenumeClient.Size = new System.Drawing.Size(159, 26);
            this.prenumeClient.TabIndex = 9;
            // 
            // prenumeLabel
            // 
            this.prenumeLabel.AutoSize = true;
            this.prenumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenumeLabel.Location = new System.Drawing.Point(377, 86);
            this.prenumeLabel.Name = "prenumeLabel";
            this.prenumeLabel.Size = new System.Drawing.Size(121, 20);
            this.prenumeLabel.TabIndex = 10;
            this.prenumeLabel.Text = "Prenume client";
            // 
            // cautareButon
            // 
            this.cautareButon.Location = new System.Drawing.Point(680, 107);
            this.cautareButon.Name = "cautareButon";
            this.cautareButon.Size = new System.Drawing.Size(97, 28);
            this.cautareButon.TabIndex = 11;
            this.cautareButon.Text = "Cautare";
            this.cautareButon.UseVisualStyleBackColor = true;
            this.cautareButon.Click += new System.EventHandler(this.cautareButon_Click);
            // 
            // renuntareButon
            // 
            this.renuntareButon.Location = new System.Drawing.Point(681, 151);
            this.renuntareButon.Name = "renuntareButon";
            this.renuntareButon.Size = new System.Drawing.Size(96, 28);
            this.renuntareButon.TabIndex = 12;
            this.renuntareButon.Text = "Renuntare";
            this.renuntareButon.UseVisualStyleBackColor = true;
            this.renuntareButon.Click += new System.EventHandler(this.renuntareButon_Click);
            // 
            // ClientiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 220);
            this.Controls.Add(this.renuntareButon);
            this.Controls.Add(this.cautareButon);
            this.Controls.Add(this.prenumeLabel);
            this.Controls.Add(this.prenumeClient);
            this.Controls.Add(this.salavareButon);
            this.Controls.Add(this.actualizareButon);
            this.Controls.Add(this.stergereButon);
            this.Controls.Add(this.adaugareButon);
            this.Controls.Add(this.nrTelefonLabel);
            this.Controls.Add(this.numeClientLabel);
            this.Controls.Add(this.nrTelefonText);
            this.Controls.Add(this.numeClientText);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ClientiForm";
            this.Text = "Clienti";
            this.Load += new System.EventHandler(this.ClientiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource clientiBindingSource;
        private DataSet1TableAdapters.ClientiTableAdapter clientiTableAdapter;
        private System.Windows.Forms.TextBox numeClientText;
        private System.Windows.Forms.TextBox nrTelefonText;
        private System.Windows.Forms.Label numeClientLabel;
        private System.Windows.Forms.Label nrTelefonLabel;
        private System.Windows.Forms.Button adaugareButon;
        private System.Windows.Forms.Button stergereButon;
        private System.Windows.Forms.Button actualizareButon;
        private System.Windows.Forms.Button salavareButon;
        private System.Windows.Forms.TextBox prenumeClient;
        private System.Windows.Forms.Label prenumeLabel;
        private System.Windows.Forms.Button cautareButon;
        private System.Windows.Forms.Button renuntareButon;
    }
}