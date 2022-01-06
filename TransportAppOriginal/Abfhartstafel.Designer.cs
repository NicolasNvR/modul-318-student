namespace SwissTransportApp
{
    partial class Abfhartstafel
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
            this.DataGridStationsverbindungen = new System.Windows.Forms.DataGridView();
            this.Verkehrsmittel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NaechsteAbfhart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridStationsverbindungen)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridStationsverbindungen
            // 
            this.DataGridStationsverbindungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridStationsverbindungen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Verkehrsmittel,
            this.Nummer,
            this.Endstation,
            this.NaechsteAbfhart});
            this.DataGridStationsverbindungen.Location = new System.Drawing.Point(44, 168);
            this.DataGridStationsverbindungen.Name = "DataGridStationsverbindungen";
            this.DataGridStationsverbindungen.RowTemplate.Height = 24;
            this.DataGridStationsverbindungen.Size = new System.Drawing.Size(583, 243);
            this.DataGridStationsverbindungen.TabIndex = 0;
            // 
            // Verkehrsmittel
            // 
            this.Verkehrsmittel.HeaderText = "Verkehrsmittel";
            this.Verkehrsmittel.Name = "Verkehrsmittel";
            this.Verkehrsmittel.Width = 200;
            // 
            // Nummer
            // 
            this.Nummer.HeaderText = "Nummer";
            this.Nummer.Name = "Nummer";
            this.Nummer.Width = 70;
            // 
            // Endstation
            // 
            this.Endstation.HeaderText = "Endstation";
            this.Endstation.Name = "Endstation";
            this.Endstation.Width = 200;
            // 
            // NaechsteAbfhart
            // 
            this.NaechsteAbfhart.HeaderText = "Nächste Abfhart";
            this.NaechsteAbfhart.Name = "NaechsteAbfhart";
            this.NaechsteAbfhart.Width = 70;
            // 
            // Abfhartstafel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridStationsverbindungen);
            this.Name = "Abfhartstafel";
            this.Text = "Stationsverbindungen";
            this.Leave += new System.EventHandler(this.Abfhartstafel_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridStationsverbindungen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridStationsverbindungen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Verkehrsmittel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn NaechsteAbfhart;
    }
}